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
