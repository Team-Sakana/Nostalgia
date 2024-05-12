using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft;
public class DateManager : MonoBehaviour
{
    public void Dplus()
    {
        if ((SaveManager.SaveData.MM == 1 || SaveManager.SaveData.MM == 3 ||SaveManager.SaveData.MM == 5 || SaveManager.SaveData.MM == 7 || SaveManager.SaveData.MM == 8 || SaveManager.SaveData.MM == 10 || SaveManager.SaveData.MM == 12)&&SaveManager.SaveData.DD==31)
        {
            SaveManager.SaveData.DD = 1;
            SaveManager.SaveData.MM++;
        }
        else if((SaveManager.SaveData.MM == 4||SaveManager.SaveData.MM == 6||SaveManager.SaveData.MM == 9||SaveManager.SaveData.MM == 11)&&SaveManager.SaveData.DD==30)
        {
            SaveManager.SaveData.DD = 1;
            SaveManager.SaveData.MM++;
        }
        else if (SaveManager.SaveData.MM == 2 && SaveManager.SaveData.DD == 28)
        {
            SaveManager.SaveData.DD = 1;
            SaveManager.SaveData.MM++;
        }
        else
        {
            SaveManager.SaveData.DD++;
        }
        if (SaveManager.SaveData.MM == 13)
        {
            SaveManager.SaveData.MM = 1;
            SaveManager.SaveData.YYYY++;
        }
    }
}
