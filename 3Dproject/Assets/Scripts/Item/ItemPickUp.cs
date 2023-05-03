using UnityEngine;

public class ItemPickUp : Interactable
{
    [SerializeField]
    private ItemData mItemData;
    public override void Interact()
    {
        base.Interact();
        PickUp();
    }

    public void PickUp()
    {
        Debug.Log("PickUp!!!");

        bool isPickUpComplete = Inventory.Instance.Add(mItemData);

        if(mItemData.GetItemType() == ItemData.Type.Equipable)
        {
            Equipment equipableItem = (Equipment)mItemData;
           
            if(equipableItem.mEquipSlot == EquipmentSlot.Tool)
            {
                int toolIndex = equipableItem.GetToolId() - 1;
                PlayerController player = mPlayer.GetComponent<PlayerController>();
                player.SetHasTool(toolIndex, true);
            }
        }
        if (isPickUpComplete)
        {
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("inventory full!!!");
        }
    }

    public ItemData GetItemData()
    {
        return mItemData;
    }

}
