using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image mIcon;
    public Button mRemoveButton;
    private ItemData mItem;


    public void AddItem(ItemData newItem)
    {
        mItem= newItem;
        mIcon.sprite = mItem.mIcon;
        mIcon.enabled= true;
        mRemoveButton.interactable = true;
    }

    public void ClearSlot()
    {
        mItem = null;
        mIcon.sprite = null;
        mIcon.enabled= false;
        mRemoveButton.interactable = false;
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
