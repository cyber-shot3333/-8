using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Задание_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите адрес папки формата C:\\user\\folder");
            string path = Console.ReadLine();
            if (Directory.Exists(path))
            {
                #region Вывод файлов в каталоге
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(path);
                foreach (string s in files)
                {
                    Console.WriteLine(s.Replace(path, ""));
                }
                Console.WriteLine();
                #endregion
                #region Вывод подкаталогов и файлов в них
                string[] dirs = Directory.GetDirectories(path);
                foreach (string s in dirs)
                {
                    Console.WriteLine("Подкаталог:");
                    Console.WriteLine(s.Replace(path, ""));
                    foreach (string pod in Directory.GetDirectories(s))
                    {
                        Console.WriteLine(pod.Replace(path, ""));
                    }
                    string[] filePod = Directory.GetFiles(s);
                    Console.WriteLine();
                    Console.WriteLine("Файлы в подкоталоге");
                    foreach (string f in filePod)
                    {
                        Console.WriteLine(f.Replace(path, ""));
                    }
                    Console.WriteLine();
                }
                #endregion
            }
            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
