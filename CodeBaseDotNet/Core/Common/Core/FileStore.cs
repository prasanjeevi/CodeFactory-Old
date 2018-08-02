using System;
using System.IO;
using Common.Core.Models;
namespace Common.Core
{
  public class FileStore
  {
    public string WorkingDirectory { get; set; }
    public string Save(string id, string contents)
    {
      var path = Path.Combine(this.WorkingDirectory, id + ".txt");
      File.WriteAllText(path, contents);
      return path;
    }
    public event EventHandler<MessageEventArgs> MessageRead;

    public void Read(string id)
    {
      var path = Path.Combine(this.WorkingDirectory, id + ".txt");
      string contents = File.ReadAllText(path);
      this.MessageRead(this, new MessageEventArgs(){ Message = contents });
    }
  }
}