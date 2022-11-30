using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace youtube
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("a=");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b=");
            //int b = int.Parse(Console.ReadLine());


            //if (a == b)
            //{
            //    Console.WriteLine("mutqagrvac tvery havasar en");
            //}
            //else if (a > b)
            //{
            //    Console.WriteLine("maximum = " + a);
            //}
            //else
            //{
            //    Console.WriteLine("maximum = " + b);
            //}


            //string name = "bob";
            //Console.WriteLine(name);

            //name = "jhon";
            //Console.WriteLine(name);


            //Console.WriteLine("hello \nworld");
            //Console.WriteLine("hello \tworld");
            //Console.WriteLine("hello \\world");


            //bool: хранит значение true или false(логические литералы).
            //bool alive = true;
            //bool isDead = false;

            //byte: хранит целое число от 0 до 255 и занимает 1 байт.
            //byte bit1 = 1;
            //byte bit2 = 102;

            //sbyte: хранит целое число от -128 до 127 и занимает 1 байт.
            //sbyte bit1 = -101;
            //sbyte bit2 = 102;

            //short: хранит целое число от -32768 до 32767 и занимает 2 байта.
            //short n1 = 1;
            //short n2 = 102;

            //ushort: хранит целое число от 0 до 65535 и занимает 2 байта.
            //ushort n1 = 1;
            //ushort n2 = 102;

            //int: хранит целое число от -2147483648 до 2147483647 и занимает 4 байта.
            //Все целочисленные литералы по умолчанию представляют значения типа int:
            //int a = 10;
            //int b = 0b101;  // бинарная форма b =5
            //int c = 0xFF;   // шестнадцатеричная форма c = 255

            //uint: хранит целое число от 0 до 4294967295 и занимает 4 байта.
            //uint a = 10;
            //uint b = 0b101;
            //uint c = 0xFF;
            //uint a = 10U;

            //long: хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт.
            //long a = -10;
            //long b = 0b101;
            //long c = 0xFF;
            //long b = 20L;

            //ulong: хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт.
            //ulong a = 10;
            //ulong b = 0b101;
            //ulong c = 0xFF;
            //ulong c = 30UL;

            //float: хранит число с плавающей точкой от -3.4 * 1038 до 3.4 * 1038 и занимает 4 байта.
            //float a = 3.14F;
            //float b = 30.6f;
            //double: хранит число с плавающей точкой от ±5.0 * 10 - 324 до ±1.7 * 10308 и занимает 8 байта.
            //все вещественные литералы(дробные числа) рассматриваются как значения типа double.
            //decimal: хранит десятичное дробное число.
            //Если употребляется без десятичной запятой, имеет значение от ±1.0 * 10 - 28 до ±7.9228 * 1028,
            //может хранить 28 знаков после запятой и занимает 16 байт.
            //decimal c = 1005.8M;
            //decimal d = 334.8m;

            //char: хранит одиночный символ в кодировке Unicode и занимает 2 байта.
            //Этому типу соответствуют символьные литералы:
            //char a = 'A';
            //char b = '\x5A';
            //char c = '\u0420';

            //string: хранит набор символов Unicode.
            //Этому типу соответствуют строковые литералы.
            //string hello = "Hello";
            //string word = "world";

            //object: может хранить значение любого типа данных и занимает 4 байта на 32 - разрядной платформе
            //и 8 байт на 64 - разрядной платформе.
            //object a = 22;
            //object b = 3.14;
            //object c = "hello code";

            ////primer
            //string name = "Tom";
            //int age = 33;
            //bool isEmployed = false;
            //double weight = 78.65;
            //Console.WriteLine($"name: {name}");
            //Console.WriteLine($"age: {age}");
            //Console.WriteLine($"weight: {weight}");
            //Console.WriteLine($"isEmployed: {isEmployed}");


            ////Console.WriteLine()
            //string hello = "Hello World";
            //Console.WriteLine(hello);
            //Console.WriteLine("Welcom to C#!");
            //Console.WriteLine("Goodbay World...");
            //Console.WriteLine(24.5);

            //интерполяция
            //string name = "Tom";
            //int age = 34;
            //double height = 1.7;
            //Console.WriteLine($"name: {name}  age: {age}  height: {height}m");

            //плейсхолдер
            //string name = "Tom";
            //int age = 34;
            //double height = 1.7;
            //Console.WriteLine("name: {0}  age: {2}  height: {1}m", name, height, age);

            ////Console.Write()
            //string name = "Tom";
            //int age = 34;
            //double height = 1.7;
            //Console.Write($"name: {name}  age: {age}  height: {height}m");

            ////Console.ReadLine()
            //Console.Write("Your Name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello {name}");

            ////Convert
            //Console.Write("Your Name: ");
            //string name = Console.ReadLine();

            //Console.Write("Your Age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Your Height: ");
            //double height = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Your Salary: ");
            //decimal salary = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine($"name: {name}  age: {age}  height: {height}m  salary: {salary}$");


            //++
            //Операция инкремента
            //Инкремент бывает префиксным: ++x - сначала значение переменной x увеличивается на 1,
            //а потом ее значение возвращается в качестве результата операции.
            //И также существует постфиксный инкремент: x++ - сначала значение переменной x возвращается
            //в качестве результата операции, а затем к нему прибавляется 1.
            //int x1 = 5;
            //int z1 = ++x1; // z1=6; x1=6
            //Console.WriteLine($"{x1} - {z1}");

            //int x2 = 5;
            //int z2 = x2++; // z2=5; x2=6
            //Console.WriteLine($"{x2} - {z2}");


            //--
            //Операция декремента или уменьшения значения на единицу.
            //Также существует префиксная форма декремента(--x) и постфиксная(x--).
            //int x1 = 5;
            //int z1 = --x1; // z1=4; x1=4
            //Console.WriteLine($"{x1} - {z1}");

            //int x2 = 5;
            //int z2 = x2--; // z2=5; x2=4
            //Console.WriteLine($"{x2} - {z2}");





        }
    }
}
