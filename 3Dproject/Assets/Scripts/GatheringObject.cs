using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatheringObject : MonoBehaviour
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
    public enum State { None, Empty, Full, Grow }
    [SerializeField]
    private State mState;

    private void Awake()
    {
        mState = State.Full;
        mResultItemCount = mResultItemMaxCount;
        mRenderer = GetComponent<MeshRenderer>();
        mCollider = GetComponent<Collider>();
    }
    private void Update()
    {

        if (mState == State.Full)
        {
            return;
        }


        if (mState == State.Empty)
        {
            mRenderer.enabled = false;
            mCollider.enabled = false;
            SetState(State.Grow);
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
                    mRenderer.enabled = true;
                    mCollider.enabled = true;

                }
                if (mResultItemCount == mResultItemMaxCount)
                {
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


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (mResultItemCount > 0)
            {
                if (mResultItem != null)
                {
                    Vector3 newPos = other.GetComponent<PlayerController>().GetHandPos().position;
                    Instantiate(mResultItem, newPos, transform.rotation);
                    other.GetComponent<PlayerController>().SetGatheringItem(gameObject);

                    
                }
                mResultItemCount -= 1;

                if (mResultItemCount == 0)
                {
                    SetState(State.Empty);
                }

            }

        }
    }
}
