using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicTacToeSignalR.Models
{
    public class Player
    {
        public string Id { get; set; }
        public int Count { get; set; }
        public List<string> ruls { get; set; } 
    }
}