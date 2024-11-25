using UnityEngine;

public class Colision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("GOLPEEEEEE");
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Entrando a trigger");
        if(other.tag == "Paquete")
        {
            Debug.Log("Paquete Recogido");
        }
        if(other.tag == "Cliente")
        {
            Debug.Log("Paquete Entregado");
        }
    }
}
