using UnityEngine;
using UnityEngine.InputSystem;

public class RocketLauncher : MonoBehaviour
{
    public Rigidbody Cohete50k;
    public Rigidbody Cohete30k;
    public Rigidbody Cohete20k;

    private bool motorEncendido = false;
    public float fuerzaEmpuje = 500000f; //300000 se queda corto
    private bool Despegar = false;       



    public void OnLaunch(InputAction.CallbackContext ctx) //pulsa la barra espaciadora para despegar
    {
        if (ctx.performed && !Despegar)
        {
            if (ctx.performed)
            {
                motorEncendido = true;
            }
        }
    }

    void FixedUpdate()
    {
        if (!motorEncendido) return;// para q empiecen a despegar solo cuando se pulse la barra 



        if (Cohete50k != null)
            Cohete50k.AddForce(Vector3.up * fuerzaEmpuje, ForceMode.Force);

        if (Cohete30k != null)
            Cohete30k.AddForce(Vector3.up * fuerzaEmpuje, ForceMode.Force);

        if (Cohete20k != null)
            Cohete20k.AddForce(Vector3.up * fuerzaEmpuje, ForceMode.Force);

    }
}