﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HW4.Menu
{
    class MenuController
    {
        private MainMenu _mainMenu = new MainMenu();
        private PlayerSelectionMenu _playerSelectionMenu = new PlayerSelectionMenu();
        private DiceSelectionMenu _diceSelectionMenu = new DiceSelectionMenu();
        private GameWindow _gameWindow = new GameWindow(0,0); 

        public int IndexPlayer { get; set; } = 0;
        public int DiceIndex { get; set; } = 0;

        public MenuController()
        {

        }

        public void ShowMenu()
        {
            _mainMenu.Render();
            ChooseMainMeniuButton();
        }


        public void ShowPlayersMenu()
        {
            _playerSelectionMenu.Render();
            ChoosePlayersMeniuButton();

        }

        public void ChooseMainMeniuButton()
        {
            ConsoleKeyInfo pressedChar = Console.ReadKey();
            while (pressedChar.Key != ConsoleKey.End)
            {
                switch (pressedChar.Key)
                {
                    case ConsoleKey.P:

                        // Console.SetCursorPosition(0, 0);
                        Console.Clear();
                        ShowPlayersMenu();
                        break;

                    case ConsoleKey.Q:

                        // Console.SetCursorPosition(0, 0);
                        Console.Clear();
                        break;

                }
                pressedChar = Console.ReadKey();

            }

        }

        public void ChoosePlayersMeniuButton()
        {

            ConsoleKeyInfo pressedChar = Console.ReadKey();
            while (pressedChar.Key != ConsoleKey.End)
            {
                switch (pressedChar.Key)
                {


                    case ConsoleKey.Enter:
                         
                         Console.Clear();
                      
                        _diceSelectionMenu.Render();
                         ChooseNumberOfDice();
                        
                        break;


                    case ConsoleKey.RightArrow:

                        _playerSelectionMenu.DirectionLeftRight = true;
                        _playerSelectionMenu.MoveMeniuItemLeftRight();
                        IndexPlayer = _playerSelectionMenu.CheckActiveButton();

                        break;
                    case ConsoleKey.LeftArrow:
                        _playerSelectionMenu.DirectionLeftRight = false;
                        _playerSelectionMenu.MoveMeniuItemLeftRight();
                        IndexPlayer = _playerSelectionMenu.CheckActiveButton();

                        break;
                    case ConsoleKey.DownArrow:
                        _playerSelectionMenu.DirectionUpDown = true;
                        _playerSelectionMenu.MoveMeniuItemUpDown();
                        IndexPlayer = _playerSelectionMenu.CheckActiveButton();

                        break;

                    case ConsoleKey.UpArrow:
                        _playerSelectionMenu.DirectionUpDown = false;
                        _playerSelectionMenu.MoveMeniuItemUpDown();
                        IndexPlayer = _playerSelectionMenu.CheckActiveButton();

                        break;
                }
                pressedChar = Console.ReadKey();

            }
        }

        public void ChooseNumberOfDice()
        {
           
            ConsoleKeyInfo pressedChar = Console.ReadKey();
            while (pressedChar.Key != ConsoleKey.End)
            {
                switch (pressedChar.Key)
                {

                    case ConsoleKey.Enter:
                       
                        Console.Clear();
                        // _gameWindow.PlayerIndex = IndexPlayer;
                      
                        DiceIndex = _diceSelectionMenu.DiceNumber;
                        _gameWindow = new GameWindow(IndexPlayer, DiceIndex);
                        _gameWindow.Render();

                        break;

                    case ConsoleKey.Add:
                        if (_diceSelectionMenu.DiceNumber == 6)
                        {
                            _diceSelectionMenu.Render();
                        }
                        else
                        {
                            _diceSelectionMenu.DiceNumber++;
                            _diceSelectionMenu.Render();

                        }
                        break;
                    case ConsoleKey.Subtract:
                        if (_diceSelectionMenu.DiceNumber == 1)
                        {
                            _diceSelectionMenu.Render();
                        }
                        else
                        {
                            _diceSelectionMenu.DiceNumber--;
                            _diceSelectionMenu.Render();
                        }
                        break;

                }
                pressedChar = Console.ReadKey();

            }
        }


    }
}
