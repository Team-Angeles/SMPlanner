using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Sacrament_Meeting_Planner.Models
{
    public class Meeting
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfMeeting { get; set; }

        [Required]
        public string Leader { get; set; }

        [Required]
        public string OpeningHymn { get; set; }

        [Required]
        public string SacramentHymn { get; set; }

        [Required]
        public string ClosingHymn { get; set; }

        public string IntermediateNumber { get; set; } = null;

        [Required]
        public string OpeningPrayer { get; set; }

        [Required]
        public string ClosingPrayer { get; set; }

        public ICollection<Speaker> MeetingSpeakers { get; set; } = new List<Speaker>();
    }
}
