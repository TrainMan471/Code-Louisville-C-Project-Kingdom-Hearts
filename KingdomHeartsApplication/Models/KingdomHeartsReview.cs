using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KingdomHeartsApplication.Models
{
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

        public virtual ICollection<KingdomHeartsGame> Game { get; set; }
    }
}