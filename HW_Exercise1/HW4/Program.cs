using HW4.Menu;
using System;
using System.Collections.Generic;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
           // MainMenu z = new MainMenu();
            //z.Render();

            //GUI.Button[,] PlayerMenu = new GUI.Button[2, 3];

            MenuController menuCont = new MenuController();
            menuCont.ShowMenu();
            menuCont.ChooseMeniuButton();



          /*  int x = 20;
            int y = 8;
            int index = 2;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    PlayerMenu[i, j] = new GUI.Button(0 + x, 0 + y, 20, 8, "P" + index);
                    x += 20;
                    index++;
                }
                y += 8;
                x = 20;
            }*/

             /*List<GUI.Button> buttonMenu = new List<GUI.Button>();
            int x = 20;
            int y = 8;
            int index = 2;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    GUI.Button k = new GUI.Button(0 + x, 0 + y, 20, 8, "P" + index);
                    x += 20;
                    index++;
                        buttonMenu.Add(k);
                }
                y += 8;
                x = 20;
            }*/



        }
    }
}
