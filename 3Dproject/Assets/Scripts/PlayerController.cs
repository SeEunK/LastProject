using UnityEditorInternal.VersionControl;
using UnityEngine;
using System.Collections.Generic;

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
   

    private Vector3[] mAutoMovePos = null;
    private int mCurrentIndex = 0;

    [SerializeField] 
    private GameObject[] mTools = null;
    [SerializeField]
    private bool[] mHasTools = null;
    private GameObject mDetectedObject = null;
    private GameObject mEquipTool= null;

    private List<Item> mItemList = new List<Item>();
    [SerializeField]
    private Transform mPickItemPos = null;
    private GameObject mPickUpItem = null;

    public bool mIsCarryItem = false;

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

            // run(left shift Ű �Է� �� �ִ� 1, �ȴ����� 0.5f) ���� �� 
            float offset = 0.5f + Input.GetAxis("Run") * 0.5f;
            if (!mIsCarryItem)
            {
                // -1: back  0 : center 1 : forward 
                mAnim.SetFloat("Vertical", mVerticalAxis * offset);
                // -1: left  0 : center 1 : right 
                mAnim.SetFloat("Horizontal", mHorizontalAxis * offset);
            }
            else
            {
                if (mVerticalAxis == 0 && mHorizontalAxis == 0 )
                {
                    mAnim.SetBool("IsMove", false);
                }
                else
                {
                    mAnim.SetBool("IsMove", true);

                }
            }
            // �̵� �ӵ� run �Է°��� ���� ����.
            float moveSpeed = Mathf.Lerp(mWalkSpeed, mRunSpeed, Input.GetAxis("Run"));

            mMoveDirection = new Vector3(mHorizontalAxis, 0, mVerticalAxis);
            transform.position += mMoveDirection * moveSpeed * Time.deltaTime;



            transform.LookAt(transform.position + mMoveDirection.normalized);

        }

        if (Input.GetButtonDown("Jump") && !mIsJump)
        {
            mIsAutoMove = false;
   
            mRigidbody.AddForce(Vector3.up * mJumpForce, ForceMode.Impulse);

            Debug.Log("Jump");
            mAnim.SetBool("IsJump", true);
            mAnim.SetTrigger("Jump");
            mIsJump = true;

        }

        if (Input.GetButtonDown("Interaction") && !mIsJump)
        {
            Interation();
        }

        if(Input.GetButtonDown("Drop") && mIsCarryItem)
        {
            mAnim.SetTrigger("PutDown");
        }

        if (Input.GetButtonDown("ToolSwap1")|| Input.GetButtonDown("ToolSwap2")|| Input.GetButtonDown("ToolSwap3")|| Input.GetButtonDown("ToolSwap4") && !mIsJump)
        {
            int swapIndex = -1;
          
            switch (Input.inputString)
            {
                
                case "1":
                    swapIndex = 0;
                    break;
                case "2":
                    swapIndex = 1;
                    break;
                case "3":
                    swapIndex = 2;
                    break;
                case "4":
                    swapIndex = 3;
                    break;
                    

            }

            // ������ tool�� ���
            if (mHasTools[swapIndex] == true)
            {
                ToolSwap(swapIndex);
                
            }
            else
            {
                Debug.LogFormat("Do not have Tool (Tool index : {0})", swapIndex);
                return;
            }
        }

        if(Input.GetButtonDown("UnEquip") && mEquipTool != null)
        {
            UnEquipItem();
        }

        if (Input.GetMouseButtonDown(0) && !mIsAutoMove && !mIsJump)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, float.MaxValue))
            {
                {
                    mAutoMovePos = PathFinder.Instance.GetPath(this.transform.position, hit.point);

                    mIsAutoMove = true;
                    if (mAutoMovePos != null)
                    {
                        for (int idx = 0; idx < mAutoMovePos.Length; ++idx)
                        {
                            GameObject pathObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                            pathObject.GetComponent<SphereCollider>().enabled = false;
                            pathObject.GetComponent<MeshRenderer>().material.color = Color.red;
                            pathObject.name = "D_" + idx.ToString();
                            pathObject.transform.localScale = Vector3.one * 0.5f;
                            pathObject.transform.position = mAutoMovePos[idx];
                        }
                    }
                }

            }
        }

        if (mIsAutoMove)
        {

            int maxIndex = mAutoMovePos.Length;
            
            // �̵� ����
            mMoveDirection = (mAutoMovePos[mCurrentIndex] - transform.position).normalized;
         
            // y ���� �ʱ�ȭ
            mMoveDirection.y = 0f;

            // ȸ�� �� ���
            Quaternion lookRotation = Quaternion.LookRotation(mMoveDirection);
            
            Quaternion startRotation = transform.rotation;
            Vector3 newPos = transform.position + mMoveDirection * 10.0f * Time.deltaTime;
            Quaternion newRotation = Quaternion.Lerp(startRotation, lookRotation, mTurnSpeed* Time.deltaTime);
            newRotation.x = startRotation.x; // x �� ����
            newRotation.z = startRotation.z; // y �� ����

            // -1: back  0 : center 1 : forward 
            mAnim.SetFloat("Vertical", 0.5f);
            // -1: left  0 : center 1 : right 
            mAnim.SetFloat("Horizontal", 0);

            mRigidbody.MoveRotation(newRotation);
            mRigidbody.MovePosition(newPos);
            transform.LookAt(transform.position + mMoveDirection);


            if (Vector3.Distance(transform.position,mAutoMovePos[mCurrentIndex])< 0.1f)
            {
                mCurrentIndex++;
            }
            if (mCurrentIndex == maxIndex)
            {
                mCurrentIndex = 0;
                PathFinder.Instance.ResetPath();
                mIsAutoMove = false;
            }

        }

    }
    public void ToolSwap(int ToolIndex)
    {
        if(mEquipTool != null)
        {
            mEquipTool.SetActive(false);
        }
        mEquipTool = mTools[ToolIndex];
        mEquipTool.SetActive(true);

    }

    public void Interation()
    {
        if (mDetectedObject != null)
        {
            if (mDetectedObject.CompareTag("Tool"))
            {
                Item item = mDetectedObject.GetComponent<Item>();
                int toolIndex = item.GetItemId()-1;
                mHasTools[toolIndex] = true;

                Destroy(mDetectedObject);
                mDetectedObject = null;
            }
            else if (mDetectedObject.CompareTag("Item"))
            {
                Debug.Log("detected item");
                UnEquipItem();
                mPickUpItem = mDetectedObject;
                mAnim.SetTrigger("PickUp");
                mDetectedObject = null;
                
            }
        }
    }

    public void ItemPickUp()
    {
        if (mPickUpItem != null)
        {
            Item item = mPickUpItem.GetComponent<Item>();
            item.PickUp(mPickItemPos);
            mItemList.Add(item);
           
        
            mIsCarryItem = true;
        }
    }

    public void UnEquipItem()
    {
        if (mEquipTool != null)
        {
            mEquipTool.SetActive(false);
        }
    }

    public void ItemPutDown()
    {
        if(mPickUpItem != null)
        {
            Vector3 dropPos = mPickItemPos.position;
            Item item = mPickUpItem.GetComponent<Item>();
            mItemList.Remove(item);
            item.Drop(dropPos);
           
            mIsCarryItem = false;
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


    private void OnTriggerEnter(Collider other)
    {
    
        if (other.gameObject.CompareTag("Tool"))
        {
            mDetectedObject = other.gameObject;
        }


        if (other.gameObject.CompareTag("Item"))
        {
            mDetectedObject = other.gameObject;
            Debug.Log(mDetectedObject.name);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Tool"))
        {
            mDetectedObject = null;
        }


        if (other.gameObject.CompareTag("Item"))
        {
            mDetectedObject = null;
            
        }
    }



}
