using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    
    public enum Type { Mining, Fishing, Farming, Gathering, Crafting }

    [SerializeField]
    private Type mType;

    [SerializeField] 
    private int mAvailableToolId = -1;

    public GameObject[] mHasObjects = null;
   


    public Type GetInteractionType()
    {
        return mType;
    }

    public int GetAvailableToolId() 
    { 
        return mAvailableToolId; 
    }




}
