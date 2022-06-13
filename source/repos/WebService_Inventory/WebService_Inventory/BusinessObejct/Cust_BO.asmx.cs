using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService_Inventory.BusinessObejct
{
    /// <summary>
    /// Summary description for Cust_BO
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Cust_BO : System.Web.Services.WebService
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
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
