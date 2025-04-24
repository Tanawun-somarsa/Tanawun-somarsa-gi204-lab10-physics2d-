using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    float move;

    Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        move = Input.GetAxis("Horizontal");

        rb2d.linearVelocity = new Vector2(move * speed, rb2d.linearVelocity.y);
    }
}
