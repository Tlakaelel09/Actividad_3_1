using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        // Vinculamos el componente Animator del personaje
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // Detectamos si se presionan las flechas izquierda/derecha o las teclas A/D
        float movimiento = Input.GetAxisRaw("Horizontal");

        // Si el valor no es 0, hay movimiento
        if (movimiento != 0)
        {
            anim.SetBool("Caminando", true);
        }
        else
        {
            anim.SetBool("Caminando", false);
        }
    }
}
