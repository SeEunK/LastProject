using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestUI : MonoBehaviour
{

    StorageObject mStorage;
    public Transform mChestSlotGrid;
    private ChestSlot[] mSlots;


 
    void Start()
    {
         
        mStorage.onStorageItemChangedCallback += UpdateUI;
        mSlots = mChestSlotGrid.GetComponentsInChildren<ChestSlot>();
        if (mStorage.mStorageItems.Count > 0)
        {
            UpdateUI();
        }

    }
    public void SetChestUI(StorageObject storage)
    {
        Debug.Log("Set chest UI");
        mStorage = storage;
    
    }

    public GameObject GetStorageObject()
    {

        return mStorage.gameObject;
    }



    void UpdateUI()
    {

        for (int i = 0; i < mSlots.Length; i++)
        {
            if (i < mStorage.mStorageItems.Count)
            {
                mSlots[i].AddItem(mStorage.mStorageItems[i]);
            }
            else
            {
                mSlots[i].ClearSlot();
            }
        }
    }


    public void OnCloseChestUI()
    {
        if (UIManager.Instance.IsItemInfoPopupOpen())
        {
            UIManager.Instance.ItemInfoPopupClose();
        }
        mStorage.CloseAnimPlay();
        this.gameObject.SetActive(false);
    }
}
