using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Sacrament_Meeting_Planner.Models
{
    public class Meeting
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Meeting Date")]
        public DateTime DateOfMeeting { get; set; }

        [Required]
        [Display(Name = "Conducting Leader")]
        public string Leader { get; set; }

        [Required]
        [Display(Name = "Opening Hymn")]
        public string OpeningHymn { get; set; }

        [Required]
        [Display(Name = "Sacrament Hymn")]
        public string SacramentHymn { get; set; }

        [Required]
        [Display(Name = "Closing Hymn")]
        public string ClosingHymn { get; set; }
        [Display(Name = "Intermediate Hymn")]
        public string IntermediateNumber { get; set; } = null;

        [Required]
        [Display(Name = "Opening Prayer")]
        public string OpeningPrayer { get; set; }

        [Required]
        [Display(Name = "Closing Prayer")]
        public string ClosingPrayer { get; set; }

        public ICollection<Speaker> MeetingSpeakers { get; set; } = new List<Speaker>();
    }
}
