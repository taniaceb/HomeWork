using System;

namespace HW_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite viena skaiciu nuo -9 iki 9");
            string number = Console.ReadLine();
            Console.WriteLine(CheckIsNumber(ref number));

        }

        static bool CheckIsNumber(ref string a)
        {

            bool check = true;


            for (int i = 0; i < 1; i++)
            {
                char simbol1 = a[i];

                if (a.Length <= 1 && (simbol1 != '0' && simbol1 != '1' && simbol1 != '2' && simbol1 != '3' && simbol1 != '4' && simbol1 != '5' && simbol1 != '6' && simbol1 != '7' && simbol1 != '8' && simbol1 != '9'))

                {
                    check = false;
                }


                else if (a.Length > 1 && simbol1 == '0')
                {
                    check = false;
                }


                else if (a.Length > 1 && simbol1 == '-')
                {
                    for (int j = 1; j < 2; j++)
                    {
                        char simbol2 = a[j];

                        if (simbol2 == '0' || (simbol2 != '1' && simbol2 != '2' && simbol2 != '3' && simbol2 != '4' && simbol2 != '5' && simbol2 != '6' && simbol2 != '7' && simbol2 != '8' && simbol2 != '9'))

                        {
                            check = false;
                        }
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
