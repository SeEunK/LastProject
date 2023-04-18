using UnityEngine;
using System.Collections;
using UnityEngine.AI;
using Unity.VisualScripting;

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
    private bool mIsAutoMove  = false;
    public bool mIsJump = false;
    public float mJumpForce = 10.0f;
    private float mFallMultiplier = 2.5f;

    private Vector3[] mAutoMovePos = null;
    private int mCurrentIndex = 0;




    void Awake()
    {
        
        mAnim = gameObject.GetComponent<Animator>();
        mRigidbody = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (Input.GetButtonDown("Vertical") || Input.GetButtonDown("Horizontal") || Input.GetButtonDown("Run"))
        {
            mIsAutoMove = false;
        }

        if (mIsAutoMove == false)
        {
            mVerticalAxis = Input.GetAxis("Vertical"); // up & down 
            mHorizontalAxis = Input.GetAxis("Horizontal"); // left & right

            // run(left shift 키 입력 시 최대 1, 안누르면 0.5f) 상태 값 
            float offset = 0.5f + Input.GetAxis("Run") * 0.5f;


            // -1: back  0 : center 1 : forward 
            mAnim.SetFloat("Vertical", mVerticalAxis * offset);
            // -1: left  0 : center 1 : right 
            mAnim.SetFloat("Horizontal", mHorizontalAxis * offset);

            // 이동 속도 run 입력값에 따라 변경.
            float moveSpeed = Mathf.Lerp(mWalkSpeed, mRunSpeed, Input.GetAxis("Run"));

            mMoveDirection = new Vector3(mHorizontalAxis, 0, mVerticalAxis);
            transform.position += mMoveDirection * moveSpeed * Time.deltaTime;



            transform.LookAt(transform.position + mMoveDirection.normalized);

        }

        if (Input.GetButtonDown("Jump") && !mIsJump)
        {
            mIsAutoMove = false;
            //mAgent.enabled = false;
            //mRigidbody.velocity = new Vector3(mRigidbody.velocity.x, 0, mRigidbody.velocity.z);
            //float jumpVelocity = Mathf.Sqrt(2*jump)
            mRigidbody.AddForce(Vector3.up * mJumpForce, ForceMode.Impulse);

            Debug.Log("Jump");
            mAnim.SetBool("IsJump", true);
            mAnim.SetTrigger("Jump");
            mIsJump = true;

        }
        
       

        
        if(Input.GetMouseButtonDown(0) && !mIsAutoMove)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, float.MaxValue)) 
            {
                {
                    // 임시 길찾기 사용
                    GameObject instance = GameObject.Find("__PathFinder__");
                    PathFinder pathFinder = instance.GetComponent<PathFinder>();
                    if (pathFinder)
                    {
                        Vector3[] paths = pathFinder.GetPath(this.transform.position, hit.point);
                        mAutoMovePos = paths;
                        mIsAutoMove = true;
                        if (paths != null)
                        {
                            for (int idx = 0; idx < paths.Length; ++idx)
                            {
                                GameObject pathObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                                pathObject.GetComponent<SphereCollider>().enabled = false;
                                pathObject.GetComponent<MeshRenderer>().material.color = Color.red;
                                pathObject.name = "D_" + idx.ToString();
                                pathObject.transform.localScale = Vector3.one * 0.5f;
                                pathObject.transform.position = paths[idx];
                            }
                        }                        
                    }
                }
                
            }
        }

        if (mIsAutoMove)
        {

            int maxIndex = mAutoMovePos.Length;

            Debug.LogFormat("x: {0}, y:{1}, z:{2}", mAutoMovePos[mCurrentIndex].x, mAutoMovePos[mCurrentIndex].y, mAutoMovePos[mCurrentIndex].z);
            //transform.position = Vector3.MoveTowards(this.transform.position, mAutoMovePos[mCurrentIndex], mWalkSpeed * Time.deltaTime);
            
            // 이동 방향
            mMoveDirection = (mAutoMovePos[mCurrentIndex] - transform.position).normalized;
            // y 값은 초기화
            mMoveDirection.y = 0f;

            // 회전 값 계산
            Quaternion lookRotation = Quaternion.LookRotation(mMoveDirection);
            
            Quaternion startRotation = transform.rotation;
            Vector3 newPos = transform.position + mMoveDirection * mWalkSpeed * Time.deltaTime;
            Quaternion newRotation = Quaternion.Lerp(startRotation, lookRotation, mTurnSpeed* Time.deltaTime);
            newRotation.x = startRotation.x; // x 값 유지
            newRotation.z = startRotation.z; // y 값 유지
            //mRigidbody.velocity = mMoveDirection *mWalkSpeed* Time.deltaTime;
            mRigidbody.MovePosition(newPos);
            mRigidbody.MoveRotation(newRotation);
            transform.LookAt(transform.position + mMoveDirection.normalized);


            if (Vector3.Distance(transform.position,mAutoMovePos[mCurrentIndex])< 0.1f)
            {

                Debug.Log("add i");
                mCurrentIndex++;
            }
            if (mCurrentIndex == maxIndex)
            {
                mCurrentIndex = 0;
                mIsAutoMove = false;
            }


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
