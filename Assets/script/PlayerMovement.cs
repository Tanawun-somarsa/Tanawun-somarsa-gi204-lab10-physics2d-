using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    float move;

    public float jumpForce;
    public bool Isjumping;

    Rigidbody2D rb2d;
    Vector2 moveInput;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb2d.AddForce(moveInput * speed);

       /* move = Input.GetAxis("Horizontal");

        rb2d.linearVelocity = new Vector2(move * speed, rb2d.linearVelocity.y);*/
        

    if (Input.GetButtonDown("Jump") && !Isjumping)
        {
            rb2d.AddForce(new Vector2(rb2d.linearVelocity.x, jumpForce));

            Debug.Log("Jump");
        }
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            Isjumping = false;
        }
        
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Isjumping = true;
        }
        
    }

}
