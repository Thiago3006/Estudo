using System.IO;

namespace FilesFileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\thiag\OneDrive\Documentos\curso c#\course.txt";
            string targetPath = @"C:\Users\thiag\OneDrive\Documentos\curso c#\course2.txt";
            //FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //FileInfo fileInfo = new FileInfo(sourcePath);
                //fileInfo.CopyTo(targetPath);
                //string[] lines = File.ReadAllLines(sourcePath);
                //foreach(string line in lines)
                //{
                //    Console.WriteLine(line);
                //}

                //fs = new FileStream(sourcePath, FileMode.Open);
                //sr = new StreamReader(fs);
                
                
                sr = File.OpenText(sourcePath);
                while (!sr.EndOfStream) // leitura até o final do arquivo.
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                
                /* pode ser feito desta maneira?                
                Console.WriteLine(sr.ReadToEnd()); */


            }

            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                //if (fs != null) fs.Close();
            }
        }
    }
}