﻿namespace ASP_MVC_E_Commerce_Final_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class FoodItem
    {
        public int FoodItemID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string FoodItemName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Food Type")]
        public string FoodType { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Description")]
        public string ShortDesc { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Detailed Description")]
        public string LongDesc { get; set; }

        [Display(Name = "Price")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }

        public virtual Food Food { get; set; }
    }
}
