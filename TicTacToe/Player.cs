using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Player
    {
        //constructor
        public Player(string name, char mark, bool isWinner)
        {
            this.Name = name;
            this.Mark = mark;
            this.IsWinner = isWinner;
        }

        public string Name { get; set; }
        public char Mark { get; set; }
        public bool IsWinner { get; set; }
    }





}
