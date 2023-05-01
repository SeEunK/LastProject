using UnityEngine;


[CreateAssetMenu(fileName ="New Item", menuName ="ItemData")]
public class ItemData : ScriptableObject
{

    public string mName = "New Item";
    public Sprite mIcon = null;
    public bool mIsDefaultItem = false;


    public virtual void Use() 
    {
        Debug.Log("item use "+ mName);
    }

    public void RemoveFromInventory()
    {
        Inventory.Instance.Remove(this);
    }
}
