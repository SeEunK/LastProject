using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using TMPro;


public class SelectSlot : MonoBehaviour
{
    public GameObject mCreatePopup;
    public TMP_Text[] mSlotText = null;
    public TMP_Text mNewPlayerName = null;

    private bool[] mSaveFile = new bool[3]; 

    private void Start()
    {
        for(int i = 0; i < mSlotText.Length; i++)
        {
            if (File.Exists(DataManager.instance.mPath + i))
            {
                mSaveFile[i]   = true;
                DataManager.instance.mNowSlot = i;
                DataManager.instance.LoadData();
                mSlotText[i].text = DataManager.instance.GetPlayerName();
            }
            else
            {
                mSlotText[i].text = "Empty";

            }
        }
        DataManager.instance.DataClear();
    }

    public void Slot(int index)
    {
        DataManager.instance.mNowSlot = index;

        // 저장된 데이터가 있을때.
        if (mSaveFile[index])
        {
            DataManager.instance.LoadData();
            LoadGameScene();

        }
        else
        {
            Create();
        }
       
        
    }

    public void Create()
    {
        mCreatePopup.gameObject.SetActive(true);
    }

    public void LoadGameScene()
    {
        if (!mSaveFile[DataManager.instance.mNowSlot])
        {
            DataManager.instance.SetPlayerName(mNewPlayerName.text);
            DataManager.instance.SaveData();
        }
        SceneManager.LoadScene("GameScene");
    }
}
