using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer
{
    public class Team
    {
        public int TeamId { get; set; }
        [Required(ErrorMessage = "TeamName is required")]
        [StringLength(50)]
        public string TeamName { get; set; }
        [Required(ErrorMessage = "TournmentCode is required")]
        [StringLength(10)]
        public string TournmentCode { get; set; }
        [Required(ErrorMessage = "JerseyColor is required")]
        [StringLength(30)]
        public string JerseyColor { get; set; }
        [Required]
        public List<Player> Players { get; set; }
    }
}
