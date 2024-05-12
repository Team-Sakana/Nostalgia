using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using Newtonsoft.Json;
using UnityEngine.SceneManagement;

public class FirstJoinClickScenes : MonoBehaviour
{
   public void JoinButton()
   {
      FileInfo save1 = new FileInfo(Application.dataPath + "/SaveFile1.json");
      FileInfo save2 = new FileInfo(Application.dataPath + "/SaveFile2.json");
      FileInfo save3 = new FileInfo(Application.dataPath + "/SaveFile3.json");
      if (!save1.Exists && !save2.Exists && !save3.Exists)
      {
         PlayerData.Data a = new PlayerData.Data();
         Debug.Log(a.isfirst);
         PlayerData.SaveInSlot1(a);
         SaveManager.SaveData = PlayerData.LoadSlot1();
         Debug.Log(SaveManager.SaveData.isfirst);
         SceneManager.LoadScene("Play");
      }
      else
      {
         SceneManager.LoadScene("Scene_Zero");
      }
   }
}
