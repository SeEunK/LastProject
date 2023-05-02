using UnityEditor;
using UnityEngine;

public class FarmingObject : Interactable
{
    public GameObject mResultItem = null;

    private Collider mCollider = null;
    private MeshRenderer mRenderer = null;

    [SerializeField]
    private int mResultItemMaxCount = 3;
    [SerializeField]
    private int mResultItemCount = 0;

    private float mRefilWaitTime = 30.0f;
    private float mTimer = 0.0f;
    public enum State { None, Empty, Full, Grow, Ready }
    [SerializeField]
    private State mState;

    [SerializeField]
    private GameObject[] mGrowObject = null;

    private int mMAxGrowStep = 0;
    private int mCurrGrowStep = 0;

    private void Awake()
    {
        mState = State.Empty;
        mResultItemCount = mResultItemMaxCount;
        mRenderer = GetComponent<MeshRenderer>();
        mCollider = GetComponent<Collider>();
        mMAxGrowStep = mGrowObject.Length;
    }
    private void Update()
    {

        if (mState == State.Full || mState== State.Ready)
        {
            return;
        }


        if (mState == State.Empty)
        {
            for(int i = 0; i< mMAxGrowStep; i++)
            {
                mGrowObject[i].SetActive(false);    
            }
        }
       
        if (mState == State.Grow)
        {
            if (mTimer < mRefilWaitTime)
            {
                mTimer += Time.deltaTime;
            }
            else
            {
                mResultItemCount += 1;
                
                if (mResultItemCount == 1)
                {

                    mGrowObject[mCurrGrowStep].SetActive(true);
                }
                if (mResultItemCount == mResultItemMaxCount)
                {
                    ++mCurrGrowStep;
                    mGrowObject[mCurrGrowStep].SetActive(true);
                    SetState(State.Full);
                }
                mTimer = 0.0f;
            }
        }


    }

    public void SetState(State state)
    {
        mState = state;
    }
    public GameObject GetResultItem()
    {
        return mResultItem;
    }

    public int GetResultItemCount()
    {
        return mResultItemCount;
    }
    public override void Interact()
    {

        switch (mState)
        {
            case State.Full:
                Debug.Log("Farming " + transform.name);

                if (mResultItemCount > 0)
                {
                    if (mResultItem != null)
                    {
                        Vector3 newPos = new Vector3(mPlayer.position.x + 1.0f, mPlayer.position.y + 1.0f, mPlayer.position.z + 1.0f);
                        Instantiate(mResultItem, newPos, transform.rotation);
                    }
                    mResultItemCount -= 1;

                    if (mResultItemCount == 0)
                    {
                        mCurrGrowStep = 0;
                        SetState(State.Empty);
                    }

                }
                break;
            case State.Empty:
                Debug.Log("Farming :step 1 " + transform.name);
                // use item seeds


                // renderer change
                mGrowObject[mCurrGrowStep].SetActive(true);

                // state  
                SetState(State.Ready);

                break;

           case State.Ready:
                Debug.Log("Farming :step 2 - start grow !!" + transform.name);

                mCurrGrowStep++;
                // state  
                SetState(State.Grow);
                break;

            case State.Grow:
                Debug.Log("Farming :step 3 - wait grow!!" + transform.name);
               
                break;

        }


    }
}
