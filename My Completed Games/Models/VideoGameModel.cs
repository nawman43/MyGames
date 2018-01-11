using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MyCompletedGames.Models
{
    public class VideoGameModel
    {
        public int GameId { get; set; }
        public string Title { get; set; }
        public string Comments { get; set; }
        public bool Backlog { get; set; }
        public bool Playing { get; set; }
        public bool Played { get; set; }
        public DateTime DateAdded { get; set; }
        public string ImageUrl { get; set; }
        
    }
}
