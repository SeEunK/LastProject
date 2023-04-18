using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {

    private Animator mAnim;
    private Rigidbody mRigidbody;
    private float mHorizontalAxis = 0f;
    private float mVerticalAxis = 0f;

    public float mWalkSpeed = 5.0f;
    public float mRunSpeed = 10.0f;
    public float mTurnSpeed = 40.0f;
    private Vector3 mMoveDirection = Vector3.zero;
    public float gravity = Physics.gravity.magnitude;
    private bool mIsRun  = false;
    public bool mIsJump = false;
    public float mJumpForce = 10.0f;
    private float mFallMultiplier = 2.5f;


    private NavMeshAgent mAgent;


   

   


    void Awake()
    {
        mAgent = GetComponent<NavMeshAgent>();
        
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



        if (Input.GetButtonDown("Jump") && !mIsJump)
        {
            //mAgent.enabled = false;
            //mRigidbody.velocity = new Vector3(mRigidbody.velocity.x, 0, mRigidbody.velocity.z);
            //float jumpVelocity = Mathf.Sqrt(2*jump)
            mRigidbody.AddForce(Vector3.up * mJumpForce, ForceMode.Impulse);


            Debug.Log("Jump");
            mAnim.SetBool("IsJump", true);
            mAnim.SetTrigger("Jump");
            mIsJump = true;

        }
        
        if(mIsJump)
        {
            if (transform.position.y < mJumpForce)
            {
                transform.position += Vector3.up * mFallMultiplier * Physics.gravity.magnitude * Time.deltaTime;
                mAgent.enabled = false;
            }
            else
            {
                mAgent.enabled = true;
            }
        }

        
        if(Input.GetMouseButtonDown(0))
        {
            mAgent.enabled = true;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit)) 
            {
                mAgent.SetDestination(hit.point);   
            }
        }

        //mMoveDirection.y -= gravity * Time.deltaTime;

    }

    


    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && !mIsJump)
        {
            mRigidbody.velocity = Vector3.zero;
            mRigidbody.AddForce(transform.up * mJumpForce, ForceMode.Impulse);


            //mMoveDirection.y = mJumpSpeed;
            Debug.Log("Jump");
            mAnim.SetBool("IsJump", true);
            mAnim.SetTrigger("Jump");
            mIsJump = true;

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        mAgent.enabled = true;
        if (collision.gameObject.CompareTag("Ground"))
        {
           
            mAnim.SetBool("IsJump", false);
            mIsJump = false;
        }
    }
}
