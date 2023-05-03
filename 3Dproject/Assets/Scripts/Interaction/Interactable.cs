using UnityEngine;

public class Interactable : MonoBehaviour
{
    public enum Type { Mining, Fishing, Farming, Gathering, Crafting, Picking}

    [SerializeField]
    private Type mType;

    [SerializeField]
    private float mRadius = 1.5f;
    public Transform mInteractionTransform = null;

    private bool mIsFocus = false;
    private bool mHasInteracted = false;
    public Transform mPlayer;

    [SerializeField]
    private bool mIsRequiredIdCheck = false;
    [SerializeField]
    private int mAvailableToolId = -1;

    private void Awake()
    {
       if(mAvailableToolId != -1)
        {
            mIsRequiredIdCheck = true;
        }
    }

    private void Update()
    {
        if(mIsFocus && !mHasInteracted)
        {
            float distance = Vector3.Distance(mPlayer.position, mInteractionTransform.position);
            if(distance <= mRadius)
            {
                Interact();
               
                mHasInteracted = true;
            }
        }
    }



    public virtual void Interact()
    {
        //Debug.Log("interaction with "+ transform.name);

    }

    public bool IsRequiredIdCheck()
    {
        return mIsRequiredIdCheck;
    }

    public void OnFocused(Transform playerTransform)
    {
        mIsFocus = true;
        mPlayer = playerTransform;
        mHasInteracted = false;
    }

    public void OnDefocused()
    {
        mIsFocus= false;
        mPlayer= null;
        mHasInteracted = false;
    }

   
    public Transform GetInteractionTransform() 
    { 
        return mInteractionTransform; 
    }
    public Type GetInteractionType()
    {
        return mType;
    }

    public int GetAvailableToolId()
    {
        return mAvailableToolId;
    }

    public float GetInteractRadius()
    {
        return mRadius;
    }

    private void OnDrawGizmosSelected()
    {
        if(mInteractionTransform == null)
        {
            mInteractionTransform = transform;
        }
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(mInteractionTransform.position, mRadius);
    }
}
