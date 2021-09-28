using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  private CharacterController2D controller;
  private Rigidbody2D rb;
  private Animator animator;

  private float moveSpeed = 30f;
  private float horizontalMovement = 0f;
  private float verticalMovement = 0f;
  private bool isJumping = false;

  void Start()
  {
    controller = GetComponent<CharacterController2D>();
    rb = GetComponent<Rigidbody2D>();
    animator = GetComponent<Animator>();
  }

  void Update()
  {
    horizontalMovement = rb.velocity.x;
    verticalMovement = rb.velocity.y;

    if (Input.GetButtonDown("Jump"))
    {
      isJumping = true;
    }

    Animate();
  }

  void FixedUpdate()
  {
    controller.Move(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.fixedDeltaTime, isJumping);
    isJumping = false;
  }

  void Animate()
  {
    animator.SetFloat("velocityX", rb.velocity.x);
    animator.SetFloat("velocityY", rb.velocity.y);
  }
}
