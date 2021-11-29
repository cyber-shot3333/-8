using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = "Logs";
            if (!Directory.Exists(path1))
            {
                Directory.CreateDirectory(path1);
            }
            string path2 = "Logs/Log.txt";
            using (StreamWriter sw = new StreamWriter(path2, true))
            {
                sw.WriteLine("1 2 3 4 5 6 7 8 9 10");
                sw.Close();
            }
            #region Запись данных в файл
            using (StreamWriter sw = new StreamWriter(path2, false))
            {
                int n = 10;
                Random random = new Random();
                int[] arrayWrite = new int[n];
                for (int i = 0; i < n; i++)
                {
                    arrayWrite[i] = random.Next(-50, 50);
                    sw.Write(arrayWrite[i] + " ");
                }
            }
            #endregion
            #region Чтение и обработка данных из файла
            using (StreamReader sr = new StreamReader(path2))
            {
                double sum = 0;
                string[] arrayRead = sr.ReadToEnd().Split(' ');
                for (int i = 0; i < (arrayRead.Length - 1); i++)
                {
                    Console.WriteLine(arrayRead[i]);
                    sum += Convert.ToDouble(arrayRead[i]);
                }
                Console.WriteLine("Сумма чисел = {0}", sum);
            }
            #endregion
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}