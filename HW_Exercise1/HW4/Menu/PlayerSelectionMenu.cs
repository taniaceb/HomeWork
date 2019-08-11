using HW4.GUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW4.Menu
{
    class PlayerSelectionMenu : Window
    {
        private Button _playerButton;
        private TextBlock _titleTextBlock;
        public List<Button> PlayerMenu = new List<Button>();
        public bool DirectionLeftRight = true;
        public bool DirectionUpDown = true;
        public int ButtonIndex { get; set; } = 0;

        public PlayerSelectionMenu() : base(0, 0, 120, 30, '%')
        {
            _titleTextBlock = new TextBlock(5, 5, 100, new List<String> {"Players selection Menu"," ", "Choose How Many Players Play" });

            int x = 20;
            int y = 8;
            int index = 2;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _playerButton = new Button(0 + x, 0 + y, 20, 8, "P" + index);
                    PlayerMenu.Add(_playerButton);

                    x += 20;
                    index++;

                }
                y += 8;
                x = 20;

            }
            PlayerMenu[0].SetActive();


        }

        public override void Render()
        {
            // base.Render();

            _titleTextBlock.Render();

            for (int i = 0; i < PlayerMenu.Count; i++)
            {
                PlayerMenu[i].Render();
            }

            Console.SetCursorPosition(0, 0);
        }

        public int CheckActiveButton()
        {
            
            foreach (Button value in PlayerMenu)
            {
                if (value.IsActive == true)
                {
                    ButtonIndex = PlayerMenu.IndexOf(value);

                }
            }
            return ButtonIndex;
        }

        public void MoveMeniuItemLeftRight()
        {

            int index = CheckActiveButton();

            
            if (DirectionLeftRight)
            {
                for (int i = 0; i < PlayerMenu.Count; i++)
                {
                    PlayerMenu[i].SetNotActive();

                }
                if (index == PlayerMenu.Count - 1)
                {
                    index = -1;
                }
                PlayerMenu[index + 1].SetActive();

            }
            else
            {
                for (int i = 0; i < PlayerMenu.Count; i++)
                {
                    PlayerMenu[i].SetNotActive();


                }
                if (index == 0)
                {
                    index = 6;
                }
                PlayerMenu[index - 1].SetActive();
            }
                       
            Render();

        }
        public void MoveMeniuItemUpDown()
        {

            int index = CheckActiveButton();

             if (DirectionUpDown)
                {
                    for (int i = 0; i < PlayerMenu.Count; i++)
                    {
                        PlayerMenu[i].SetNotActive();

                    }
                    if (index == 3 || index == 4 || index == 5)
                    {
                        index -= 3;
                    }
                    PlayerMenu[index + 3].SetActive();
                }
                else
                {
                    for (int i = 0; i < PlayerMenu.Count; i++)
                    {
                        PlayerMenu[i].SetNotActive();

                    }
                    if (index == 0 || index == 1 || index == 2)
                    {
                        index += 3;
                    }
                    PlayerMenu[index - 3].SetActive();
                }
                         
            Render();

        }
    }
}
