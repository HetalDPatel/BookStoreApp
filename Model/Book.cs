//Model Class for the Book store App
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Model
{
    public class Book: ValidationAttribute
    {
        //Book Id
        public int BookId { get; set; }

        [Required]
        [StringLength(50)]
        public string BookName { get; set; }
        [Required]
        [RegularExpression(@"^[A-Za-z]{1,2}[\sA-Za-z]{3,50}$",
         ErrorMessage = "Speacial Characters and Numbers are Not Allowd")]
        public string BookAuthor { get; set; }

        //Date for the Book entry and Last Modified
        public string LastModifiedBookDate { get; set; }
        
        //Ratings for the Book 0-5
        [Required]     
        [Range(0,5)]
        public double Rating { get; set; }


        //Qty in BookStore
        [Required]
        [Range(1, 100)]
        public int Quantity { get; set; }

        [Required]
        [RegularExpression("^[0-9]{3}.[0-9]{3}$",
        ErrorMessage = "Enter Library Classification number in this 000.000 formate.")]
        public string LibraryClassification  { get; set; }

        //Static Id for genreting unique Book Id
        private static int Id { get; set; }

        /// <summary>
        /// Generating Unique Book id, and Get and set the current Time
        /// </summary>
        public Book()
        {
            //intialize the bookId by increasing Id
            BookId = Id++ + 1;
            LastModifiedBookDate = DateTime.Now.ToString("yyyy-MMM-dd", CultureInfo.InvariantCulture).ToLower();

        }
    }
}
