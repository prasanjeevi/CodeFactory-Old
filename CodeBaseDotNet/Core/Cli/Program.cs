using System;
using static System.Console;
using Common.Core;
using Common.Roslyn;
using Common.Core.Models;

namespace Cli
{
  class Program
  {
    static void Main(string[] args)
    {
        if(args.Length == 0)
        {
          WriteLine("Hello World!");
          return;
        }

        switch(args[0])
        {
          case "types":
            System.IO.File.WriteAllText("../docs/types.md", Types.Print());
            break;
          case "repl":
            ExecuteCSharpRepl();
            break;
          case "roslyn":
            ExecuteCSharp();
            break;
          case "cultures":
            System.IO.File.WriteAllText("../docs/cultures.md", Cultures.Print());
            break;
          case "inr":
            WriteLine(Cultures.FormatToIndianCurrency(29531.96M));
            WriteLine(Cultures.FormatToIndianCurrency(446517.7099M));
            break;
          case "xml-writer":
            FileSystem.CreateCSProjXmlFile();
            break;
          case "stream-writer":
            FileSystem.WriteUsingStreamWriter();
            break;
          case "file-stream":
            FileSystem.WriteUsingFileStream();
            break;
          case "stream-reader":
            WriteLine(FileSystem.ReadUsingStreamReader("Program.cs"));
            break;
          case "file-store-demo":
            FileStoreDemo();
            break;
          default:
            WriteLine("Bye");
            break;
        }
    }

    static void ExecuteCSharp()
    {
      CSharpScriptEngine.Execute(
        //This could be code submitted from the editor
        @"
        public class ScriptedClass
        {
          public string HelloWorld {get;set;}
          public ScriptedClass()
          {
              HelloWorld = ""Hello Roslyn!"";
          }
        }");
      //And this from the REPL
      WriteLine(CSharpScriptEngine.Execute("new ScriptedClass().HelloWorld"));
    }

    static void ExecuteCSharpRepl()
    {
      while (true)
      {
          var str = Console.ReadLine();
          WriteLine(CSharpScriptEngine.Execute(str));
      }
    }

    static void FileStoreDemo()
    {
      /*
      // if int[] is null lineNumbers.Length will throw exception
      int[] lineNumbers = null;
      if(lineNumbers != null && lineNumbers.Length > 0)
      {
      }
      
      // if path is file it has to create folder + file
      var path = "/Users/sanjeevi/Folder/File.cs";
      var dir = System.IO.Path.GetDirectoryName(path);
      System.IO.Directory.CreateDirectory(dir);
      System.IO.File.WriteAllText(path, "Hello");
      */

      FileStore fs = new FileStore();
      fs.WorkingDirectory = Environment.CurrentDirectory;
      fs.MessageRead += MessageRead;
      string path = fs.Save("bin/2018-06-27", "Hello");
      fs.Read("bin/2018-06-27");

      FileStoreCqs fscqs = new FileStoreCqs();
      fscqs.WorkingDirectory = Environment.CurrentDirectory;
      fscqs.Save("bin/2018-08-27", "Hello Better");
      Console.WriteLine(fscqs.Read("bin/2018-08-27"));
    }

    static void MessageRead(object sender, MessageEventArgs e)
    {
      WriteLine(e.Message);
    }
  }
}
