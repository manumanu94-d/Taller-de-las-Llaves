using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidadMovimiento = 5f;
    public float fuerzaSalto = 7f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Movimiento izquierda/derecha
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * velocidadMovimiento, rb.velocity.y);

        // Salto SIEMPRE que presiones espacio (sin l�mite, sin condiciones)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, 0); // resetear Y
            rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
            Debug.Log("Salt�!");
        }
    }
}
