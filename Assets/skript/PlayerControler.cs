using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField]  private float speed = 3;
    private float jump = 400;
    public Rigidbody2D phy;
    public Animator animator;
    private bool gravity = true;
    [SerializeField] private float _maxSpeed = 10;

    private void FixedUpdate()
    {
        Move();
        limitSpeed();
    }
    private void Move()
    {
        if (Input.GetKey(KeyCode.D))
        {
            phy.AddForce(transform.right * speed);
            animator.SetBool("Right",true);
            animator.SetBool("Left", false);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            phy.AddForce(-transform.right * speed);
            animator.SetBool("Left", true);
            animator.SetBool("Right", false);
        }
        else
        {
            animator.SetBool("Left", false);
            animator.SetBool("Right", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("paskacaty");
            if (gravity == true)
            {
                phy.AddForce(Vector2.up * jump);
                phy.gravityScale = -1;
                gravity = false;
            }
            else
            {
                phy.AddForce(Vector2.down * jump);
                phy.gravityScale = 1;
                gravity = true;
            }
        }
    }

    void limitSpeed()
    {
        if (phy.velocity.magnitude > _maxSpeed)
        {
            phy.velocity = phy.velocity.normalized * _maxSpeed;
        }
    }
}
