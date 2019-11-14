﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {

        public Color CurrentTurn { get; set; }

        public Checker[,] Board = new Checker[8, 8];
        public bool GameOn { get; set; }

        public Game()
        {
            GameOn = true;

            for (int i = 0; i < 8; i += 2)
            {
                //black rows
                Board[i, 0] = new Checker(Color.Black, i, 0);
                Board[i + 1, 1] = new Checker(Color.Black, i+1, 1);
                Board[i, 2] = new Checker(Color.Black,i,2);

                //red rows
                Board[i + 1, 5] = new Checker(Color.Red, i+1, 5);
                Board[i, 6] = new Checker(Color.Red, i, 6);
                Board[i + 1, 7] = new Checker(Color.Red, i+1, 7);


            }
        }

        public string Serialize()
        {
            string state = GameOn.ToString() + "\n";
            state += CurrentTurn.ToString() + "\n";
            for(int y=0; y<8; y++)
            {
                for(int x=0; x < 8; x++)
                {
                    if (Board[x, y] != null)
                    {
                        Checker checker = Board[x, y];
                        state += $"{checker.Color}|{checker.King}|{checker.Coords.x}|{checker.Coords.y}\n";

                    }
                }
            }

            return state;
        }

        public static Game Marshall(string state)
        {
            string[] lines = state.Split("\n");
            Game game = new Game();
            game.GameOn = bool.Parse(lines[0]);
            game.CurrentTurn = (Color) Enum.Parse(typeof(Color), lines[1]);
            game.Board = new Checker[8, 8];
            for(int i = 2; i < lines.Length -1; i++)
            {
                string[] parts = lines[i].Split("|");
                bool king = bool.Parse(parts[1]);
                Color color = (Color)Enum.Parse(typeof(Color), parts[0]);
                int x = int.Parse(parts[2]);
                int y = int.Parse(parts[3]);
                game.Board[x, y] = new Checker(color, x, y);
            }


            return game;
        }
    }
}
