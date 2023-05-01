using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="New Equipment", menuName = "Equipment")]
public class Equipment : ItemData
{

    public EquipmentSlot mEquipSlot;

    public int mArmorModifier;
    public int mDamageModifier;

    public override void Use()
    {
        base.Use();
        EquipmentManager.Instance.Equip(this);
        RemoveFromInventory();
    }


}
public enum EquipmentSlot { Head, Chest, Feet, Weapon, Tool}
