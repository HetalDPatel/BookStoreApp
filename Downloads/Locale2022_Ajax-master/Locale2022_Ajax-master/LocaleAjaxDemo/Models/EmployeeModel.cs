using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LocaleAjaxDemo.Models
{
    public class EmployeeModel
    {
        [Display(ResourceType = typeof(Resources.Locale), Name = "FirstName" )]
        public string FName { get; set; }

        [Display(ResourceType = typeof(Resources.Locale), Name = "LastName")]
        public string LName { get; set; }

        public int EmployeeId { get; set; }
    }
}