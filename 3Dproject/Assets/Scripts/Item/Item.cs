using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum Type { Equipment, Item }
    public Type mType;


    [SerializeField]
    private ItemData mItemData;


    public Type GetItemType()
    {
        return mType;
    }




    public ItemData GetItemData()
    {
        return mItemData;   
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
        Collider[] itemColliders = transform.GetComponents<Collider>();
        Rigidbody itemRigid = transform.GetComponent<Rigidbody>();
        for (int i = 0; i < itemColliders.Length; i++)
        {
            itemColliders[i].enabled = !isCarryItem;
        }
       
        itemRigid.isKinematic = isCarryItem;
    }

}
