using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField]
    private TMP_Text mPlayerName;

    [SerializeField]
    private Sprite[] mTools = null;
    public Sprite mEmpty = null;

    public Image mEquipTool = null;

    public GameObject mInventoryUI;

    public GameObject mItemInfoPopup;
    public GameObject mChest;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            Init();
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

    }

    private void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            mInventoryUI.SetActive(!mInventoryUI.activeSelf);
            
        }
    }
    public void Init()
    {
       
        mTools = Resources.LoadAll<Sprite>("Sprite/IconTools");
    }

    public void Start()
    {
        SetPlayerName(DataManager.instance.GetPlayerName());
        EquipToolChange((DataManager.instance.GetPlayerEquipItem()+1));
    }

    public void EquipToolChange(int toolId)
    {
        int toolIndex = -1;
        switch (toolId)
        {
            case 1:
                toolIndex = 3;
                break;
            case 2:
                toolIndex = 1;
                break;
            case 3:
                toolIndex = 0;
                break;
            case 4:
                toolIndex = 2;
                break;
            case -1:
                toolIndex = -1;
                break;

        }
        Debug.Log(toolIndex);
        if (toolIndex == -1)
        {
            mEquipTool.sprite = mEmpty;
        }
        else
        {
            mEquipTool.sprite = mTools[toolIndex];
        }
           
    }

    public void SetPlayerName(string name)
    {
        mPlayerName.text = name;
    }

    public void Save()
    {
        DataManager.instance.SaveData();
    }

    public bool IsInventoryUIOpen()
    {
        if (mInventoryUI.activeSelf)
        {
            return true;
        }
        return false;
    }

    public bool IsChestUIOpen()
    {
        if(mChest.activeSelf) 
        { 
            return true; 
        }
        return false;
    }

    public void ItemInfoPopupOpen(ItemData item, ItemInfoUI.Type type, GameObject openPath)
    {
        ItemInfoUI itemInfo = mItemInfoPopup.GetComponent<ItemInfoUI>();
        itemInfo.SetItemInfo(item, type, openPath);
        mItemInfoPopup.SetActive(true);
    }

    public void ChestUIOpen(StorageObject storage)
    {
        ChestUI chestUI = mChest.GetComponent<ChestUI>();
        chestUI.SetChestUI(storage);
        mChest.SetActive(true);
    }
}

