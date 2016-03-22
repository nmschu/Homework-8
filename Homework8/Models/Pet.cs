﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Homework8.Models
{
    public class Pet
    {
        public Int32 PetID { get; set; }

        public String Picture { get; set; }  //added for image

        public String Breed { get; set; }

        public String Description { get; set; }

        public String ShortDescription { get; set; }

        [DataType(DataType.Currency)]
        public Int32 Price { get; set; }

        public DateTime DateRecieved { get; set; }

        public Int32 Quantity { get; set; }

        public virtual List<Pet> Pets { get; set; }

    }
}