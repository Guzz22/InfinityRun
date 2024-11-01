using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;          // Velocidade de movimento
    public float jumpForce = 10f;     // Força do pulo
    private Rigidbody2D rb;
    private bool isGrounded = true;   // Checa se o personagem está no chão

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  // Obtém o Rigidbody2D do personagem
    }

    void Update()
    {
        // Movimento para a direita e esquerda
        float horizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        // Comando de pulo
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Detecta se o personagem está tocando o chão
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
