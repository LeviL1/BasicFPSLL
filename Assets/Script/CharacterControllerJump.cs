using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerJump : MonoBehaviour
{
  public CharacterController controller;
  public float speed = 12f;
  
  public float gravity = -9.8f;
  public float jumpHeight = 3f;


  public Transform groundCheck;
  public float groundDist = 0.4f;
  public LayerMask groundMask;

  Vector3 velocity;
  bool isGrounded;

  void Update()
  {
    isGrounded = Physics.CheckSphere(groundCheck.position, groundDist, groundMask);
    if(isGrounded && velocity.y < 0)
    {
      velocity.y = -2f;
    }
    //get input from vertical and horizontal inputs
    float x = Input.GetAxis("Horizontal");
    float z = Input.GetAxis("Vertical");
    //creates a direction for play to move
    Vector3 move = transform.right * x + transform.forward * z;
    //moves the character around
    controller.Move(move * speed * Time.deltaTime);
    if(Input.GetButtonDown("Jump") && isGrounded)
    {
      velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
    }
    velocity.y += gravity * Time.deltaTime;
    controller.Move(velocity * Time.deltaTime);

  }
}