namespace PracticeLab 
{
    using System;
    using System.IO;

    public class FileSaver {
        string fileName;

        public FileSaver(string filename) {
            this.fileName = filename;
            File.Create(this.fileName).Close();
        }

        public void AppendLine(string line) {
            File.AppendAllText(this.fileName, line + Environment.NewLine);
        }
    }
}