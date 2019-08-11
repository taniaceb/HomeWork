using HW4.GUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW4.Menu
{
    class DiceSelectionMenu:Window
    {
        private Button _diceButton;
        private TextBlock _titleTextBlock;
        public int DiceNumber { get; set; } = 3;
     

        public DiceSelectionMenu() : base(0, 0, 120, 30, '*')
        {
            _titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "Dice Selection Menu", "   ", "Players will have 3 dice","If You Want To Change Number Of Dices Press '+' Or '-'" , "MAX - 6, MIN - 1"});
               
            _diceButton = new Button(40, 13, 18, 5, "Dice: 3");
           

        }

        public override void Render()
        {
            base.Render();

            _titleTextBlock.Render();
            _diceButton.Label = "Dice: "+ DiceNumber;
            _diceButton.Render();

            Console.SetCursorPosition(0, 0);
        }

                

}
}
