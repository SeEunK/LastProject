using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public enum EquipmentSlot { Head, Chest, Feet, Weapon, Tool}

[CreateAssetMenu(fileName ="New Equipment", menuName = "Equipment")]
public class Equipment : ItemData
{

    public EquipmentSlot mEquipSlot;

    public int mArmorModifier;
    public int mDamageModifier;
    public int mToolId;

    public override void Use()
    {
        base.Use();
        EquipmentManager.Instance.Equip(this);
        RemoveFromInventory();
    }

    public int GetToolId()
    {
        return mToolId;
    }


}

