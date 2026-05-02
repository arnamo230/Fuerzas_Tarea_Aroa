using UnityEngine;

public class OrbitaPlaneta : MonoBehaviour
{
    public Transform planeta;
    public float masaPlaneta = 1000000f;
    public float G = 0.0001f; // constante gravitatoria ajustada para que se note la orbita

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();


        // le doy una velocidad inicial hacia la derecha para que empiece la orbita   
        rb.AddForce(transform.right * 5f, ForceMode.Impulse);// si no hago esto simplemente cae recto hacia el planeta

    }

    void FixedUpdate()
    {
        if (planeta == null) return;

        Vector3 direccion = (planeta.position - transform.position); // vector que apunta desde el jugador al planeta
        float distancia = direccion.magnitude;
        Vector3 dirNormalizada = direccion.normalized;

        // fuerza gravitatoria
        float fuerza = G * rb.mass * masaPlaneta / (distancia * distancia);

        // aplico la fuerza hacia el planeta para que la esfera se mantenga en orbita
        rb.AddForce(dirNormalizada * fuerza, ForceMode.Force);
    }
}
