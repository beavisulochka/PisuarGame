using System;
namespace Pisuar_game
{
	public class LevelThree
	{
		public LevelThree()
        { 
		}

        int number;
        LevelFour lvlFourForLvlThree = new LevelFour();

        public void Play()
        {
            ShowLevel();
            Check();
        }

        public void ShowLevel()
        {
            Console.WriteLine("Level 3");
            Console.WriteLine();

            Console.WriteLine(" #####  ###  #####  ###  ### ");
            Console.WriteLine(" # # #  # #  # # #  # #  # # ");
            Console.WriteLine(" # # #  ###  # # #  ###  ### ");
            Console.WriteLine(" #   #  #    # # #  #    #   ");
            Console.WriteLine(" #   #  #    #   #  #    #   ");
            Console.WriteLine();

            Console.WriteLine("Write number of best pisuar place");
            number = int.Parse(Console.ReadLine());
        }

        public void Check()
        {
            if (number == 5)
            {
                lvlFourForLvlThree.Play();
            }

            else
            {
                Console.WriteLine("Try again, you have two more tries.");
                ShowLevel();

                if (number == 5)
                {
                    lvlFourForLvlThree.Play();
                }

                else
                {
                    Console.WriteLine("Try again, you have one more try.");
                    ShowLevel();

                    if (number == 5)
                    {
                        lvlFourForLvlThree.Play();
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

