using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppServices.Models.Patient
{
    public class RegisterPatient
    {
       

            [Required]
            [StringLength(50)]
            public string FirstName { get; set; } = string.Empty;

            [Required]
            [StringLength(50)]
            public string LastName { get; set; } = string.Empty;

            [Required]
            [RegularExpression("M|F|O", ErrorMessage = "Gender must be M, F, or O.")]
            public string Gender { get; set; } = "O";

            
            public DateTime? DateOfBirth { get; set; }

        [Phone]
        [StringLength(15)]
        public string? ContactNumber { get; set; } = "000000000";

            [EmailAddress]
            [StringLength(100)]
            public string? Email { get; set; }

            [StringLength(255)]
            public string? Address { get; set; }

            [StringLength(50)]
            public string? City { get; set; }

            [StringLength(50)]
            public string? State { get; set; }

            [StringLength(10)]
            public string? PostalCode { get; set; }

            [StringLength(100)]
            public string? EmergencyContactName { get; set; }

        [Phone]
        [StringLength(15)]
        public string? EmergencyContactNumber { get; set; } = "000000000";

            

            
    }


}


