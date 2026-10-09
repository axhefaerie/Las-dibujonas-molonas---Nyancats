using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using static RecipeComponent;
using static RecipeRandomizer;


public class ClientComponent : MonoBehaviour
{
    public RecipeRandomizer recipeRandomizer;

    public bool ReceivePlate(RecipeComponent deliveredRecipe)
    {
        // Comprobamos que existe una receta entregada
        if (deliveredRecipe == null)
        {
            Debug.Log("El plato no tiene ninguna receta");
            return false;
        }

        // Comprobamos que existe una receta pedida
        if (recipeRandomizer == null ||
            recipeRandomizer.requestedRecipe == null)
        {
            Debug.LogWarning("El cliente no tiene ninguna receta asignada.");
            return false;
        }

        // Comparamos la receta entregada con la pedid
        if (deliveredRecipe == recipeRandomizer.requestedRecipe)
        {
            Debug.Log("Cliente happy");
            return true;
        }
        else
        {
            Debug.Log("Cliente enfadado");
            return false;
        }
    }
}

