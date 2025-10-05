using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.Common;
using System.Diagnostics;
namespace Pre_Trainee_1_2
{
    internal class Program
    {
        static void ProcessData(string dataName)
        {
            Thread.Sleep(3000);
            Console.WriteLine($"Обработка {dataName} завершена за 3 секунды!");
        }
        async static Task ProcessDataAsync(string dataName)
        {
            await Task.Delay(3000);
            Console.WriteLine($"Асинхронная Обработка {dataName} завершена за 3 секунды!");

        }
        async static Task Main(string[] args)
        {
            Stopwatch sw=Stopwatch.StartNew();
            ProcessData("data1");
            ProcessData("data2");
            ProcessData("data3");
            sw.Stop();
            Console.WriteLine($"Синхронные методы затратили {sw.Elapsed}");

            sw.Restart();
            var task1 = ProcessDataAsync("File1");
            var task2 = ProcessDataAsync("File2");
            var task3 = ProcessDataAsync("File3");
            await Task.WhenAll(task1, task2, task3);
            sw.Stop();
            Console.WriteLine($"Асинхронные методы затратили {sw.Elapsed}");
            
        }
    }
}
