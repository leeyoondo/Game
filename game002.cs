using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class block_moving : MonoBehaviour
{
    Rigidbody2D rb;
    public float block_speed;
    int jump_point;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        block_speed = 5.0f;
        jump_point = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump_point = 1;
        }
    }

    [System.Obsolete]
    private void OnBlock_Movement(InputValue inputValue)
    {
        float left_and_Right = inputValue.Get<Vector2>().x;
        float jump_up_and_down = inputValue.Get<Vector2>().y;
        Vector2 newVelocity = new Vector2(
        left_and_Right * block_speed,
        jump_up_and_down * block_speed);
        rb.velocity = newVelocity;
        if(jump_up_and_down != 0)
        {
            jump_point++;
        }
    }
}