namespace cse210_03 
{
    public class Director
    {
        private Jumper jumper = new Jumper();
        private Word word = new Word();
        private Terminal terminal = new Terminal();
        private bool isPlaying = true;
        private string hiddenWord = "";

        public Director()
        {
            hiddenWord = word.GetWord();
        }

        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        private void GetInputs()
        {
            string letter = terminal.ReadText("\nGuess a letter [a-z]: ");
            
        }

        private void DoUpdates()
        {

        }

        private void DoOutputs()
        {

        }
    }
}