using System;
using System.Collections.Generic;
using System.Text;

namespace HW4.Menu
{
    class MenuController
    {
        private MainMenu _mainMenu;
        private PlayerSelectionMenu _playerSelectionMenu = new PlayerSelectionMenu();

        public MenuController()
        {
           
        }

        public void ShowMenu()
        {
            _playerSelectionMenu.Render();


        }

        public void ChooseMeniuButton()
        {

            bool creditW = false;

            ConsoleKeyInfo pressedChar = Console.ReadKey();
            while (pressedChar.Key != ConsoleKey.End)
            {
                switch (pressedChar.Key)
                {
                    case ConsoleKey.Escape:

                        // Console.SetCursorPosition(0, 0);
                        Console.Clear();
                        ShowMenu();
                        break;

                   /* case ConsoleKey.Enter:

                        if (creditW)
                        {
                            creditW = false;
                            ShowMenu();

                        }

                        else
                        {

                            if (gameWindow.CheckActiveButton() == 0)
                            {
                                Console.Clear();
                                myGame.StartGame();
                            }
                            else if (gameWindow.CheckActiveButton() == 1)
                            {
                                Console.Clear();
                                creditWindow.Render();
                                creditW = true;
                            }
                            else if (gameWindow.CheckActiveButton() == 2)
                            {
                                Console.Clear();

                            }

                        }
                        break;*/


                    case ConsoleKey.RightArrow:

                        _playerSelectionMenu.DirectionLeftRight = true;
                        _playerSelectionMenu.Direction = true;
                        _playerSelectionMenu.MoveMeniuItem();

                        break;
                    case ConsoleKey.LeftArrow:
                        _playerSelectionMenu.DirectionLeftRight = false;
                        _playerSelectionMenu.Direction = true;
                        _playerSelectionMenu.MoveMeniuItem();

                        break;
                    case ConsoleKey.DownArrow:
                        _playerSelectionMenu.DirectionUpDown = true;
                        _playerSelectionMenu.Direction = false;
                        _playerSelectionMenu.MoveMeniuItem();

                        break;

                    case ConsoleKey.UpArrow:
                        _playerSelectionMenu.DirectionUpDown = false;
                        _playerSelectionMenu.Direction = false;
                        _playerSelectionMenu.MoveMeniuItem();

                        break;
                }
                pressedChar = Console.ReadKey();

            }
        }


    }
}
