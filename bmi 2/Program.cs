using System;

namespace bmi_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str_vyska;
            string str_hmotnost;
            double bmi;
            
            
            while (true)
            {
               Console.Clear();
               Console.WriteLine("Kalkulačka BMI");
               Console.WriteLine("--------------");

               Console.WriteLine("Zadej výšku(cm)");
               str_vyska = Console.ReadLine();
               double vyska = double.Parse(str_vyska);
               if ((vyska >=250) || (vyska <=50))
               {
                Console.WriteLine();
                Console.WriteLine("Zadal jsi nesmyslné údaje");
               }
               else
               {
                  vyska = vyska / 100.0;
                  Console.WriteLine("Zadej hmotnost (Kg) : ");
                  str_hmotnost = Console.ReadLine();
                  double hmotnost = double.Parse(str_hmotnost);
                  if ((hmotnost >= 300) || (hmotnost <=10 ))
                  {
                    Console.WriteLine();
                    Console.WriteLine("Zadal jsi nesmyslné údaje");
                  }
                  else
                  {
                   bmi = hmotnost / (vyska * vyska);
                   string str_bmi = bmi.ToString("F2");
                        if (bmi <= 18.49)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Trpíš podváhou!");
                        }
                         if (( bmi >=18.50) && (bmi <= 24.99))
                         {
                            Console.WriteLine();
                            Console.WriteLine("Máš zdravou váhu!");
                         }
                           if ((bmi >= 25.00) && (bmi<=29.99))
                           {
                            Console.WriteLine();
                            Console.WriteLine("Máš nadváhu!");
                           }
                             if ((bmi >= 30.00) && (bmi <= 34.99))
                             {
                               Console.WriteLine();
                               Console.WriteLine("Trpíš mírnou obezitou!");
                             }
                               if ((bmi >= 35.00) && (bmi <= 39.99))
                               {
                                  Console.WriteLine(); 
                                  Console.WriteLine("Trpíš závažnou obezitou!");
                               }
                                  if(bmi >=40.00)
                                  {
                                    Console.WriteLine();
                                    Console.WriteLine("Jsi morbidně obézní");
                                  }


                        Console.WriteLine("Tvoje BMI je " + str_bmi );
                  };
               }Console.ReadLine();
            }
        }
    }
}














