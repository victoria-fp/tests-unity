using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    [SerializeField] private float hSpeed = 10f;
    [SerializeField] private float vSpeed = 6f;
    private Rigidbody2D rb;
    [SerializeField] private bool canMove = true;
    private bool isFacingRight = true;

    [Range(0, 1.0f)]
    [SerializeField] float movementSmooth = 0.5f;
    private Vector3 velocity = Vector3.zero;

    float horizontalMove;
    float verticalMove;



    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move(float hMove, float vMove, bool jump)
    {
        if (canMove)
        {
            Vector3 targetVelocity = new Vector2(hMove * hSpeed, vMove * vSpeed);
            rb.velocity = Vector3.SmoothDamp(
                rb.velocity, targetVelocity, ref velocity, movementSmooth);

            if (hMove > 0 && !isFacingRight)
            {
                flip();
            }
            else if (hMove < 0 && isFacingRight)
            {
                flip();
            }
        }
    }

    private void flip()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0, 180, 0);
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");

        /*if (Input.GetButtonDown("Fire1")) {
            Debug.Log("attack");
        }*/

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right);

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("attack");
        }
    }


    private void FixedUpdate()
    {
        Move(horizontalMove, verticalMove, false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag.Equals("Ground"))
        {
            Debug.Log("trying to leave game area");
        }

        /*if (collision.collider.tag.Equals("Enemy"))
        {
            Debug.Log("DAMAGE DEALT!!!!!");
        }*/
    }
}
