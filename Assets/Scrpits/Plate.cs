using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using static IngredientComponent;

// Esta clase maneja la lógica del plato donde se van añadiendo los ingredientes y tal. 
// Maneja la lógica de comprobar que los ingredientes sean una receta (para cambiar su sprite)
// Tirar la comida y que se restaure el sprite del plato y la lista de ingredientes
// Dar el plato al cliente
// Añadir un ingrediente
public class Plate : MonoBehaviour
{
    public RecipeBookComponent recipeBook;      // Libro de recetas
    public List<IngredientComponent> ingredients = new List<IngredientComponent>();     // Ingredientes del plato
    private RecipeComponent currentRecipe;          // Receta actual

    public bool AddIngredient(IngredientComponent ingredient)
    {
        // No permite añadir más de una base
        if (ingredient.type == IngredientType.Base || ingredient.type == IngredientType.Flower)
        {
            if (ingredients.Exists(i => i.type == ingredient.type))
                return false;
        }
        // meter logica para añadir los sprites all plato
        return true;
    }

    // Método que se llama al entregar el plato y qu7e comprueba si la receta está bien o mal con la que pide el cliente
    public void Delivery()
    {

    }

    // Método que descarta el plato al tirarlo a la basura
    public void ThrowAway()
    {
        ClearPlate();
    }

    // Método que resetea el plato
    private void ClearPlate()
    {
        ingredients.Clear();    // Se vacía la lista
        // Habría que quitar los sprites del plato
    }
}
