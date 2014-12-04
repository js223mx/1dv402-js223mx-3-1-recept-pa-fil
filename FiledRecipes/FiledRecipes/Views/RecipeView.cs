using FiledRecipes.Domain;
using FiledRecipes.App.Mvp;
using FiledRecipes.Properties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiledRecipes.Views
{
    /// <summary>
    /// 
    /// </summary>
    public class RecipeView : ViewBase, IRecipeView
    {
        public void Show(IEnumerable<IRecipe> recipes) 
        {
            
            foreach(IRecipe recipe in recipes)
            {
                Show(recipe);
                ContinueOnKeyPressed();
            }

        }
        public void Show(IRecipe recipe) 
        {
            //sätter hedernamnet till receptnamnet och visar headern
            Header = recipe.Name;
            ShowHeaderPanel();

            Console.WriteLine("Ingredienser");
            Console.WriteLine("=============");
            foreach (IIngredient ingredient in recipe.Ingredients) 
            {
                Console.WriteLine(ingredient);
            }


            Console.WriteLine("Instruktioner");
            Console.WriteLine("==============");
            foreach (string instruction in recipe.Instructions) 
            {
                Console.WriteLine(instruction);
            }
           
        }
    }
}
