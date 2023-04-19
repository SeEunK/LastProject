using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum Type { Tool, Item }
    public Type mType;
    [SerializeField]
    private int mId = -1;


    public Type GetItemType()
    {
        return mType;
    }


    public int GetItemId() 
    { 
        return mId; 
    }
         
}
