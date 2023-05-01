using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image mIcon;
    ItemData mItem;

    public void AddItem(ItemData newItem)
    {
       mItem= newItem;
        mIcon.sprite = mItem.mIcon;
        mIcon.enabled= true;

    }

    public void ClearSlot()
    {
        mItem = null;
        mIcon.sprite = null;
        mIcon.enabled= false;
    }

    public void OnRemoveButton()
    {
        Inventory.Instance.Remove(mItem);
    }

    public void UseItem()
    {
        if(mItem != null)
        {
            mItem.Use();
        }
    }
}
