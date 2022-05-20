using System;

namespace cse210_03
{
    public class Jumper
    {

        public string[] human = { 

                                        " ___ ",
                                        "/___\\",
                                        "\\   /",
                                        " \\ /",
                                        "  0 ",
                                        " /|\\",
                                        " / \\"
        };

        public Jumper()
        {
            
        }

        public void DisplayJumper(string[] human)
        {
            for (int i = 0; i < human.Length; i++)
            {
                Console.WriteLine(human[i]);
            }
        }

        public bool Parachute()
        {

        }
    }
}