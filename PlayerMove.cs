using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public float JumpForce = 5f;
    private Rigidbody2D rb;
    private bool isJumping;
    SpriteRenderer sr;
    Animator anim;

   void Start()
    {
     rb = GetComponent<Rigidbody2D>();
     sr = GetComponent<SpriteRenderer>();
     anim = GetComponent<Animator>();
        isJumping = false;
    }

    void Update()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(Horizontal * MoveSpeed, rb.linearVelocity.y);

        if (Input.GetButtonDown("Horizontal")) {
            sr.flipX = Input.GetAxisRaw("Horizontal") == -1;        
        }
           

        if (Input.GetButton("Jump") && !isJumping)
        {
            isJumping = true;
            rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            anim.SetBool("isJump", true);
        }

        if (rb.linearVelocity.normalized.x == 0)
        {
            anim.SetBool("isWalk", false);
        }
        else
        {
            anim.SetBool("isWalk", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJumping = false ;
            anim.SetBool("isJump", false);
        }
    }
}
