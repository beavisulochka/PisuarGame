using System;
namespace Pisuar_game
{
	public class Player
	{
		public string Name { get; }

		public Player(string name)
		{
			Name = name;
		}

		public void Greating()
		{
            Console.WriteLine($"Hi {Name}, read some rules before you start playing");
            RulesPrint();
		}

        public void RulesPrint()
        {
            Console.WriteLine("Welcome to Right pisuar game, at this game you must choose right place for pee");
            Console.WriteLine("You have two symbols in game, big P and big M, you can see they  near this text");

            Console.WriteLine(" ### ##### ");
            Console.WriteLine(" # # # # # ");
            Console.WriteLine(" ### # # # ");
            Console.WriteLine(" #   # # # ");
            Console.WriteLine(" #   #   # ");

            Console.WriteLine("Big P mean pisuar, big M mean man");

            Console.WriteLine("Your point, its choose best place for toilet work, and if answer right, you go to the next lvl");
            Console.WriteLine("And, you three tries in every lvl.");
            Console.WriteLine("In end of your tries or in end of the game you  will see your score");
        }


    }
}

