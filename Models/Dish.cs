using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicious.Models
{
    public class Dish
    {
        // Model properties must match DB table -- PascalCase/Case Sensativity is a must!
        [Key]
        public int DishId { get; set; }
        [Display(Name="Dish's Name")]
        [Required(ErrorMessage = "Dish name is required!")]
        public string Name  {get; set; }
        [Display(Name="Chef's Name")]
        [Required(ErrorMessage = "Chef name is required!")]
        public string Chef { get; set; }
        [Display(Name="Dish's Tastiness")]
        [RegularExpression(@"^[1-9]|5*$", ErrorMessage = "What are you doing?! Tastiness must be a number 1-5!")]
        public int? Tastiness { get; set; }
        [Display(Name="Dish's Calories")]
        [Required(ErrorMessage="Calories are required")]
        [Range(1,5000,ErrorMessage="Calories must be a number between 1 and 5000!")]
        public int? Calories { get; set; }
        [Display(Name="Dish's Description")]
        [Required(ErrorMessage = "Description is required!")]
        [MinLength(20,ErrorMessage="Description must be at least 20 characters!")]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}