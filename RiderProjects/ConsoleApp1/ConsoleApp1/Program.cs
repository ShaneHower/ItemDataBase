using System;
using System.Diagnostics;
using System.IO;

namespace LogWriter
{
    class Program
    {

        private string path;

        public Program(string path)
        {
            this.path = path;
        }
        
        public void CreateFile()
        {
            if (!File.Exists(this.path))
            {
                var myFile = File.Create(this.path);
                myFile.Close();
                Console.WriteLine("File Created");
               
            }

            else
            {
                Console.WriteLine("File Already Exists");
            }
        }

        public void WriteLog(string message)
        {
            using (TextWriter tw = new StreamWriter(this.path, true))
            {
                tw.WriteLine("{0} : {1}", DateTime.Today, message); 
            }
        }

        public void DisplayLog()
        {
            Process.Start(@"notepad.exe ", this.path);
        }

        public void Print(string message)
        {
            CreateFile();
            WriteLog(message);
        }
        
        static void Main(string[] args)
        {
            var path = @"C:\Users\Shane_Programming\RiderProjects\Log\test.txt";
            Program logWriter = new Program(path);
            logWriter.CreateFile();
            logWriter.WriteLog("hello world");
            logWriter.DisplayLog();
        }
    }
}
