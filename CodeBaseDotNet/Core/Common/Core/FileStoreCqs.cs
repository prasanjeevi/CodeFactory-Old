using System;
using System.IO;

namespace Common.Core
{
    public class FileStoreCqs
    {
        public string WorkingDirectory { get; set; }
        public void Save(string id, string contents)
        {
            var path = GetFileName(id);
            File.WriteAllText(path, contents);
        }

        public string Read(string id)
        {
            var path = GetFileName(id);
            return File.ReadAllText(path);
        }

        public string GetFileName(string id)
        {
            return Path.Combine(this.WorkingDirectory, id + ".txt");
        }
    }
}
