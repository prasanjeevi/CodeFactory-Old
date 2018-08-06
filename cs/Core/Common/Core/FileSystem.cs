using System.IO;
using System.Xml;
using System.Text;

namespace Common.Core
{
  public class FileSystem
  {
    /* 
      XmlWriter [abstract]
      Represents a writer that provides a fast, non-cached, forward-only way to generate streams or files that contain XML data.

      XmlTextWriter
      Represents a writer that provides a fast, non-cached, forward-only way of generating streams or files containing XML data that conforms to the W3C Extensible Markup Language (XML) 1.0 and the Namespaces in XML recommendations.
      Starting with the .NET Framework 2.0, we recommend that you use the XmlWriter class instead.
    */
    public static void CreateCSProjXmlFile()
    {
      using(var writer = XmlWriter.Create("bin/sample1.csproj")) //System.IO.DirectoryNotFoundException
      {
        writer.WriteStartElement("Project");
        writer.WriteAttributeString("Sdk", "Microsoft.NET.Sdk");
          writer.WriteStartElement("PropertyGroup");
            writer.WriteStartElement("OutputType");
              writer.WriteString("Exe");
            writer.WriteEndElement();
            writer.WriteStartElement("TargetFramework");
              writer.WriteString("netcoreapp2.1");
            writer.WriteEndElement();
          writer.WriteEndElement();
        writer.WriteEndElement();
      }

      var settings = new XmlWriterSettings();
      settings.Indent = true;
      settings.IndentChars = "  ";
      settings.OmitXmlDeclaration = true;
      using(var writer = XmlWriter.Create("bin/sample2.csproj", settings)) //System.IO.DirectoryNotFoundException
      {
        writer.WriteStartElement("Project");
        writer.WriteAttributeString("Sdk", "Microsoft.NET.Sdk");
          writer.WriteStartElement("PropertyGroup");
            writer.WriteStartElement("OutputType");
              writer.WriteString("Exe");
            writer.WriteEndElement();
            writer.WriteStartElement("TargetFramework");
              writer.WriteString("netcoreapp2.1");
            writer.WriteEndElement();
          writer.WriteEndElement();
        writer.WriteEndElement();
      }


      using(var writer = new XmlTextWriter("bin/sample3.csproj", null))
      {
        writer.Formatting = Formatting.Indented;
        writer.Indentation = 2;
        writer.IndentChar = ' ';

        writer.WriteStartElement("Project");
        writer.WriteAttributeString("Sdk", "Microsoft.NET.Sdk");
          writer.WriteStartElement("PropertyGroup");
            writer.WriteStartElement("OutputType");
              writer.WriteString("Exe");
            writer.WriteEndElement();
            writer.WriteStartElement("TargetFramework");
              writer.WriteString("netcoreapp2.1");
            writer.WriteEndElement();
          writer.WriteEndElement();
        writer.WriteEndElement();
      }
    }

    /*
      StreamWriter
      Implements a TextWriter for writing characters to a stream in a particular encoding.
    */
    public static void WriteUsingStreamWriter()
    {
      using(var writer = new StreamWriter("bin/file1.txt"))
      {
        writer.WriteLine("File1");
      }
      using(var writer = new StreamWriter("bin/file2.txt", true))
      {
        writer.WriteLine("File2");
      }
      using(var writer = new StreamWriter("bin/file3.txt", true, Encoding.UTF8 ))
      {
        writer.WriteLine("File3");
      }
      using(var writer = new StreamWriter("bin/file4.txt", true, Encoding.UTF8, 2 ))
      {
        writer.WriteLine("File4");
      }
    }

    public static void WriteUsingFileStream()
    {
      using(var writer = new FileStream("bin/file5.txt", FileMode.Append))
      {
        string data = "File5";
        var bytes = Encoding.UTF8.GetBytes(data);
        writer.Write(bytes, 0, bytes.Length);
      }
    }

    public static string ReadUsingStreamReader(string filePath)
    {
      string content = null;
      using(StreamReader reader = new StreamReader(filePath))
      {
        content = reader.ReadToEnd();
      }
      return content;
    }
  }
}