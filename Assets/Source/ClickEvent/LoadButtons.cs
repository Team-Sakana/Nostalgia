using Source.Managers;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace Source.ClickEvent
{
    public class LoadManager : MonoBehaviour
    {
        [FormerlySerializedAs("LoadGrounds")] public GameObject loadGrounds;
        [FormerlySerializedAs("Savefile1EX")] public TMP_Text saveFile1Ex;
        [FormerlySerializedAs("Savefile2EX")] public TMP_Text saveFile2Ex;
        [FormerlySerializedAs("Savefile3EX")] public TMP_Text saveFile3Ex;
        [FormerlySerializedAs("ChoiceFileInfo")] public TMP_Text choiceFileInfo;
        public void LoadLoadButton()
        {
            loadGrounds.SetActive(true);
        }

        public void UnLoadButton()
        {
            loadGrounds.SetActive(false);
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
}
