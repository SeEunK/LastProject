using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float mRadius = 1.5f;
    public Transform mInteractionTransform = null;

    private bool mIsFocus = false;
    private bool mHasInteracted = false;
    private Transform mPlayer;

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
        Debug.Log("interaction with "+ transform.name);
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

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(mInteractionTransform.position, mRadius);
    }
}
