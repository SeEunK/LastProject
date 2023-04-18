using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private Animator mAnim;
    private Rigidbody mRigidbody;
    private float mHorizontalAxis = 0f;
    private float mVerticalAxis = 0f;

    public float mWalkSpeed = 5.0f;
    public float mRunSpeed = 10.0f;
    public float mTurnSpeed = 40.0f;
    private Vector3 mMoveDirection = Vector3.zero;
    public float gravity = 20.0f;
    private bool mIsRun  = false;
    public bool mIsJump = false;
    public float mJumpSpeed = 600.0f;
 



    void Awake()
    {

        mAnim = gameObject.GetComponent<Animator>();
        mRigidbody = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {

        mVerticalAxis = Input.GetAxis("Vertical"); // up & down 
        mHorizontalAxis = Input.GetAxis("Horizontal"); // left & right
        
        // run(left shift 키 입력 시 최대 1, 안누르면 0.5f) 상태 값 
        float offset = 0.5f + Input.GetAxis("Run")*0.5f;
      

        // -1: back  0 : center 1 : forward 
        mAnim.SetFloat("Vertical", mVerticalAxis * offset);
        // -1: left  0 : center 1 : right 
        mAnim.SetFloat("Horizontal", mHorizontalAxis * offset);

        // 이동 속도 run 입력값에 따라 변경.
        float moveSpeed = Mathf.Lerp(mWalkSpeed, mRunSpeed, Input.GetAxis("Run"));
  
        mMoveDirection = new Vector3(mHorizontalAxis,0, mVerticalAxis);
        transform.position += mMoveDirection * moveSpeed * Time.deltaTime;
  
        
       
        transform.LookAt(transform.position + mMoveDirection.normalized);



        Jump();

        
      
        mMoveDirection.y -= gravity * Time.deltaTime;

  

    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && !mIsJump)
        {
            mRigidbody.velocity = Vector3.zero;
            mRigidbody.AddForce(Vector3.up * mJumpSpeed, ForceMode.Impulse);


            //mMoveDirection.y = mJumpSpeed;
            Debug.Log("Jump");
            mAnim.SetBool("IsJump", true);
            mAnim.SetTrigger("Jump");
            mIsJump = true;

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            mAnim.SetBool("IsJump", false);
            mIsJump = false;
        }
    }
}
