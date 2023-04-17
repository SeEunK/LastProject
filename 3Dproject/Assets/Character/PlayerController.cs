using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

		private Animator anim;
		private CharacterController controller;

		public float speed = 600.0f;
		public float turnSpeed = 400.0f;
		private Vector3 moveDirection = Vector3.zero;
		public float gravity = 20.0f;
		
		public bool mIsJump = false;
        public float mJumpSpeed = 20.0f;



    void Awake()
    {
        controller = GetComponent<CharacterController>();
        anim = gameObject.GetComponent<Animator>();
        
    }

    void Update()
    {
        if (Input.GetKey("w"))
        {
            anim.SetInteger("AnimationPar", 1);
        }
        else
        {
            anim.SetInteger("AnimationPar", 0);
        }

        if (controller.isGrounded)
        {
            anim.SetBool("IsJump",false);
            mIsJump = false;
            moveDirection = transform.forward * Input.GetAxis("Vertical") * speed;
        }

        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            anim.SetBool("IsJump", true);
            anim.SetTrigger("Jump");
            moveDirection.y = mJumpSpeed;

        }

        float turn = Input.GetAxis("Horizontal");
        transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
        controller.Move(moveDirection * Time.deltaTime);
        moveDirection.y -= gravity * Time.deltaTime;

  

    }
}
