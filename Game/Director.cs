using System;
using System.Collections.Generic;

namespace cse210_03
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {

        private bool isPlaying = true;
        private string wordToGuess;

        private Terminal terminal = new Terminal();
        public Word word = new Word();
        private Jumper jumper = new Jumper();
        public int tries = 0;
        public int numberOfGuesses = 0;

        private bool checkInput;
        List<char> guessedLetters = new List<char>();
        public string currentGuess = "test";


        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            wordToGuess = word.GetWord();
            word.listWord(wordToGuess);
            word.createHiddenWord();
            word.printGuess();

            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        private void GetInputs()
        {
            Console.WriteLine("\n");
            jumper.printJumper(tries);
            checkInput = true;

            while (checkInput){
                currentGuess = terminal.ReadText("\nGuess a letter [a-z]: ");
                checkInput = jumper.checkInput(guessedLetters, currentGuess);
            }

            guessedLetters.Add(currentGuess[0]);
            

        }


        private void DoUpdates()
        {
            numberOfGuesses = guessedLetters.Count;
            int usedTries = word.compare(guessedLetters, numberOfGuesses);
            tries = tries + usedTries;
            isPlaying = jumper.checkJumper(word.guess, tries);
        }


        private void DoOutputs()
        {
            Console.WriteLine("");

            if (isPlaying){
                word.printGuess();
            }
            else {
                jumper.printJumper(tries);
                word.printAnswer();
                Console.WriteLine("\n");
            }
  
        }
    }
}