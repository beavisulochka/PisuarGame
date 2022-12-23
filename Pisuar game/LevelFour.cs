using System;
namespace Pisuar_game
{
	public class LevelFour
	{
		public LevelFour()
		{
		}

        int number;
 
        public void Play()
        {
            ShowLevel();
            Check();
        }

        public void ShowLevel()
        {
            Console.WriteLine("Level 3");
            Console.WriteLine();

            Console.WriteLine(" #####  ###  ###  #####  ##### ");
            Console.WriteLine(" # # #  # #  # #  # # #  # # # ");
            Console.WriteLine(" # # #  ###  ###  # # #  # # # ");
            Console.WriteLine(" #   #  #    #    # # #  #   # ");
            Console.WriteLine(" #   #  #    #    #   #  #   # ");
            Console.WriteLine();

            Console.WriteLine("Write number of best pisuar place");
            number = int.Parse(Console.ReadLine());
        }

        public void Check()
        {
            if (number == 2)
            {
                Console.WriteLine("You win");
            }

            else
            {
                Console.WriteLine("Try again, you have two more tries.");
                ShowLevel();

                if (number == 2)
                {
                    Console.WriteLine("You win");
                }

                else
                {
                    Console.WriteLine("Try again, you have one more try.");
                    ShowLevel();

                    if (number == 2)
                    {
                        Console.WriteLine("You win");
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

