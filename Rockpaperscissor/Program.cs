internal class Program
{
    private static void Main(string[] args)
    {

        //Player vs Computer
        String playerChoice;
        String computerChoice;
        Random random = new Random();
        int playerScore;
        int computerScore;
        int draw;
        int rounds;

        bool playAgain = true;
        String answer;


        while (playAgain) {
            answer = "";
            rounds = 0;
            playerScore = 0;
            computerScore = 0;
            draw = 0;

            while (rounds <= 9) { 
            playerChoice = "";
            computerChoice = "";

            while (playerChoice != "ROCK" && playerChoice != "PAPER" && playerChoice != "SCISSORS")
                {

                    Console.Write("Enter Rock , Paper or Scissors: ");
                    playerChoice = Console.ReadLine();
                    playerChoice = playerChoice.ToUpper();
                }

            switch(random.Next(1, 4))
            {
                case 1:
                    computerChoice = "ROCK";
                    break;
                case 2:
                    computerChoice = "PAPER";
                    break;
                case 3:
                    computerChoice = "SCISSORS";
                    break;
            }
            Console.WriteLine("Player chose: " + playerChoice);
            Console.WriteLine("computer chose: " + computerChoice);

            switch (playerChoice)
                {
                    case "ROCK":
                        if (computerChoice == "ROCK")
                        {
                            Console.WriteLine("It is a draw");
                            draw++;
                            rounds++;
                        }
                        else if (computerChoice == "Paper")
                        {
                            Console.WriteLine("You lose");
                            computerScore++;
                            rounds++;
                        }
                        else
                        {
                            Console.WriteLine("You win");
                            playerScore++;
                            rounds++;
                        }
                        break;
                    case "SCISSORS":
                        if (computerChoice == "SCISSORS")
                        {
                            Console.WriteLine("It is a draw");
                            draw++;
                            rounds++;
                        }
                        else if (computerChoice == "ROCK")
                        {
                            Console.WriteLine("You lose");
                            computerScore++;
                            rounds++;
                        }
                        else
                        {
                            Console.WriteLine("You win");
                            playerScore++;
                            rounds++;
                        }
                        break;
                    case "PAPER":
                        if (computerChoice == "PAPER")
                        {
                            Console.WriteLine("It is a draw");
                            draw++;
                            rounds++;
                        }
                        else if (computerChoice == "SCISSORS")
                        {
                            Console.WriteLine("You lose");
                            computerScore++;
                            rounds++;
                        }
                        else
                        {
                            Console.WriteLine("You win");
                            playerScore++;
                            rounds++;
                        }
                        break;
                }
                Console.WriteLine("PlayerScore : " + playerScore);
                Console.WriteLine("ComputerScore: " + computerScore);
                Console.WriteLine("Draw : " + draw);
                Console.WriteLine("ROUND: " + rounds);

            }
            Console.WriteLine("Do you want to play again? Press Y or N ");
            answer = Console.ReadLine();
            answer = answer.ToUpper();

            if (answer == "Y")
            {
                playAgain = true;

            }
            else
            {
                playAgain= false;
            }

        }
        
    }








    }
