using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;

using Newtonsoft.Json;
public static class PlayerData
{
    public class Data
    {
        public bool isfirst = true;
        public int money = 1000;
        public float Power = 3f;
        public float Gamed = 5f;
        public float HP = 100f;
        public int YYYY = 2025;
        public int MM = 3;
        public int DD = 8;
    }
    public static void SaveInSlot1(Data Savefile)
    {
        FileStream stream = new FileStream(Application.dataPath + "/SaveFile1.json", FileMode.OpenOrCreate);
        string jsonData = JsonConvert.SerializeObject(Savefile);
        byte[] data = Encoding.UTF8.GetBytes(jsonData);
        stream.Write(data, 0, data.Length);
        stream.Close();
    }

    public static void SaveInSlot2(Data Savefile)
    {
        FileStream stream = new FileStream(Application.dataPath + "/SaveFile2.json", FileMode.OpenOrCreate);
        string jsonData = JsonConvert.SerializeObject(Savefile);
        byte[] data = Encoding.UTF8.GetBytes(jsonData);
        stream.Write(data, 0, data.Length);
        stream.Close();
    }

    public static void SaveInSlot3(Data Savefile)
    {
        FileStream stream = new FileStream(Application.dataPath + "/SaveFile3.json", FileMode.OpenOrCreate);
        string jsonData = JsonConvert.SerializeObject(Savefile);
        byte[] data = Encoding.UTF8.GetBytes(jsonData);
        stream.Write(data, 0, data.Length);
        stream.Close();
    }

    public static PlayerData.Data LoadSlot1()
    {
        FileStream stream = new FileStream(Application.dataPath + "/SaveFile1.json", FileMode.Open);
        byte[] data = new byte[stream.Length];
        stream.Read(data, 0, data.Length);
        stream.Close();
        string jsonData = Encoding.UTF8.GetString(data);
        return JsonConvert.DeserializeObject<PlayerData.Data>(jsonData);
    }

    public static PlayerData.Data LoadSlot2()
    {
        FileStream stream = new FileStream(Application.dataPath + "/SaveFile2.json", FileMode.Open);
        byte[] data = new byte[stream.Length];
        stream.Read(data, 0, data.Length);
        stream.Close();
        string jsonData = Encoding.UTF8.GetString(data);
        return JsonConvert.DeserializeObject<PlayerData.Data>(jsonData);
    }

    public static PlayerData.Data LoadSlot3()
    {
        FileStream stream = new FileStream(Application.dataPath + "/SaveFile3.json", FileMode.Open);
        byte[] data = new byte[stream.Length];
        stream.Read(data, 0, data.Length);
        stream.Close();
        string jsonData = Encoding.UTF8.GetString(data);
        return JsonConvert.DeserializeObject<PlayerData.Data>(jsonData);
    }
}
