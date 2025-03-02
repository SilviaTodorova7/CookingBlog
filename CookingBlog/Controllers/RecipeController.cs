﻿using CookingBlog.Services.Interfaces;
using CookingBlog.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Claims;

namespace CookingBlog.Controllers
{
    public class RecipeController : Controller
    {
        private readonly IRecipeService recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            this.recipeService = recipeService;
        }

        public async Task<IActionResult> All()
        {
            ICollection<RecipeAllViewModel> allRecipesViewModel = await this.recipeService.AllRecipesAsync();
            
            return View(allRecipesViewModel);
        }

        public async Task<IActionResult> Details(int id)
        {
            try
            {
                RecipeDetailsViewModel model = await this.recipeService
                .ViewDetailsAsync(id);
                return View(model);
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "An error occured while trying to view recipe details. Plaese try again later or contact administrator!");
                return RedirectToAction("All", "Recipe");
            }
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            try
            {
                RecipeEditOrDeleteViewModel recipeModel = await this.recipeService
                .FindRecipeToEditOrDeleteAsync(id);
                return View(recipeModel);
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "An error occured while trying to edit recipe. Plaese try again later or contact administrator!");
                return RedirectToAction("All", "Recipe");
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, RecipeEditOrDeleteViewModel model)
        {
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier)!;

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.recipeService.EditRecipeAsync(model, id, userId);
                return RedirectToAction("All", "Recipe");
            }
            catch (Exception)
            {
                return RedirectToAction("All", "Recipe");
            }
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                RecipeEditOrDeleteViewModel recipeModel = await this.recipeService
                .FindRecipeToEditOrDeleteAsync(id);
                return View(recipeModel);
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "An error occured while trying to delete recipe. Plaese try again later or contact administrator!");
                return RedirectToAction("All", "Recipe");
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Delete(int id, RecipeEditOrDeleteViewModel model)
        {
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier)!;

            try
            {
                await this.recipeService.DeleteRecipeAsync(id, userId);
                return RedirectToAction("All", "Recipe");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "An error occured while trying to delete recipe. Plaese try again later or contact administrator!");
                return RedirectToAction("All", "Recipe");
            }
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            ICollection<CategoryViewModel> categories = await this.recipeService
                .GetCategoriesAsync();

            RecipeAddViewModel model = new RecipeAddViewModel()
            {
                Categories = categories
            };
            return View(model);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(RecipeAddViewModel model)
        {
            //if (!ModelState.IsValid)
            //{
            //    model.Categories = await this.recipeService.GetCategoriesAsync();
            //    return View(model);
            //}

            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier)!;

            try
            {
                await this.recipeService.AddNewRecipeAsync(model, userId);
                return RedirectToAction("All", "Recipe");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "An error occured while trying to add recipe. Plaese try again later or contact administrator!");
                return RedirectToAction("All", "Recipe");
            }
        }
    }
}
