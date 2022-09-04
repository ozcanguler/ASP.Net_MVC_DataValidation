using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Appointment.Models
{
    public class AppointmentModel
    {
        public AppointmentModel(string patientName, DateTime appointmentDate, decimal patientNetWorth, string doctorLastName, int currentPainLevel)
        {
            this.patientName = patientName;
            this.appointmentDate = appointmentDate;
            this.patientNetWorth = patientNetWorth;
            this.doctorLastName = doctorLastName;
            this.currentPainLevel = currentPainLevel;
        }
        public AppointmentModel()
        {

        }
        [Required]
        [StringLength(20,MinimumLength =2)]
        [DisplayName("Patient's Full Name")]
        public string patientName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Choose the desired date for your next visit")]
        public DateTime appointmentDate { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [DisplayName("How much money do you have?")]
        public decimal patientNetWorth { get; set; }

        [DisplayName("What is the name of doctor you wish to see?")]
        public string doctorLastName { get; set; } = "Tarik Onur Tiryaki" ;
        [Required]
        [Range(0,10)]
        [DisplayName("What is your cuurent pain level (0 to 10)")]
        public int currentPainLevel { get; set; }
    }
}