using System;
using Intro.Utils;

namespace Intro
{
    class Game
    {
        // field
        private int _num = 0;
        private bool _playing = true;
        // property 
        public int Guesses { get; private set; } = 0;
        ScreenPrinter sp = new ScreenPrinter();

        public void Start()
        {
            var r = new Random();
            _num = r.Next(1, 10);

            sp.print(@"
Lets Play...... a game
                ");
            PlayGame();

        }

        public void PlayGame()
        {
            // lets use explicit typing only here
            while (_playing)
            {
                Console.Clear();
                sp.print($@"
can you guess my number.... between 1 - 10

Guesses: {Guesses}

                ");
                Console.Write("Make a guess: ");
                string userInput = Console.ReadLine();

                if (userInput == "q")
                {
                    _playing = false;
                    sp.print("fine leave quitter");
                    return;
                }

                int userNum = 0;
                //                      vvv passes the variable as a reference
                int.TryParse(userInput, out userNum);
                Guesses++;


                if (userNum == _num)
                {
                    sp.print("WOOOHOO YOU GUESSED IT RIGHT.... curses");
                    _playing = false;
                    sp.PlaySong();
                    return;
                }

                Console.Clear();
                if (userNum > _num)
                {
                    sp.print("YOU ARE HIGH");
                }

                if (userNum < _num)
                {
                    sp.print("YOU ARE LOW");
                }
                Console.ReadKey();
            }
        }
    }
}