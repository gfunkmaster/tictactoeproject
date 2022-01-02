﻿using System;

namespace TicTacToe
{
    class MainClass
    {
        //the playfiled
        static char[,] playField =
        {
            {'1','2','3' }, //row 0
            {'4','5','6' }, // row 1
            {'7','8','9' }, // row 2
        };


        public static void Main(string[] args)
        {
            int player = 2; //Player 1 starts
            int input = 0;
            bool inputCorrect = true;

            //calling the method
           

            //run code as long as the program runs 
            do
            {
                
                if (player == 2)
                {
                    player = 1;
                    //calling the method with switch cases
                    EnterXorO(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }
                SetField();
                #region
                //check winning condition
                char[] playerChars = { 'X', 'O' };
                foreach (var playerChar in playerChars)
                {
                    if((playField[0,0] == playerChar) && (playField[0, 1] == playerChar) && (playField[0, 2] == playerChar))
                    {
                        Console.WriteLine("we have a winner");
                    }
                }
                #endregion

                #region
                //test if field is aleady taken

                //another do while 
                do
                {
                    //implementing a try a catch
                    Console.WriteLine("\nPlayer {0}: Choose your field! ", player);
                    try
                    {
                        //converting to a int 
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch 
                    {
                        Console.WriteLine("Please enter a number!");
                    }

                    if ((input == 1) && (playField[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (playField[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (playField[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (playField[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (playField[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (playField[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (playField[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (playField[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (playField[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("\n Incorrct input! Please use another field! ");
                        inputCorrect = false;
                    };


                } while (!inputCorrect);
                #endregion
            } while (true);
        }

        //creating a visual playfield
        public static void SetField()
        {
            //Adding to clear console so we can after each input that we can have a visual
            // x or o
            Console.Clear();
            Console.WriteLine("     |     |     ");
            //Todoo replace numbers with variables
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("_____|_____|____");
            Console.WriteLine("     |     |    ");
            //Todoo replace numbers with variables
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_____|_____|____");
            Console.WriteLine("     |     |    ");
            //Todoo replace numbers with variables
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("     |     |     ");
        }
        //creating a method for witch player it is, to improve 
        public static void EnterXorO(int player, int input)
        {
            char playerSign = ' ';

            // if else for wich player sign
            if (player == 1)
                playerSign = 'X';
            else if (player == 2)
                playerSign = 'O';

            switch (input)
            {
                case 1: playField[0, 0] = playerSign; break;
                case 2: playField[0, 1] = playerSign; break;
                case 3: playField[0, 2] = playerSign; break;
                case 4: playField[1, 0] = playerSign; break;
                case 5: playField[1, 1] = playerSign; break;
                case 6: playField[1, 2] = playerSign; break;
                case 7: playField[2, 0] = playerSign; break;
                case 8: playField[2, 1] = playerSign; break;
                case 9: playField[2, 2] = playerSign; break;
            }

        }
    }
}
