using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : MonoBehaviour
{
    #region Singleton

    public static EquipmentManager Instance;

    private void Awake()
    {
        Instance = this;
    }
    #endregion


    private Equipment[] mCurrentEquipment;

    private void Start()
    {
        int numSlots = System.Enum.GetNames(typeof(EquipmentSlot)).Length;
        mCurrentEquipment= new Equipment[numSlots];
    }

    public void Equip(Equipment newItem)
    {
        int slotIndex = (int)newItem.mEquipSlot;

        Equipment prevItem = null;

        if (mCurrentEquipment[slotIndex] != null) 
        {
            prevItem = mCurrentEquipment[slotIndex];
            Inventory.Instance.Add(prevItem);
        }
        mCurrentEquipment[slotIndex] = newItem;
    }

    public void UnEquip(int slotIndex)
    {
        if (mCurrentEquipment[slotIndex] != null)
        {
            Equipment prevItem = mCurrentEquipment[slotIndex];
            Inventory.Instance.Add(prevItem);

            mCurrentEquipment[slotIndex] = null;
        }
    }

    public void UnEquipAll()
    {
        for(int i = 0; i < mCurrentEquipment.Length; i++)
        {
            UnEquip(i);
        }
    }

}
