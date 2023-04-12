using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessontwo_csh
{
    internal class Program
    {
        static void ReverseNum() {
            string input;
            Console.WriteLine("Введите четырхзначное число:");
            input = Console.ReadLine();
            for (int i = input.Length-1; i >= 0 ; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
        }
        static void EvenNumbers() {
            string input;
            int tmp;
            Console.WriteLine("Введите шестизначное число число:");
            input = Console.ReadLine();

            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    tmp = int.Parse(input[i].ToString());
                    //tmp = (int)input[i]; - может в число записать значение буквы по таблице ASKI  
                    if (tmp % 2 == 0)
                    {
                        Console.WriteLine(tmp);
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Некоректный ввод");
            }             
            
        }
        static void TimeSec() {
            DateTime startTime = DateTime.Now;
            Console.WriteLine(startTime.ToString("yyyy.MM.dd HH:mm:ss.ffff"));
            ConsoleKey key= Console.ReadKey().Key;            
            DateTime stopTime = DateTime.Now;
            TimeSpan timeSpan = stopTime- startTime;
            Console.WriteLine($"\n Прошло {timeSpan.ToString("ss")} секунд");
        }
        static void Main(string[] args)
        {
            // ReverseNum();
            //EvenNumbers();
            //TimeSec();
            //работа с файловой систмой
            var streamwriter = new StreamWriter("file.txt");
            streamwriter.WriteLine("TEST");
            streamwriter.Close();

            var streamreader = new StreamReader("file.txt");
            Console.WriteLine(streamreader.ReadLine());
            streamreader.Close();
        }
    }
}
