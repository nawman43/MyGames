using MyCompletedGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace My_Completed_Games.DAL
{
    public interface IGamesDAL
    {
        List<VideoGameModel> AllGames();
    }
}
