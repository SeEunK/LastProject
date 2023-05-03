using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    //Inventory mInventory;

    public Transform mInventoryGrid;

    private InventorySlot[] mSlots;

    void Start()
    {
        Inventory.Instance.onItemChangedCallback += UpdateUI;
        mSlots = mInventoryGrid.GetComponentsInChildren<InventorySlot>();
    }
  

    void UpdateUI()
    {
        for(int i = 0; i < mSlots.Length; i++)
        {
            if(i < Inventory.Instance.mItems.Count)
            {
                mSlots[i].AddItem(Inventory.Instance.mItems[i]);
            }
            else
            {
                mSlots[i].ClearSlot();
            }
        }

    }
}
