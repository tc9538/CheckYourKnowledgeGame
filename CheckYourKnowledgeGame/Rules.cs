using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckYourKnowledgeGame
{
    class Rules
    {
        //Data
        string[] playerNames = new string[5];
        int countPlayerNames = 0;


        //Get the player's name one at time. Then, sort all of them randomly. Print out the array of player order
        public void playerOrder()
        {
            Console.WriteLine("Enter all players'names (Up to 5 players). Type in quit when done with entering the names.");
            string input = Console.ReadLine();
            while (input != "quit" && countPlayerNames < playerNames.Length)
            {

                playerNames[countPlayerNames] = input;
                countPlayerNames = countPlayerNames + 1;
                input = Console.ReadLine();
            }

            Console.WriteLine("****************************");
            sortPlayers();

        }

        //Sort players' names and print them out
        public void sortPlayers()
        {

            Random rnd = new Random();
            int randomIndex;
            string temp;
            for (int i = 0; i < playerNames.Length - 1; i++)
            {
                randomIndex = rnd.Next(i, playerNames.Length);
                if (randomIndex != i)
                {
                    temp = playerNames[i];
                    playerNames[i] = playerNames[randomIndex];
                    playerNames[randomIndex] = temp;
                }

            }

            Console.WriteLine("This is the order of players to play this game");
            for (int j = 0; j < playerNames.Length; j++)
            {
                Console.WriteLine((j + 1) + ". " + playerNames[j]);
            }

        }

        //Start the game
        public void play(int i)
        {

            giveOutQuestions(i);

            //Prints out msg to show whether the player answers the question correctly or not?

            //Who has fifty points first will be the winner. Msg will be printed out

            //Random golden tickets selling will be handed out. 

            //1. skip questions
            //2. enter other player's name and let them answer it. 


        }

        public void giveOutQuestions(int index)
        {
            //questions array
            string[] questions = { "Name one of the 7 wonders of the world",
                                   "How many planets in the solar system?",
                                   "How many countries in the world?",
                                   "What is the biggest planet in the solar system?",
                                   "How many oceans are there?"};

            //Random rnd = new Random();
            //int randomNumber = rnd.Next(0, 2);

            //Ask the player to pick a number in the listed range of number
            Console.WriteLine(playerNames[index] + "!" + "Choose any number from 0 to 3");

            //Read the input from the player
            int chosenNum = Convert.ToInt32(Console.ReadLine());

            //Print out the question for the player
            Console.WriteLine("Question for you is  " + questions[chosenNum]);
            Console.WriteLine("Now enter your answer");
            checkAnswerIsCorrect(Console.ReadLine(), chosenNum);
            //Wipe out the given out question by blank after the player is done with the question
            questions[chosenNum] = "N/A";

        }
        public void checkAnswerIsCorrect(string ans, int questionLocation)
        {
            //answers array
            string[] answers = {"the Great Pyramid of Giza",
                                "8",
                                "146",
                                "Jupiter",
                                "4" };
            Boolean value = true;
            value = ans.Equals(answers[questionLocation]);
            if (value == true)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }


        }
    }
}
