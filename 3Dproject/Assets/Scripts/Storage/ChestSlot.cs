
using UnityEngine;
using UnityEngine.UI;

public class ChestSlot : MonoBehaviour
{
    public Image mIcon;
    private ItemData mItem;


    public void AddItem(ItemData newItem)
    {
        mItem = newItem;
        mIcon.sprite = mItem.mIcon;
        mIcon.enabled = true;
    }

    public void ClearSlot()
    {
        mItem = null;
        mIcon.sprite = null;
        mIcon.enabled = false;
    }



    public void OnClickSlot()
    {
        if (mItem != null)
        {
            // open item info popup ui 
            UIManager.Instance.ItemInfoPopupOpen(mItem, ItemInfoUI.Type.Get, this.gameObject);
        }
    }
}
