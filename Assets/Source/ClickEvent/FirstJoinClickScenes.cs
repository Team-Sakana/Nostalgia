using System.IO;
using Source.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Source.ClickEvent
{
   public class FirstJoinClickScenes : MonoBehaviour
   {
      public void JoinButton()
      {
         var save1 = new FileInfo(Application.dataPath + "/SaveFile1.json");
         var save2 = new FileInfo(Application.dataPath + "/SaveFile2.json");
         var save3 = new FileInfo(Application.dataPath + "/SaveFile3.json");
         if (!save1.Exists && !save2.Exists && !save3.Exists)
         {
            var a = new PlayerData.Data();
            Debug.Log(a.IsFirst);
            PlayerData.SaveInSlot1(a);
            SaveManager.SaveData = PlayerData.LoadSlot1();
            Debug.Log(SaveManager.SaveData.IsFirst);
            SceneManager.LoadScene("Play");
         }
         else
         {
            SceneManager.LoadScene("Scene_Zero");
         }
      }
   }
}
