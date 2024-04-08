using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] KeyCode teclaArriba;
    [SerializeField] KeyCode teclaAbajo;
    [SerializeField] KeyCode teclaDerecha;
    [SerializeField] KeyCode teclaIzquierda;
    [SerializeField] KeyCode teclaRotarIzq;
    [SerializeField] KeyCode teclaRotarDer;


    [SerializeField] float velocidad = 0.001f;
    [SerializeField] float velocidad1 = 0.001f;

    public Transform target;

    void Update()
    {
        if (Input.GetKey(teclaArriba))
        {
            //mover hacia arriba
            target.transform.Translate(Vector3.up * velocidad);
        }

        if (Input.GetKey(teclaAbajo))
        {
            //mover hacia abajo
            target.transform.Translate(Vector3.down * velocidad);
        }

        if (Input.GetKey(teclaDerecha))
        {
            //mover hacia derecha
            target.transform.Translate(Vector3.right * velocidad);
        }

        if (Input.GetKey(teclaIzquierda))
        {
            //mover hacia izquierda
            target.transform.Translate(Vector3.left * velocidad);
        }
        if (Input.GetKey(teclaRotarDer))
        {

            target.transform.Rotate(new Vector3 (0, 0, velocidad1));
        }
        if (Input.GetKey(teclaRotarIzq))
        {

            target.transform.Rotate(new Vector3(0, 0, -velocidad1));
        }
    }
}