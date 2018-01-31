using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthdays2
{
    class FileManipulation
    {
        public static string GetFilePath()
        {
            string exeFolder = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string file = exeFolder + @"\BirthdayFile.txt";
            return file;
        }
        public static void CreateFile()
        {
            string path = GetFilePath();
            StreamWriter file = new StreamWriter(path);
            file.WriteLine("");
            file.Close();
        }
        public static void CheckForFile()
        {
            string path = GetFilePath();
            if (!File.Exists(path))
            {
                CreateFile();
            }
        }
        public static string[] ReadFile()
        {
            string path = GetFilePath();
            string[] lines = File.ReadAllLines(path);
            return lines;
        }
        public static void WriteToFile(string input)
        {
            string path = GetFilePath();
            StreamWriter file = new StreamWriter(path, append: true);
            file.WriteLine(input);
            file.Close();
        }
    }
}
