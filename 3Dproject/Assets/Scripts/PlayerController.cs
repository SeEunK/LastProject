using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;

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
    public float mJumpForce = 10.0f;

    [SerializeField]
    private Vector3[] mAutoMovePos = null;
    private int mCurrentIndex = 0;

    [SerializeField] 
    private GameObject[] mTools = null;
    [SerializeField]
    private bool[] mHasTools = null;
    private GameObject mDetectedObject = null;
    private GameObject mEquipTool= null;
    private int mEquipToolId = -1;
    private Collider mEquipToolCollider = null;


    private List<Item> mItemList = new List<Item>();
    [SerializeField]
    private Transform mPickItemPos = null;
    private GameObject mPickUpItem = null;
    private GameObject mGatheringItem = null;

    public bool mIsJump = false;
    public bool mIsCarryItem = false;

    public enum State { None, Jump, Carry, Fishing }
    private State mState = State.None;

    public Interactable mFocus;
    [SerializeField]
    private float mStopDistance = 0.0f;

    void Awake()
    {
        
        mAnim = gameObject.GetComponent<Animator>();
        mRigidbody = gameObject.GetComponent<Rigidbody>();
    }

     void Start()
    {
        
        if (DataManager.instance.GetPlayerEquipItem() != -1)
        {
            ToolSwap(DataManager.instance.GetPlayerEquipItem());
        }
        
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
            if (mState != State.Carry)
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
            // 이동 속도 run 입력값에 따라 변경.
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

        if(Input.GetButtonDown("Drop") && mState == State.Carry)
        {
            mAnim.SetTrigger("PutDown");
        }

        if(mState == State.Fishing)
        {
            if (Input.GetButtonDown("UnEquip"))
            {
                mAnim.SetTrigger("FishingCancle");
                mState = State.None;
                return;
            }
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

            // 보유한 tool인 경우
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
      
       
        if (Input.GetMouseButtonDown(0) && !mIsAutoMove && !mIsJump && !UIManager.Instance.IsInventoryUIOpen())
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            mStopDistance = 1.0f;

            if (Physics.Raycast(ray, out hit, float.MaxValue))
            {
                {
                    mAutoMovePos = PathFinder.Instance.GetPath(this.transform.position, hit.point);

                  
                    if (mAutoMovePos != null)
                    {
                        mIsAutoMove = true;
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

        if (Input.GetMouseButtonDown(1) && !UIManager.Instance.IsInventoryUIOpen())
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 100.0f)){
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                if(interactable!= null)
                {
                    SetFocus(interactable);
                    
                    float distance = Vector3.Distance(this.transform.position, mFocus.GetInteractionTransform().position);
                    
                    if (distance > mStopDistance)
                    {
                        mAutoMovePos = PathFinder.Instance.GetPath(this.transform.position, mFocus.GetInteractionTransform().position);
                        mIsAutoMove = true;
                    }
                    else
                    {
                        mIsAutoMove = false;
                        Interact();
                        //interactable.Interact();
                       
                    }
                }
            }
        }
        if (mIsAutoMove)
        {

            int maxIndex = mAutoMovePos.Length;

            // 이동 방향
            mMoveDirection = (mAutoMovePos[mCurrentIndex] - transform.position).normalized;
         
            // y 값은 초기화
            mMoveDirection.y = 0f;

            // 회전 값 계산
            Quaternion lookRotation = Quaternion.LookRotation(mMoveDirection);
            
            Quaternion startRotation = transform.rotation;
            Vector3 newPos = transform.position + mMoveDirection * 10.0f * Time.deltaTime;
            Quaternion newRotation = Quaternion.Lerp(startRotation, lookRotation, mTurnSpeed* Time.deltaTime);
            newRotation.x = startRotation.x; // x 값 유지
            newRotation.z = startRotation.z; // y 값 유지

            // -1: back  0 : center 1 : forward 
            mAnim.SetFloat("Vertical", 0.5f);
            // -1: left  0 : center 1 : right 
            mAnim.SetFloat("Horizontal", 0);

            mRigidbody.MoveRotation(newRotation);
            mRigidbody.MovePosition(newPos);
            transform.LookAt(transform.position + mMoveDirection);


            if (Vector3.Distance(transform.position, mAutoMovePos[mCurrentIndex]) <= mStopDistance)
            {
                mCurrentIndex++;
            }
            if (mCurrentIndex == maxIndex)
            {
                mCurrentIndex = 0;
                PathFinder.Instance.ResetPath();
                mIsAutoMove = false;
               
                //mStopDistance = 0.0f;
            }

        }

    }


    public void SetFocus(Interactable newFocus)
    {
        if (newFocus != mFocus)
        {
            if (mFocus != null)
            {
                mFocus.OnDefocused();

            }
            mFocus = newFocus;
            mStopDistance = newFocus.GetInteractRadius();
        }

        newFocus.OnFocused(this.transform);


    }

    public void RemoveFocus()
    {
        if (mFocus != null)
        {
            mFocus.OnDefocused();
        }
        mFocus = null;
    }

    public void ToolSwap(int ToolIndex)
    {
        if (mEquipTool != null)
        {
            mEquipTool.SetActive(false);
        }
        mEquipToolId = ToolIndex + 1;
        mEquipTool = mTools[ToolIndex];
        DataManager.instance.SetPlayerEquipItem(ToolIndex);
        UIManager.Instance.EquipToolChange(mEquipToolId);
        if (mEquipTool.GetComponent<Collider>() != null)
        {
            mEquipToolCollider = mEquipTool.GetComponent<Collider>();
            mEquipToolCollider.enabled = false;
        }
        mEquipTool.SetActive(true);

    }

    public void Interation()
    {
     
        if (mDetectedObject != null)
        {
            if (mDetectedObject.CompareTag("Tool"))
            {

                Item item = mDetectedObject.GetComponent<Item>();


                int toolIndex = item.GetItemId() - 1;
                mHasTools[toolIndex] = true;

                bool getItem = Inventory.Instance.Add(item.GetItemData());

                if (getItem)
                {
                    Destroy(mDetectedObject);
                    mDetectedObject = null;
                }

            }
            else if (mDetectedObject.CompareTag("Equipment"))
            {

            }
            else if (mDetectedObject.CompareTag("Item"))
            {
                Debug.Log("detected item");
                if (mEquipTool != null)
                {
                    Debug.Log("장비 장착중");
                    mDetectedObject = null;
                    return;
                }
                else
                {
                    Debug.Log("장비 미장착 픽업!");
                    mPickUpItem = mDetectedObject;
                    mAnim.SetTrigger("PickUp");
                    mDetectedObject = null;
                }
                
            }

            else if (mDetectedObject.CompareTag("Interaction"))
            {
                Debug.Log("detected Interaction");

                if (CheckEquipItem())
                {
                    //InteractionAction();
                    
                }
                else
                {
                    Debug.Log("Interaction tool mismatch");
                } 

            }
        }
    }

    public void Interact()
    {
        Debug.Log("interact (player)");
        if(mFocus != null)
        {
            if (CheckEquipItem())
            {
                InteractAction();
                mFocus.Interact();
            }
            else
            {
                Debug.Log("Interaction tool mismatch");
            }
        }
    }

    public bool CheckEquipItem()
    {

        if (mEquipToolId == mFocus.GetAvailableToolId())
        {
            return true;
        }
        else
        {
            Debug.LogFormat("tool id : {0}가 필요합니다.", mFocus.GetAvailableToolId());
            return false;
        }

    }

    public void InteractAction()
    {
        
        Interactable.Type type = mFocus.GetInteractionType();

        switch (type)
        {
            case Interactable.Type.Farming:
                mAnim.SetTrigger("Farming");
                break;
            case Interactable.Type.Fishing:
                mState = State.Fishing;
                mAnim.SetTrigger("Fishing");
                break;
            case Interactable.Type.Mining:
                mAnim.SetTrigger("Mining");
                break;
            case Interactable.Type.Crafting:
                mAnim.SetTrigger("Hammering");
                break;
            case Interactable.Type.Gathering:
                mAnim.SetTrigger("Gathering");
                break;
            case Interactable.Type.Picking:
                //mAnim.SetTrigger("Gathering");
                break;
        }
    }



    //public void InteractionAction()
    //{
    //    Interaction interaction = mDetectedObject.GetComponent<Interaction>();
    //    Interaction.Type type = interaction.GetInteractionType();

    //    switch(type)
    //    {
    //        case Interaction.Type.Farming:
    //            mAnim.SetTrigger("Farming");
    //            break;
    //        case Interaction.Type.Fishing:
    //            mState = State.Fishing;
    //            mAnim.SetTrigger("Fishing");
    //            break;
    //        case Interaction.Type.Mining:
    //            mAnim.SetTrigger("Mining");
    //            break;
    //        case Interaction.Type.Crafting:
    //            mAnim.SetTrigger("Hammering");
    //            break;
    //        case Interaction.Type.Gathering:
    //            mAnim.SetTrigger("Gathering");
    //            break;
    //    }
    //}


    public void ItemPickUp()
    {
        if (mPickUpItem != null)
        {
            Item item = mPickUpItem.GetComponent<Item>();
            item.PickUp(mPickItemPos);
            //mItemList.Add(item);
            Inventory.Instance.Add(item.GetItemData());
            mState = State.Carry;
           
        
            //mIsCarryItem = true;
        }
    }

    public void UnEquipItem()
    {
        if (mEquipTool != null)
        {
            mEquipToolId = -1;
            UIManager.Instance.EquipToolChange(mEquipToolId);
            DataManager.instance.SetPlayerEquipItem(mEquipToolId);
            mEquipTool.SetActive(false);
            mEquipTool = null;
        }
    }

    public void ItemPutDown()
    {
        if(mPickUpItem != null)
        {
            Vector3 dropPos = mPickItemPos.position;
            Item item = mPickUpItem.GetComponent<Item>();
            //mItemList.Remove(item);
            Inventory.Instance.Remove(item.GetItemData());
            item.Drop(dropPos);
            mState = State.None;
            //mIsCarryItem = false;
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


    private void OnTriggerStay(Collider other)
    {
    
        if (other.gameObject.CompareTag("Tool"))
        {
            mDetectedObject = other.gameObject;
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Tool"))
        {
            mDetectedObject = null;
        }


    }

    public void ToolTriggerEnableOn()
    {
        mEquipToolCollider.enabled = true;
    }

    public void ToolTriggerEnableOff()
    {
        mEquipToolCollider.enabled = false;
    }

    public void GatheringItem()
    {
        if(mGatheringItem != null)
        {

            Item item = mGatheringItem.GetComponent<Item>();
            item.PickUp(mPickItemPos);
            item.gameObject.SetActive(true);

            //mItemList.Add(item);
            Inventory.Instance.Add(item.GetItemData());

            mState = State.Carry;
        }
    }

    public void SetGatheringItem(GameObject item)
    {
        item.SetActive(false);

        mGatheringItem = item;
    }
    public Transform GetHandPos()
    {
        return mPickItemPos;
    }
}
