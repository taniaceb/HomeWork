using System;

namespace HW_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite viena skaiciu nuo -999 iki 999");
            string number = Console.ReadLine();

            //Patikrinti, ar buvo ivestas skaicius

            if (number == "")
            {
                Console.WriteLine("Skaicius nebuvo ivestas ");
            }
            else
            {
                if (CheckIsNumber(number))
                {
                    Console.WriteLine("Tai skaicius");
                    
                    if (StringToInt(-999, 999, number))
                    {
                        int numb = Convert.ToInt32(number);
                        Console.WriteLine(numb);
                        Console.WriteLine(StringNumberToText(numb)); 
                    }
                    else
                    {
                        Console.WriteLine("Skaicius nepriklauso intervalui - 999 iki 999");
                    }
                }
                else
                {
                    Console.WriteLine("Tai ne skaicius");
                }
                
                
            }
            //Testas********************
            Console.WriteLine("Testas");
            Console.WriteLine();
            Console.WriteLine(975 + " " + StringNumberToText(975) );
            Console.WriteLine(-174 + " " + StringNumberToText(-174));
            Console.WriteLine(-10 + " " + StringNumberToText(-10));
            //*************************
        }

        static string StringNumberToText(int numb)
        {

            string st = "";
            string st1 = "";
            string min = "";

            if (numb < 0)
            {
                min = "minus ";
            }
            int num = Math.Abs(numb);

           

            if (num >= 0 && num <= 10)
            {

                switch (num)
                {
                    case 0:
                        st = "Nulis";
                        break;
                    case 1:
                        st = "Vienas";
                        break;
                    case 2:
                        st = "Du";
                        break;
                    case 3:
                        st = "Trys";
                        break;
                    case 4:
                        st = "Keturi";
                        break;
                    case 5:
                        st = "Penki";
                        break;
                    case 6:
                        st = "Šeši";
                        break;
                    case 7:
                        st = "Septyni";
                        break;
                    case 8:
                        st = "Aštuoni";
                        break;
                    case 9:
                        st = "Devyni";
                        break;
                    case 10:
                        st = "Dešimt";
                        break;
                }
            }
            else if (num >= 11 && num <= 19)
            {
                switch (num)
                    {
                    case 11:
                        st = "Vienuolika";
                        break;
                    case 12:
                        st = "Dvylika";
                        break;
                    case 13:
                        st = "Trylika";
                        break;
                    case 14:
                        st = "Keturiolika";
                        break;
                    case 15:
                        st = "Penkiolika";
                        break;
                    case 16:
                        st = "Šešiolika";
                        break;
                    case 17:
                        st = "Septyniolika";
                        break;
                    case 18:
                        st = "Aštuniolika";
                        break;
                    case 19:
                        st = "Devyniolika";
                        break;
                }
                
            }

            else if (num >= 20 && num <= 99)
            {
                int num1 = num / 10;
                int num2 = num % 10;
                
                if (num2 == 0)
                    {

                    st1 = "";
                    }
                else
                {
                    st1=  StringNumberToText(num2);
                }

                switch (num1)
                    {
                    case 2:
                        st = "Dvidešimt " +  st1.ToLower();
                        break;
                    case 3:
                        st = "Trisdešimt " + st1.ToLower();
                        break;
                    case 4:
                        st = "Keturiasdešimt " + st1.ToLower();
                        break;
                    case 5:
                        st = "Penkiasdešimt " + st1.ToLower();
                        break;
                    case 6:
                        st = "Šešiasdešimt " + st1.ToLower();
                        break;
                    case 7:
                        st = "Septyniasdešimt " + st1.ToLower();
                        break;
                    case 8:
                        st = "Aštuoniasdešimt " + st1.ToLower();
                        break;
                    case 9:
                        st = "Devyniasdešimt " + st1.ToLower();
                        break;

                }
            }

            else if (num >=100 && num <= 999)
            {
                int num2 = num % 100;
                int num3 = num / 100;
                string gal = " šimtas";
                string gal1 = " šimtai";

                if (num3 ==1 && num2==0)
                {
                    st = StringNumberToText(num3) + gal;
                }
                else if (num3 == 1 && num2 != 0)
                {
                    st1 = StringNumberToText(num2);

                    st = StringNumberToText(num3) + gal + " " + st1.ToLower();

                }
                else
                {
                    st1 = StringNumberToText(num2);
                    st = StringNumberToText(num3) +  gal1 + " " +  st1.ToLower();
                }
            }

            return min+st;
        }

        
    static bool StringToInt(int a, int b, string c)
    {
        bool d = false;
        int num = Convert.ToInt32(c);
        if (num >= a && num <= b)
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
