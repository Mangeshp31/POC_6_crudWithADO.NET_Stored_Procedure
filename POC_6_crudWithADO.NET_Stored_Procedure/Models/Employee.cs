using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POC_6_crudWithADO.NET_Stored_Procedure.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]

        public string LastName { get; set; }
        [Required]
        [DisplayName("Date Of Birth")]

        public DateTime DateOfBirth { get; set; }
        [Required]
        [DisplayName("E-Mail")] 

        public string Email { get; set; }
        [Required]
        public double Salary { get; set; }

        //instead of desplaying first name and last name we wanna display full name
        [NotMapped]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}
