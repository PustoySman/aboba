using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;



namespace govyadina
{
    internal class Program
    {
        static void Main()
        {
            Console.Beep(5000,1000);
            Console.WriteLine("███╗   ███╗███████╗███╗   ██╗██╗   ██╗");
            Console.WriteLine("████╗ ████║██╔════╝████╗  ██║██║   ██║");
            Console.WriteLine("██╔████╔██║█████╗  ██╔██╗ ██║██║   ██║");
            Console.WriteLine("██║╚██╔╝██║██╔══╝  ██║╚██╗██║██║   ██║");
            Console.WriteLine("██║ ╚═╝ ██║███████╗██║ ╚████║╚██████╔╝");
            Console.WriteLine("╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝");
            //                       
            
            //
            int time_seconds;
            char choice;
            Console.WriteLine("1.Таймер 2.Секундомер \nВыберите нужную вам функцию: ");
            choice = char.Parse(Console.ReadLine());
            switch (choice)
            {
                case '1':
                    Console.WriteLine("Введите сколько времени нужно отсчитать в секундах: ");
                    time_seconds = Convert.ToInt32(Console.ReadLine());
                    timer(time_seconds);
                    break;

                case '2':
                    Console.WriteLine("Нажмите enter для начала работы.\nНажмите  для конца работы.");
                    stopwatch();
                    break;
            }
        }
        static void timer(int time_seconds)
        {
            for(int i = 1; i < time_seconds + 1; i++)
            {
                Console.Beep(1234, 500);
                Console.WriteLine(i + " sec"); // сделал sec чтобы не париться с окончаниями вроде секунда/секунды/секунд
                Thread.Sleep(1000);
            }
            
        }
        static void stopwatch()
        {
            //работает - не трогай
            int minutes =0;
            int hours=0;
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                for (int seconds = 0; true; seconds++)
                {
                    Console.WriteLine("Время - " + hours + ":" + minutes + ":" + seconds);
                    Thread.Sleep(1000);
                    if (seconds >= 60)
                    {
                        seconds = 0;
                        minutes++;
                    }
                    if (minutes >= 60)
                    {
                        minutes = 0;
                        hours++;
                    }
                    if (Console.KeyAvailable == true)

                    {

                        cki = Console.ReadKey(true);

                        if (cki.Key == ConsoleKey.X)

                        {
                            Console.WriteLine("Завершение работы секундомера");
                            break;
                            
                        }

                    }
                }
            }
        }
    }
}
