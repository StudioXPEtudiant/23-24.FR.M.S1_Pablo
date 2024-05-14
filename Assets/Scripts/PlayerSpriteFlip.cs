using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Vitesse de déplacement du joueur
    private Rigidbody2D rb;
    private Transform spriteTransform; // Transform de l'objet enfant contenant le sprite
    private SpriteRenderer spriteRenderer;

    // Start est appelé avant la première frame de mise à jour
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteTransform = transform.Find("Sprite"); // Trouver l'objet enfant nommé "Sprite"
        if (spriteTransform != null)
        {
            spriteRenderer = spriteTransform.GetComponent<SpriteRenderer>();
        }
        else
        {
            Debug.LogError("Sprite Renderer not found. Make sure there is an object named 'Sprite' attached as a child.");
        }
    }

    // Update est appelé une fois par frame
    void Update()
    {
        // Déplacement horizontal
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // Retourner le sprite du joueur en fonction de sa direction de déplacement
        if (moveInput > 0) // Si le joueur se déplace vers la droite
        {
            if (spriteRenderer != null)
            {
                spriteRenderer.flipX = true; // Retourner le sprite
            }
        }
        else if (moveInput < 0) // Si le joueur se déplace vers la gauche
        {
            if (spriteRenderer != null)
            {
                spriteRenderer.flipX = false; // Ne pas retourner le sprite
            }
        }
    }
}

