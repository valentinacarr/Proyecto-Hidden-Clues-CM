using UnityEngine;

public class ControlPersonaje : MonoBehaviour
{
    public float velocidad = 5f;
    private Rigidbody2D rb;
    private Vector2 movimiento;
    private Animator animator;
    private SpriteRenderer sprite;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        movimiento.x = Input.GetAxisRaw("Horizontal");
        movimiento.y = Input.GetAxisRaw("Vertical");

        // Animación
        animator.SetBool("isWalking", movimiento != Vector2.zero);

        // Voltear sprite
        if (movimiento.x < 0)
            sprite.flipX = true;
        else if (movimiento.x > 0)
            sprite.flipX = false;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movimiento * velocidad;
    }
}
