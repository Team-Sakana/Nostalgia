using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LoadManager : MonoBehaviour
{
    public GameObject LoadGrounds;
    public TMP_Text Savefile1EX;
    public TMP_Text Savefile2EX;
    public TMP_Text Savefile3EX;
    public TMP_Text ChoiceFileInfo;
    public void LoadloadButton()
    {
        LoadGrounds.SetActive(true);
    }

    public void UnLoadButton()
    {
        LoadGrounds.SetActive(false);
    }

    public void ClickFile1()
    {
        PlayerData.LoadSlot1();
    }
    public void ClickFile2()
    {
        
    }
    public void ClickFile3()
    {
        
    }
}
