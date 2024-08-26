using System.IO;
using System.Text;
using Newtonsoft.Json;
using UnityEngine;

namespace Source.Managers
{
    public static class PlayerData
    {
        public class Data
        {
            public bool IsFirst = true;
            public int Money = 1000;
            public float Power = 3f;
            public float Gamed = 5f;
            public float HP = 100f;
            public int YYYY = 2025;
            public int MM = 3;
            public int DD = 8;
        }
        public static void SaveInSlot1(Data saveFile)
        {
            var stream = new FileStream(Application.dataPath + "/SaveFile1.json", FileMode.OpenOrCreate);
            var jsonData = JsonConvert.SerializeObject(saveFile);
            var data = Encoding.UTF8.GetBytes(jsonData);
            stream.Write(data, 0, data.Length);
            stream.Close();
        }

        public static void SaveInSlot2(Data saveFile)
        {
            var stream = new FileStream(Application.dataPath + "/SaveFile2.json", FileMode.OpenOrCreate);
            var jsonData = JsonConvert.SerializeObject(saveFile);
            var data = Encoding.UTF8.GetBytes(jsonData);
            stream.Write(data, 0, data.Length);
            stream.Close();
        }

        public static void SaveInSlot3(Data saveFile)
        {
            var stream = new FileStream(Application.dataPath + "/SaveFile3.json", FileMode.OpenOrCreate);
            var jsonData = JsonConvert.SerializeObject(saveFile);
            var data = Encoding.UTF8.GetBytes(jsonData);
            stream.Write(data, 0, data.Length);
            stream.Close();
        }

        public static Data LoadSlot1()
        {
            var stream = new FileStream(Application.dataPath + "/SaveFile1.json", FileMode.Open);
            var data = new byte[stream.Length];
            stream.Read(data, 0, data.Length);
            stream.Close();
            var jsonData = Encoding.UTF8.GetString(data);
            return JsonConvert.DeserializeObject<Data>(jsonData);
        }

        public static Data LoadSlot2()
        {
            var stream = new FileStream(Application.dataPath + "/SaveFile2.json", FileMode.Open);
            var data = new byte[stream.Length];
            stream.Read(data, 0, data.Length);
            stream.Close();
            var jsonData = Encoding.UTF8.GetString(data);
            return JsonConvert.DeserializeObject<Data>(jsonData);
        }

        public static Data LoadSlot3()
        {
            var stream = new FileStream(Application.dataPath + "/SaveFile3.json", FileMode.Open);
            var data = new byte[stream.Length];
            stream.Read(data, 0, data.Length);
            stream.Close();
            var jsonData = Encoding.UTF8.GetString(data);
            return JsonConvert.DeserializeObject<Data>(jsonData);
        }
    }
}
