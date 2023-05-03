using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
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


    public delegate void OnEquipmentChanged(Equipment newItem, Equipment prevItem);
    public OnEquipmentChanged onEquipmentChanged;

    private void Start()
    {
        int numEquipSlots = System.Enum.GetNames(typeof(EquipmentSlot)).Length;
        mCurrentEquipment= new Equipment[numEquipSlots];
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

        if(onEquipmentChanged!= null)
        {
            onEquipmentChanged.Invoke(newItem, prevItem);
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

            if (onEquipmentChanged != null)
            {
                onEquipmentChanged.Invoke(null, prevItem);
            }

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
