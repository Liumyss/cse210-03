using System;
using System.Collections.Generic;

namespace cse210_03
{
    public class Jumper
    {
        private List<string> _jumper = new List<string>();
        private int _count;
        private int _trueTries = 0;


        public Jumper()
        {
            _jumper.Add("  ___");
            _jumper.Add(" /___\\");
            _jumper.Add(" \\   /");
            _jumper.Add("  \\ /");
            _jumper.Add("   O");
            _jumper.Add("  /|\\");
            _jumper.Add("  / \\");
        }

        public bool checkInput(List<char> guesses, string currentguess)
        {

            if (guesses.Contains(currentguess[0]))
            {

                Console.WriteLine("You already guessed that letter!");
                return true;
            }
            else
            {

                return false;
            }

        }

        public bool checkJumper(List<char> wordGuess, int tries)
        {

            _count = 0;

            for (int i = 0; i < wordGuess.Count; i++)
            {
                if (wordGuess[i] != '_')
                {
                    _count++;
                }
                else
                {

                }
            }
            if (_count == wordGuess.Count)
            {
                return false;

            }
            else if (tries == 4)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void printJumper(int tries)
        {
            if (tries == _trueTries)
            {

            }
            else if (tries == 4)
            {
                _jumper.RemoveRange(0, 1);
                _jumper[0] = "   X";
            }
            else
            {
                _jumper.RemoveRange(0, 1);
                _trueTries++;
            }
            Console.WriteLine(string.Format("{0}", string.Join("\n", _jumper)));
        }
    }
}