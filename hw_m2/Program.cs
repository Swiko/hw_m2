using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_m2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string fullName = "Swiko Allen";
            int age = 23;
            string email = "hmd.swiko@gmail.com";
            float codeCount = 81;
            float mathCount = 79;
            float physicalCount = 75;

            string pattern = "ФИО: {0} \nВозраст {1} \nЭлектронная почта {2} \nБаллов по программированию {3} \nБаллов по математике {4} \nБаллов по физике {5} \n";
            Console.WriteLine(pattern, fullName, age, email, codeCount, mathCount, physicalCount);


            // task second

            float sumCount = codeCount + mathCount + physicalCount;
            float middleCount = sumCount / 3;

            Console.WriteLine($"Сумма баллов: {sumCount} \nСреднее арифметическое: {middleCount}");

            Console.ReadKey();

        }
    }
}
