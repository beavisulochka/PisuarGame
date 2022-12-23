using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pisuar_game
{
    public class LevelTwo
    { 
        public LevelTwo()
		{         
        }
        
        int number;
        LevelThree lvlThreeForLvlTwo = new LevelThree();

        public void Play()
        {
            ShowLevel();
            Check();
        }

        public void ShowLevel()
        {
            Console.WriteLine("Level 2");
            Console.WriteLine();

            Console.WriteLine(" #####  ###  ###  ###  ##### ");
            Console.WriteLine(" # # #  # #  # #  # #  # # # ");
            Console.WriteLine(" # # #  ###  ###  ###  # # # ");
            Console.WriteLine(" #   #  #    #    #    #   # ");
            Console.WriteLine(" #   #  #    #    #    #   # ");
            Console.WriteLine();

            Console.WriteLine("Write number of best pisuar place");
            number = int.Parse(Console.ReadLine());
        }

        public void Check()
        {
            if (number == 3)
            {
                lvlThreeForLvlTwo.Play();
            }

            else
            {
                Console.WriteLine("Try again, you have two more tries.");
                ShowLevel();

                if (number == 3)
                {
                    lvlThreeForLvlTwo.Play();
                }

                else
                {
                    Console.WriteLine("Try again, you have one more try.");
                    ShowLevel();

                    if (number == 3)
                    {
                        lvlThreeForLvlTwo.Play();
                    }

                    else
                    {
                        Console.WriteLine("You lost");
                    }
                }
            }
        }
    }
}

