using System;

namespace _17032022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-ci ededi daxil edin");
            string num1Str = Console.ReadLine();
            int num1 = Convert.ToInt32(num1Str);

            Console.WriteLine("2-ci ededi daxil edin");
            string num2Str = Console.ReadLine();
            int num2 = Convert.ToInt32(num2Str);

            Console.WriteLine("3-ci ededi daxil edin");
            string num3Str = Console.ReadLine();
            int num3 = Convert.ToInt32(num3Str);



            Console.WriteLine($"En boyuk eded: {FindBiggest(num1,num2,num3)}");


            Console.WriteLine("1-ci qiymeti daxil edin");
            string price1Str = Console.ReadLine();
            double price1 = Convert.ToDouble(price1Str);

            Console.WriteLine("2-ci qiymeti daxil edin");
            string price2Str = Console.ReadLine();
            double price2 = Convert.ToDouble(price2Str);

            Console.WriteLine("3-ci qiymeti daxil edin");
            string price3Str = Console.ReadLine();
            double price3 = Convert.ToDouble(price3Str);
            Console.WriteLine($"Odenilecek mebleg: {CalcPrice(price1, price2, price3)}");

            Console.WriteLine(Sum(34,4));

            Console.WriteLine(Calc(33,10,4));
            Console.WriteLine(Calc(33, 10, 4,5));
            Console.WriteLine(Calc(33, 10, 4, 5,9,11));

            string[] names = { "hikkmet", "abdulla", "zeyneb" };
            ChangeLastName(names, "nergiz");

            Console.WriteLine("Names:");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            string word = "Hello, ";
            word = "new string";

            Console.WriteLine(word);

            AddToString(ref word, "World");
            Console.WriteLine(word);

            int age = 45;
            age = 46;

            string name = "Hikmet";
            name = "Nergiz";

            Console.WriteLine(name);

            int num = 44;
            Add(ref num, 10);
            Console.WriteLine(num);


            int inputInt = 4;

           


            SetZero(out inputInt);
            int total = inputInt + 34;
            Console.WriteLine(inputInt);


            int intputInt2 = 25;
            Set20(ref intputInt2);
            Console.WriteLine(intputInt2);
        }

       static void Add(ref int num,int additionalNum)
       {
            num =num+ additionalNum;
            Console.WriteLine(num);
       }

       static void SetZero(out int num)
       {
            num = 0;
       }

        static void Set20(ref int num)
        {
            num = 20;
        }

        static void ChangeLastName(string[] arr,string name)
        {
            string[] newNames = new string[arr.Length];
            arr = newNames;
            arr[arr.Length - 1] = name;
        }

        static void AddToString(ref string str,string additionalStr)
        {
            str = str + additionalStr;
            Console.WriteLine(str);
        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Sum(int num1, int num2, int num3 = 0)
        {
            return num1 + num2 + num3;
        }
        static double Sum(double num1, double num2)
        {
            return num1 + num2;
        }

        static int Calc(params int[] numbers)
        {
            int result = 1;
            foreach (var item in numbers)
            {
                result *= item;
            }
            return result;
        }
      

        static int FindBiggest(int num1,int num2,int num3)
        {
            if (num1 > num2 && num1 > num3)
                return num1;
            else if (num2 > num3 && num2 > num1)
                return num2;
            else
                return num3;
        }

        static double FindBiggest(double num1,double num2,double num3)
        {
            if (num1 > num2 && num1 > num3)
                return num1;
            else if (num2 > num3 && num2 > num1)
                return num2;
            else
                return num3;
        }


        static double CalcPrice(double price1,double price2,double price3)
        {
            if (price1 < price2 && price1 < price3)
                return price2 + price3;
            else if (price2 < price1 && price2 < price3)
                return price1 + price3;
            else
                return price1 + price2;
        }
    }
}
