using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.IO;



public class PlayerData
{
    public string name;
    public int level;
    public int coin;
    public int equipItem = -1;
    public List<ItemData> items = new List<ItemData>();
}

public class DataManager : MonoBehaviour
{

    public static DataManager instance;

    private PlayerData mNowPlayer = new PlayerData();
    public string mPath = string.Empty;
   

    public int mNowSlot;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        
        mPath = Application.persistentDataPath + "/Save";
        

    }

    private void Start()
    {
        
    }

    public void SaveData()
    {
        string data = JsonUtility.ToJson(mNowPlayer);
        File.WriteAllText(mPath + mNowSlot.ToString(), data);
    }

    public void LoadData()
    {
        string data = File.ReadAllText(mPath + mNowSlot.ToString());
        mNowPlayer = JsonUtility.FromJson<PlayerData>(data);
    }

    public void SetPlayerName(string name)
    {
        mNowPlayer.name = name;
    }

    public void SetPlayerEquipItem(int index)
    {
        mNowPlayer.equipItem = index;
    }

    public void SetPlayerItem(ItemData item)
    {
        mNowPlayer.items.Add(item);
    }

    public int GetPlayerEquipItem()
    {
        return mNowPlayer.equipItem;
    }


    public string GetPlayerName()
    {
        return mNowPlayer.name;
    }

    public void DataClear()
    {
        mNowSlot = -1;
        mNowPlayer = new PlayerData();
    }
}
