using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sacrament_Meeting_Planner.Models
{
    public class Speaker
    {
        public int Id { get; set; }

        public int MeetingId { get; set; }

        public Meeting Meeting { get; set; }

        [Required]
        public string Topic { get; set; }
        [Required]
        public int SpeakerPosition { get; set; }
        [Required]
        public string SpeakerName { get; set; }
    }
}
