using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField]
    private Sprite[] mTools = null;
    public Sprite mEmpty = null;

    public Image mEquipTool = null;

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

    public void Init()
    {
        mTools = Resources.LoadAll<Sprite>("Sprite/IconTools");
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

    
}
