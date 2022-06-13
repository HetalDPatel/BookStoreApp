using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService_Inventory.BusinessObject
{
    public class Salesman_BO
    {
        [Required(ErrorMessage = "Salesman Id is required, must be in number.")]
        [MinLength(4, ErrorMessage = "Id should be 4 digit long.")]
        [MaxLength(4, ErrorMessage = "Id should be only 4 digit long..")]
        [RegularExpression(@"^[5][0-9][0-9][0-9]$", ErrorMessage = "Id should be in 4 digit long, should start with 5")]

        public string SalesmanId { get; set; }

        [Required(ErrorMessage = "Salesman Name is required.")]
        [RegularExpression(@"[A-Z a-z]+", ErrorMessage = "Name should be in alphabets.")]
        [MaxLength(30, ErrorMessage = "Entered Name is too long, should be under 30 character long.")]
        public string SalesmanName { get; set; }

        [Required(ErrorMessage = "Commission Feild Required.")]
        [RegularExpression(@"^[+-]?[0-1]*[.]$*[0-9][0-9]$", ErrorMessage = "Should be in decimal point, e.g 0.01 .")]
        public string Commission { get; set; }

        [Required(ErrorMessage = "City Field required.")]
        [RegularExpression(@"[A-Z a-z]+", ErrorMessage = "Invalid city.")]
        [MaxLength(20, ErrorMessage = " City name is too long.")]
        public string City { get; set; }
    }
}
