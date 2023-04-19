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


    public void PickUp(Transform pickPos)
    {
        this.transform.SetParent(pickPos);
        this.transform.localPosition = Vector3.zero;
        this.transform.rotation = new Quaternion(0, 0, 0, 0);
        SetCarryItem(true);
    }

    public void Drop(Vector3 dropPos)
    {
        this.transform.SetParent(null);
        this.transform.position = dropPos;
       SetCarryItem(false);
        
    }

    public void SetCarryItem(bool isCarryItem)
    {
        Collider itemCollider = transform.GetComponent<Collider>();
        Rigidbody itemRigid = transform.GetComponent<Rigidbody>();
        itemCollider.enabled = !isCarryItem;
        itemRigid.isKinematic = isCarryItem;
    }

}
