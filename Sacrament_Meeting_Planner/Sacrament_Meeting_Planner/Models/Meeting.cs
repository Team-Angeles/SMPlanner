using System.ComponentModel.DataAnnotations;

namespace Sacrament_Meeting_Planner.Models
{
    public class Meeting
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Meeting Date")]
        [CustomValidation(typeof(Meeting), nameof(MeetingDateValidation))]
        public required DateTime DateOfMeeting { get; set; }

        [Required]
        [Display(Name = "Conducting Leader")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Conducting leader's name must be between 2 and 50 characters.")]
        public required string Leader { get; set; }

        [Required]
        [Display(Name = "Opening Hymn")]
        [RegularExpression(@"^[A-Za-z0-9\s]+$", ErrorMessage = "Invalid hymn name.")]
        public required string OpeningHymn { get; set; }

        [Required]
        [Display(Name = "Sacrament Hymn")]
        [RegularExpression(@"^[A-Za-z0-9\s]+$", ErrorMessage = "Invalid hymn name.")]
        public required string SacramentHymn { get; set; }

        [Required]
        [Display(Name = "Closing Hymn")]
        [RegularExpression(@"^[A-Za-z0-9\s]+$", ErrorMessage = "Invalid hymn name.")]
        public required string ClosingHymn { get; set; }

        [Display(Name = "Intermediate Hymn")]
        [RegularExpression(@"^[A-Za-z0-9\s]+$", ErrorMessage = "Invalid hymn name.")]
        public string? IntermediateNumber { get; set; } = null;

        [Required]
        [Display(Name = "Opening Prayer")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Prayer name must be between 2 and 50 characters.")]
        public required string OpeningPrayer { get; set; }

        [Required]
        [Display(Name = "Closing Prayer")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Prayer name must be between 2 and 50 characters.")]
        public required string ClosingPrayer { get; set; }

        public ICollection<Speaker> MeetingSpeakers { get; set; } = new List<Speaker>();

        public static ValidationResult MeetingDateValidation(DateTime meetingDate, ValidationContext validationContext)
        {
            if (meetingDate.Date < DateTime.Now.Date)
            {
                return new ValidationResult("Meeting date cannot be in the past.");
            }
            return ValidationResult.Success!;
        }
    }
}
