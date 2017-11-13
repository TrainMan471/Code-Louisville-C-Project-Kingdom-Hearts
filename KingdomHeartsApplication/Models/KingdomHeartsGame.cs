using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KingdomHeartsApplication.Models
{
    public class KingdomHeartsGame
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string PlayableCharacter { get; set; }
        public int ReleaseDate { get; set; }
        public string[] GameDevelopers { get; set; }
        public string[] Worlds { get; set; }
        public virtual ICollection<KingdomHeartsReview> Review { get; set; }
    }
}