using System.ComponentModel.DataAnnotations;

namespace datepicker.Models
{
    public class Appointment
    {


        public int Id { get; set; }



        [Required]
        [Display(Name = "Select Date")]
        [DataType(DataType.Date)]
        public DateTime AppointmentTime { get; set; }

    }
}
