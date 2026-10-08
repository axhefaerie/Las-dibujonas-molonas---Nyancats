using UnityEngine;

// Clase que contiene la logica de mover el plato
public class DragPlate : Draggable
{
    // Método que se ejecuta cuando se suelta el ratón al estar moviendo el plato
    protected override void OnDrop()
    {
        RaycastHit2D hit = Physics2D.Raycast(GetMouseWorldPos(), Vector2.zero);     // Se comprueba si el collider del ingrediente ha dado con otro collider
        if (hit.collider != null)
        {
            // FALTA Lógica de arrastrar al cliente

            // Lógica de arrastrar a la basura
            TrashComponent trash = hit.collider.GetComponent<TrashComponent>();
            if (trash != null)
            {
                GetComponent<PlateComponent>().ThrowAway();
                ReturnToOrigin();
                return;
            }
        }
        ReturnToOrigin();
    }
}
