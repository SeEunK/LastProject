
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName ="New ItemDataBase", menuName = "ItemDataBase")]

public class ItemDataBaseObject : ScriptableObject, ISerializationCallbackReceiver
{
    public ItemData[] Items;

    public Dictionary<ItemData, int> GetId = new Dictionary<ItemData, int>();
    public Dictionary<int, ItemData> GetItem = new Dictionary<int, ItemData>();


    // 직렬화 후 사용
    public void OnAfterDeserialize()
    {
        GetId = new Dictionary<ItemData, int>();
        for(int i = 0; i< Items.Length; i++)
        {
            GetId.Add(Items[i], i);
        }
    }

    public void OnBeforeSerialize()
    {
    }
}

