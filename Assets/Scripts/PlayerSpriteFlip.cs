using UnityEngine;
using System.Collections;

public class PlayerSpriteFlip : MonoBehaviour
{

//public Vector2 forceSaut = new Vector3(500,500,0);

private Rigidbody2D rb;
private bool facingRight = true;
private bool facingUp = true;
private Transform groundCheck;
private bool grounded = false;

public float moveForce = 0.1f;




void Start()
{
//Debug.Log("Affichage scripts-start-personnage principale");
rb = GetComponent<Rigidbody2D>();
}
// Update is called once per frame
void Update()
{

}

void FixedUpdate()
{
//déplacent horizontal
float h = Input.GetAxis("Horizontal");
transform.Translate(Vector2.right*h * moveForce );
rb.AddForce(Vector2.right * h * moveForce);

if (h > 0 && !facingRight)
FlipX();
else if (h < 0 && facingRight)
FlipX();

//déplacement vertical
float g = Input.GetAxis("Vertical");
rb.AddForce(Vector2.up * g * moveForce);
transform.Translate(Vector2.up*g*moveForce);

if (g > 0 && !facingUp)
FlipY();
else if (g < 0 && facingUp)
FlipY();

}

void FlipX()
{ Vector3 theScale = transform.localScale;

facingRight = !facingRight;
theScale.x *= -1;
transform.localScale = theScale;
}

void FlipY()
{ Vector3 theScale = transform.localScale;

facingUp = !facingUp;
theScale.y *= -1;
transform.localScale = theScale;
}

}