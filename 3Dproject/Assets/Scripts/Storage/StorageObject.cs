using System.Collections.Generic;
using UnityEngine;


public class StorageObject : Interactable
{
    private int mStorageCount = 15;
    public List<ItemData> mStorageItems = new List<ItemData>();

    public delegate void OnStorageItemChanged();
    public OnStorageItemChanged onStorageItemChangedCallback;

    public Animator mAnimator;


    private void Awake()
    {
        CloseAnimPlay();
        
    }
    public bool Add(ItemData item)
    {
        if (!item.mIsDefaultItem)
        {
            if (mStorageItems.Count >= mStorageCount)
            {
                return false;
            }
            mStorageItems.Add(item);

            if (onStorageItemChangedCallback != null)
            {
                onStorageItemChangedCallback.Invoke();
            }
        }
        return true;
    }
    public void Remove(ItemData item)
    {
        mStorageItems.Remove(item);
        if (onStorageItemChangedCallback != null)
        {
            onStorageItemChangedCallback.Invoke();
        }
    }

    public override void Interact()
    {
        base.Interact();

        OpenAnimPlay();
        UIManager.Instance.ChestUIOpen(this);

    }

    public void CloseAnimPlay()
    {
        Debug.Log("close anim play");
        mAnimator.SetTrigger("ChestClose");
    }
    public void OpenAnimPlay()
    {
        mAnimator.SetTrigger("ChestOpen");
    }

}
