using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static UnityEditor.Experimental.GraphView.GraphView;

public class ItemInfoUI : MonoBehaviour
{
    public enum Type { None, Use, Get};
    public Type mType;
    private ItemData mItem;

    public Image mItemIcon;
    public TMP_Text mItemName;
    public TMP_Text mItemType;
    public TMP_Text mItemDesc;

    public GameObject mButtonObject;
    public TMP_Text mButtonText;

    // 팝업을 호출한 게임오브젝트
    private GameObject mPopupOpenPath;

    public void SetItemInfo(ItemData item, Type type, GameObject openPath)
    {
        mItem = item;
        mType = type;
        mPopupOpenPath = openPath;

        mItemIcon.sprite = mItem.mIcon;
        mItemName.text = mItem.mName;
        mItemType.text = mItem.GetItemType().ToString();
        mItemDesc.text = "desc";

       switch (mType)
        {
            case Type.Use:
                mButtonText.text = "USE";
                break; 
            case Type.Get:
                mButtonText.text = "GET";
                break; 
            case Type.None:
                mButtonObject.SetActive(false);
                break;
        }
    }

    public void OnClosePopup()
    {
        this.gameObject.SetActive(false);
    }

    public void OnClickButton()
    {

        switch (mType)
        {
            case Type.Use:
                mItem.Use();
                break;
                

            case Type.Get:
                ItemMoveToInventory();
                break;
        }
                OnClosePopup();
    }

    public void ItemMoveToInventory()
    {
        bool isAddComplete = Inventory.Instance.Add(mItem);
     
        if (isAddComplete)
        {
            // mPopupOpenPath. 
            Debug.LogFormat("info 팝업을 호출한 대상 : {0} 에서 item 제거 !", mPopupOpenPath.name);
        }
        else
        {
            Debug.Log("inventory full!!!");
        }
    }
}
