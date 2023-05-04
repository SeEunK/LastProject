using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    private int mInventoryCount = 20;
    public List<ItemData>  mItems= new List<ItemData>();

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

    }
    public bool Add(ItemData item)
    {
        if (!item.mIsDefaultItem)
        {
            if(mItems.Count >= mInventoryCount)
            {
                return false;
            }
            mItems.Add(item);

            if(onItemChangedCallback != null)
            {
                onItemChangedCallback.Invoke();
            }
        }
        return true;
    }
    public void Remove(ItemData item)
    {
        mItems.Remove(item);
        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }
    }
}
