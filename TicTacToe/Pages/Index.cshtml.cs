using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TicTacToe.Pages
{
    public class IndexModel : PageModel
    {

        public Game Game {get; set;}

        public void OnGet()
        {
            Game = new Game();
        }

        public void onPost(int cx, int cy, int sx, int sy)
        {
            
            Checker checker = Game.Board[cx, cy];
            checker.Coords.x = sx;
            checker.Coords.y = sy;
            Game.Board[sx, sy] = checker;
            Game.Board[cx, cy] = null;
           
        }
    }
}
