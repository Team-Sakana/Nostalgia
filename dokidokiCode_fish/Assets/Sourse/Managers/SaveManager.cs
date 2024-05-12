using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using Newtonsoft.Json;
public static class SaveManager
{
    public static PlayerData.Data SaveData;

    public static void SetDefaultInfo1()
    {
        SaveData = PlayerData.LoadSlot1(); 
        SaveData.isfirst = true;
        SaveData.money = 1000;
        SaveData.Power = 10f;
        SaveData.Gamed = 5f;
        SaveData.HP = 100f;
        SaveData.YYYY = 2024;
        SaveData.MM = 03;
        SaveData.DD = 12;
        PlayerData.SaveInSlot1(SaveData);
    }
    public static void SetDefaultInfo2()
    {
        SaveData = PlayerData.LoadSlot2(); 
        SaveData.isfirst = true;
        SaveData.money = 1000;
        SaveData.Power = 10f;
        SaveData.Gamed = 5f;
        SaveData.HP = 100f;
        SaveData.YYYY = 2024;
        SaveData.MM = 03;
        SaveData.DD = 12;
        PlayerData.SaveInSlot2(SaveData);
    }
    public static void SetDefaultInfo3()
    {
        SaveData = PlayerData.LoadSlot3(); 
        SaveData.isfirst = true;
        SaveData.money = 1000;
        SaveData.Power = 10f;
        SaveData.Gamed = 5f;
        SaveData.HP = 100f;
        SaveData.YYYY = 2024;
        SaveData.MM = 03;
        SaveData.DD = 12;
        PlayerData.SaveInSlot3(SaveData);
    }
}
