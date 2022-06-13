using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService_Inventory.BusinessObject
{
    public class Order_BO
    {
        [Required(ErrorMessage = "Order number required")]
        [MinLength(5, ErrorMessage = "Id should be 5 digit long.")]
        [MaxLength(5, ErrorMessage = "Id should be only 5 digit long..")]
        [RegularExpression(@"^[7][0-9][0-9][0-9][0-9]$", ErrorMessage = "Id should be in 5 digit long, should start with 7.")]
        public string OrderNo { get; set; }
        [Required]
        public string OrderDate
        {
            get;
            set;
            /*  {
                  if (Convert.ToDateTime(value) >= DateTime.Today)
                  {
                      this.OrderDate=value;
                  }



              }*/
        }
        [Required]
        [RegularExpression(@"[(0-9)]*", ErrorMessage = "Amount should be in numbers")]
        public string POAmount { get; set; }

        public string SaleId { get; set; }
        public string CustId { get; set; }
    }
}
