using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService_Inventory.BusinessObject
{
    public class Customer_BO
    {
        [Required(ErrorMessage = "Customer Id required.")]
        [MinLength(4, ErrorMessage = "Id should be 4 digit long.")]
        [MaxLength(4, ErrorMessage = "Id should be only 4 digit long..")]
        [RegularExpression(@"^[3][0-9][0-9][0-9]$", ErrorMessage = "Id should be in 4 digit long, should start with 3.")]
        public string custId { get; set; }

        [Required(ErrorMessage = "Customer Name required.")]
        [RegularExpression(@"[A-Z a-z]+", ErrorMessage = "Name should be in alphabets.")]
        [MaxLength(30, ErrorMessage = "Entered Name is too long, should be under 30 character long.")]
        public string custName { get; set; }

        [Required(ErrorMessage = "City required.")]
        [RegularExpression(@"[A-Z a-z]+", ErrorMessage = "City should be in alphabets.")]
        [MaxLength(30, ErrorMessage = "Entered Name is too long, should be under 30 character long.")]
        public string city { get; set; }

        [Required(ErrorMessage = "Grade required.")]
        [RegularExpression(@"^[1-9][0][0]$", ErrorMessage = "Grade should be only 3 digit long, e.g 100,300.")]
        public string grade { get; set; }
        public string SalesId { get; set; }
    }
}
