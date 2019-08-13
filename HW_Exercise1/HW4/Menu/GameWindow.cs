using HW4.GUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW4.Menu
{
    class GameWindow:Window
    {
        private Button _startButton;
        private Button _playerButton;
        private TextBlock _titleTextBlock;
        private Button _diceArray;
        public List<Button> PlayerArray = new List<Button>();
        public List<Button> DaceArray = new List<Button>();
        private int _playerIndex =0;
        private int _diceIndex = 0;
        public int PlayerIndex { get; set; } = 0;
        public int DiceIndex { get; set; } = 0;

        public GameWindow(int PlayerIndex, int DiceIndex) : base(0, 0, 120, 30, '*')
        {
            _titleTextBlock = new TextBlock(20, 1, 100, new List<String> { "GAME DICE" });

            _startButton = new Button(90, 21, 18, 5, "S - Start");
            _playerIndex = PlayerIndex;
            _diceIndex = DiceIndex;

            int y = 1;
           
            for(int i = 0; i < _playerIndex+2; i++)
            {
                _playerButton = new Button(3, y, 15, 4, "PLAYER" + (i+1));
                int x = 0;
                for (int j=0; j< _diceIndex; j++)
                {
                    _diceArray = new Button(19+x,  y, 6, 4, "  ");
                    x += 8;
                    DaceArray.Add(_diceArray);
                }
                
                y += 4;
                PlayerArray.Add(_playerButton);
                
            }
            

        }

        public override void Render()
        {
            base.Render();

            _titleTextBlock.Render();

            _startButton.Render();
            _playerIndex = PlayerIndex;

            for (int i = 0; i < PlayerArray.Count; i++)
            {
                PlayerArray[i].Render();
            }
            for (int j = 0; j < DaceArray.Count; j++)
            {
                DaceArray[j].Render();
            }

            Console.SetCursorPosition(0, 0);
        }



    }
}

