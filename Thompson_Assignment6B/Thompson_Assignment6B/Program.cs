using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Assignment6B
{
    class DuplicateFile : Exception
    {
        public DuplicateFile(string file)
            : base (file + " already exists")
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            string fileRead, fileCopy, line;
            List<string> fileList = new List<string>();

            do
            {
                Console.Write("Enter the file name to read: ");
                fileRead = Console.ReadLine();
                try
                {
                    StreamReader sr = new StreamReader(fileRead);
                    while ((line = sr.ReadLine()) != null)
                    {
                        fileList.Add(line);
                    }

                    sr.Close();
                    repeat = false;
                }
                catch (FileNotFoundException)
                {
                    Console.Write("File name doesn't exist.\nInput 'exit' to abort the code, or press enter to try again: ");
                    string exit = Console.ReadLine();
                    if (exit == "exit")
                    {
                        Environment.Exit(0);
                    }
                }
            } while (repeat == true);

            Console.WriteLine("");
            repeat = true;

            do
            {
                Console.Write("Enter a file name for the new file: ");
                fileCopy = Console.ReadLine();
                try
                {
                    if (File.Exists(fileCopy) == true)
                    {
                        throw new DuplicateFile(fileCopy);
                    }
                    repeat = false;
                }
                catch (DuplicateFile ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.Write("Input 'change' to change the file name, or press enter to overwrite the existing file: ");
                    string change = Console.ReadLine();
                    if (change != "change")
                    {
                        repeat = false;
                    }
                }

            } while (repeat == true);

            StreamWriter sw = new StreamWriter(fileCopy);
            foreach (string fileLine in fileList)
            {
                sw.WriteLine(fileLine);
            }
            sw.Close();

            Console.WriteLine("\n" + fileRead + " successfully copied to " + fileCopy);

        }
    }
}
