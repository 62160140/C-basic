using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using NameSpace


namespace BasicProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string question = "How many baht do you want to withdraw, 100 or more?";
            string errMes = "Please enter an amount ending in 0";
            Console.Write(question);
            int amount = int.Parse(Console.ReadLine());

            while (true) {
                int thousand = 0, five_hundred = 0, one_hundred = 0, fraction = 0;
                while (amount % 100 != 0)
                {
                    Console.WriteLine(errMes);
                    Console.Write(question);
                    amount = int.Parse(Console.ReadLine());
                }

                thousand = amount / 1000; //[2700 => 2] [200  => 0]
                if(amount > thousand)
                {  
                    //มีเศษจาก 1000
                    fraction = (amount - (thousand * 1000)); //  [2700=> 700]

                }
                else
                {
                    fraction = amount; // [200=>0]
                }
                five_hundred =  fraction / 500;
                if (amount > five_hundred) 
                {
                    //มีเศษจาก 500
                    fraction -= five_hundred * 500;

                }
                if (fraction >= 100) { one_hundred = fraction / 100; }
                Console.WriteLine("Your input {0}",amount);
                Console.WriteLine("thouand : {0}\nfive_hundred : {1}\none_hundred : {2}", thousand, five_hundred, one_hundred);
                Console.Write(question);
                amount = int.Parse(Console.ReadLine());
            }


            Console.ReadLine();
        }
    }
}
