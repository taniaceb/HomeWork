using System;

namespace HW_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite viena skaiciu nuo -9 iki 9");
            string number = Console.ReadLine();

            //Patikrinti, ar buvo ivestas skaicius

            if (number == "")
            {
                Console.WriteLine("Skaicius nebuvo ivestas ");
            }
            else
            {
                Console.WriteLine(CheckIsNumber(number));
                Console.WriteLine( StringToInt(-9, 9, number));
            }

            
            

        }

        static bool StringToInt(int a, int b, string c)
        {
            bool d = false;
            int num = Convert.ToInt32(c);
            if ( num >= a && num <= b )
            {
                d = true;
            }

            return d;

        }







        static bool CheckIsNumber(string a)
        {

            bool check = true;

            //Tikriname, 1-a simboli

            for (int i = 0; i < 1; i++)
            {
                char simbol1 = a[i];

                //Jei buvo ivestas tik vienas simbolis, jis g.b. tik 0,1,2,3,4,5,6,7,8,9

                if (a.Length <= 1 && (simbol1 != '0' && simbol1 != '1' && simbol1 != '2' && simbol1 != '3' && simbol1 != '4' && simbol1 != '5' && simbol1 != '6' && simbol1 != '7' && simbol1 != '8' && simbol1 != '9'))

                {
                    check = false;
                }

                //Jei buvo ivesta >1 simboli, pirmas simbolis <> 0

                else if (a.Length > 1 && simbol1 == '0')
                {
                    check = false;
                }

                //Jei pirmas simbolis - (minuso zenklas), 2- as simbolis gali buti tik 1,2,3,4,5,6,7,8,9

                else if (a.Length > 1 && simbol1 == '-')
                {
                    for (int j = 1; j < 2; j++)
                    {
                        char simbol2 = a[j];

                        if (simbol2 == '0' || (simbol2 != '1' && simbol2 != '2' && simbol2 != '3' && simbol2 != '4' && simbol2 != '5' && simbol2 != '6' && simbol2 != '7' && simbol2 != '8' && simbol2 != '9'))

                        {
                            check = false;
                        }
                        //Tikriname visus kitus simboilius, jei simboliu ilgis > 2
                        else
                        {
                            for (int k = 2; k < a.Length; k++)
                            {
                                char simbol3 = a[k];
                                if (simbol3 != '0' && simbol3 != '1' && simbol3 != '2' && simbol3 != '3' && simbol3 != '4' && simbol3 != '5' && simbol3 != '6' && simbol3 != '7' && simbol3 != '8' && simbol3 != '9')

                                {
                                    check = false;
                                    break;

                                }
                                else
                                {
                                    check = true;
                                }
                            }
                            
                        }

                    }
                }
            }


            return check;
        }

    }


}   
