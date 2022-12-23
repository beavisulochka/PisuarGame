using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pisuar_game
{
	public class LevelOne
	{
        public LevelOne()
        {
            ShowLevel();
            Check();
        }

        int number;
        LevelTwo lvlTwoForLvlOne = new LevelTwo();
        

        public void ShowLevel()
		{
			Console.WriteLine("Level 1");
            Console.WriteLine();

            Console.WriteLine(" ###  ###  ###  ###  ##### ");
            Console.WriteLine(" # #  # #  # #  # #  # # # ");
            Console.WriteLine(" ###  ###  ###  ###  # # # ");
            Console.WriteLine(" #    #    #    #    #   # ");
            Console.WriteLine(" #    #    #    #    #   # ");
            Console.WriteLine();

            Console.WriteLine("Write number of best pisuar place");
			number = int.Parse(Console.ReadLine());
        }

        public void Check()
        {
            if (number == 1 || number == 2 || number == 3)
            {
                lvlTwoForLvlOne.Play();
            }

            else
            {
                Console.WriteLine("Try again, you have two more tries.");
                ShowLevel();

                if (number == 1 || number == 2 || number == 3)
                {
                    
                    lvlTwoForLvlOne.Play();
                }

                else
                {
                    Console.WriteLine("Try again, you have one more try.");
                    ShowLevel();

                    if (number == 1 || number == 2 || number == 3)
                    {
                        lvlTwoForLvlOne.Play();
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