using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

/*
Напишите тесты производительности для расчёта дистанции между точками с помощью BenchmarkDotNet. 
Рекомендуем сгенерировать заранее массив данных, чтобы расчёт шёл с различными значениями, 
но сам код генерации должен происходить вне участка кода, время которого будет тестироваться.
Для каких методов потребуется написать тест:
Обычный метод расчёта дистанции со ссылочным типом (PointClass — координаты типа float).
*/


namespace PointClass_float
{
    class Program
    {
        public static void Main(string[] args)
        { 
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
            Console.ReadKey();
        }
    }
}
