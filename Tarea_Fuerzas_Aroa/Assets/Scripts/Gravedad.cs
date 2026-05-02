using Unity.VisualScripting;
using UnityEngine;

public class Gravedad : MonoBehaviour
{
    public Transform Planeta;  
    public float masaPlaneta = 1000000f; 
    public float G = 6.673e-11f;   // constante gravitatoria
    public float gravedadExtra = 1000000f;// para hacer la gravedad mas fuerte porque la constante gravitatoria es muy pequeña y no se notaba 


    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Planeta == null) return;

        Vector3 direccion = (Planeta.position - transform.position);

        float distancia = direccion.magnitude; // distancia entre jugador-planeta

        Vector3 direccionNormalizada = direccion.normalized;// normalizacion de la dirección


       float fuerza = G * rb.mass * masaPlaneta / (distancia * distancia);
        fuerza *= gravedadExtra;//aqui multiplico la gravedad extra de antes 

        // la fuerza hacia el planeta
        rb.AddForce(direccionNormalizada * fuerza, ForceMode.Force);
    }
}
