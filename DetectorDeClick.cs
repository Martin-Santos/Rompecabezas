using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class DetectorDeClick : MonoBehaviour
{
    public Movement mr;

    void Update()
    {
        // Detectar clic izquierdo del mouse
        if (Input.GetMouseButtonDown(0))
        {
            // Obtener posición del clic del mouse en el mundo
            Vector2 posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Raycast para detectar el objeto clickeado
            RaycastHit2D hit = Physics2D.Raycast(posicionMouse, Vector2.zero);

            // Verificar si el rayo golpeó un collider
            if (hit.collider != null)
            {
                // Obtener el transform del objeto clickeado
                mr.target = hit.collider.transform;

                // Hacer algo con el objeto clickeado
                Debug.Log("Objeto clickeado: " + mr.target.name);
            }
        }
    }
}
