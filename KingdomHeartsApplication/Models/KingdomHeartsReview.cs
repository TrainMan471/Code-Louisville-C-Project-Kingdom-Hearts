using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KingdomHeartsApplication.Models
{
    //Declaring a Kingdom Hearts Review Model where the user can enter a username, favorite Kingdom Hearts Game, level of Difficulty and user rated score
    //of chose Kingdom Hearts Game
    public class KingdomHeartsReview
    {
        [Key]
        public string Username { get; set; }
        [Display(Name = "Difficulty")]
        public string HighestDifficulty { get; set; }
        [Display(Name = "User's Favorite Game")]
        public string FavoriteGame { get; set; }
        [Display( Name = "Uer's Rated Score of Game")]
        public int Rating { get; set; }

        //Declared this navigation property because There can be many reviews, and there are many Kingdom Hearts Games.
        public virtual ICollection<KingdomHeartsGame> Game { get; set; }
    }
}