using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Homework8.Models
{
    public class Pet
    {
        public Int32 PetID { get; set; }

        [DataType(DataType.ImageUrl)]
        public String Picture { get; set; }  //added for image

        [Required]
        public String Breed { get; set; }

        [Required]
        [Display(Name = "Long Description")]
        public String Description { get; set; }

        [Required]
        [Display(Name = "Short Description")]
        public String ShortDescription { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public Int32 Price { get; set; }

        public DateTime DateRecieved { get; set; }

        [Required]
        public Int32 Quantity { get; set; }

        public virtual List<Pet> Pets { get; set; }

    }
}