using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRUDelicious.Models;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

namespace CRUDelicious.Models
{
    public class MainController : Controller
    {
        // creates the link to the DB for querying

        private DishContext dbContext;
        // this activates the dbContext link when the controller is accessed, similar to Dapper
        public MainController(DishContext context)
        {
            dbContext = context;
        }

        // default view
        [HttpGet("")]
        public IActionResult Index()
        {
            // creates the query to the DB to pull all dish data
            List<Dish> AllDishes = dbContext.Dishes.ToList();

            // uses link to order dishes in reverse chronological order
            IEnumerable<Dish> allDishesOrdered = AllDishes.OrderByDescending(dish => dish.CreatedAt);
            return View("Index", allDishesOrdered);
        }
        
        // for adding a new recipe
        [HttpGet("new")]
        public IActionResult NewRecipe()
        {
            return View("NewRecipe");
        }

        // for creating a new recipe
        [HttpPost("Create")]
        public IActionResult Create(Dish dish)
        {
            if (ModelState.IsValid)
            {
                // need to set datetime variables for DB
                DateTime localDate = DateTime.Now;
                dish.CreatedAt = localDate;
                dish.UpdatedAt = localDate;

                // queries the DB to add the new dish object using entity
                dbContext.Add(dish);

                //saves the changes for the add query
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("NewRecipe");
            }
        }

        // for View individual recipe
        [HttpGet("{DishId}")]
        public IActionResult DisplayRecipe(int dishId)
        {
            //queries the DB for the DihId passed on the link
            Dish ViewDish = dbContext.Dishes.FirstOrDefault(dish => dish.DishId == dishId);
            return View("DisplayRecipe", ViewDish);
        }

        // For edit invidual recipe
        [HttpGet("edit/{DishId}")]
        public IActionResult UpdateRecipe(int dishId)
        {
            //queries the DB for the loan to edit
            Dish DishToEdit = dbContext.Dishes.FirstOrDefault(dish => dish.DishId == dishId);
            return View("EditRecipe", DishToEdit);
        }
        [HttpPost("{dishId}/Update")]
        public IActionResult Update(Dish dish, int dishId)
        {
            // queries the DB for the dish to edit
            Dish RetrievedDish = dbContext.Dishes.FirstOrDefault(d => d.DishId == dishId);
            
            if (ModelState.IsValid)
            {
                // updates the current time for updated at.
                DateTime localDate = DateTime.Now;
                
                // sets all queired dish properties to those of the form
                RetrievedDish.Name = dish.Name;
                RetrievedDish.Chef = dish.Chef;
                RetrievedDish.Calories = dish.Calories;
                RetrievedDish.Tastiness = dish.Tastiness;
                RetrievedDish.Description = dish.Description;
                RetrievedDish.UpdatedAt = localDate;
                
                // saves the updated data
                dbContext.SaveChanges();

                // redirects to displaying the recipe with the new edits
                return RedirectToAction("DisplayRecipe", dishId);
            }
            else
            {
                // on failure returns to the edit page
                return View("EditRecipe", dish);
            }
        }
        [HttpPost("{dishId}/Destroy")]
        public IActionResult Destroy(int dishId)
        {
            Dish DishToDelete = dbContext.Dishes.FirstOrDefault(d => d.DishId == dishId);
            dbContext.Dishes.Remove(DishToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}