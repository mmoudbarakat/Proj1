﻿namespace ASP_MVC_E_Commerce_Final_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
  

    [Table("Food")]
    public partial class Food
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Food()
        {
            FoodItems = new HashSet<FoodItem>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FoodID { get; set; }

        [Key]
        [StringLength(50)]
        [Display(Name = "Food Type")]
        public string FoodType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FoodItem> FoodItems { get; set; }
    }
}
