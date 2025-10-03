using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.Common;
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
             ProcessData("data1");//3 секунды
             ProcessData("data2");//3
             ProcessData("data3");//3

            ProcessDataAsync("File1");
            ProcessDataAsync("File2");//сразу все за 3
            await ProcessDataAsync("File3");
        }
    }
}
