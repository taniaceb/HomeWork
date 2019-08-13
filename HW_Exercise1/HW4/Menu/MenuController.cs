using HW4.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW4.Menu
{
    class MenuController
    {
        private MainMenu _mainMenu = new MainMenu();
        private PlayerSelectionMenu _playerSelectionMenu = new PlayerSelectionMenu();
        private DiceSelectionMenu _diceSelectionMenu = new DiceSelectionMenu();
        private GameWindow _gameWindow = new GameWindow(0, 0);
        private TextBlock _sumTextBlock;


        public int IndexPlayer { get; set; } = 0;
        public int DiceIndex { get; set; } = 0;

        Random rand = new Random();

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

        public void ShowGameWidow()
        {
            _gameWindow = new GameWindow(IndexPlayer, DiceIndex);
        }



        public void StartGame()
        {
            List<int> PlayerSum = new List<int>();
            List<int> PlayerBalance = new List<int>();
            int sum = 0;
            _sumTextBlock = new TextBlock(20, 5, 100, new List<String> { " " });
            ConsoleKeyInfo pressedChar = Console.ReadKey();
            while (pressedChar.Key != ConsoleKey.End)
            {
                switch (pressedChar.Key)
                {

                    case ConsoleKey.S:

                        for (int i = 0; i < _gameWindow.DaceArray.Count(); i++)
                        {
                            sum = rand.Next(1, 7);
                            _gameWindow.DaceArray[i].Label = " " + sum;
                            PlayerSum.Add(sum);

                        }

                        int z = 0;
                        int s = 0;
                        int sum1 = 0;


                        for (int j = 0; j < _gameWindow.PlayerArray.Count(); j++)
                        {
                            for (int k = s; k < z + PlayerSum.Count() / _gameWindow.PlayerArray.Count(); k++)
                            {
                                sum1 += PlayerSum[k];
                            }

                            PlayerBalance.Add(sum1);
                            sum1 = 0;
                            s += PlayerSum.Count() / _gameWindow.PlayerArray.Count();
                            z = PlayerSum.Count() / _gameWindow.PlayerArray.Count();
                        }

                        _gameWindow.Render();


                        int y = 2;
                        for (int i =0;i<PlayerBalance.Count;i++)
                       
                        {
                           int a = PlayerBalance[i];


                            _sumTextBlock = new TextBlock(60+i, y+10, 10, new List<String> { "Suma " + a});
                        }

                       
                      //  _sumTextBlock.Render();
                        break;

                    case ConsoleKey.Add:

                        break;
                    case ConsoleKey.Subtract:

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
                        ShowGameWidow();
                        _gameWindow.Render();
                        StartGame();

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
