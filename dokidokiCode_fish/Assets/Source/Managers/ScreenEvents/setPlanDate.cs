using TMPro;
using UnityEngine;

namespace Source.Managers.ScreenEvents
{
    public class SetPlanDate : MonoBehaviour
    {
        public TMP_Text YYYYMMDD;
        private DateManager _dateManager = new();
        public void Start()
        {
            YYYYMMDD.text = $"{SaveManager.SaveData.YYYY}/{((SaveManager.SaveData.MM%10 == SaveManager.SaveData.MM) ? "0" + SaveManager.SaveData.MM : SaveManager.SaveData.MM)}/{((SaveManager.SaveData.DD%10 == SaveManager.SaveData.DD) ? "0" + SaveManager.SaveData.DD : SaveManager.SaveData.DD)}";
        }

        public void Click()
        {
            DateManager.DPlus();
            YYYYMMDD.text = $"{SaveManager.SaveData.YYYY}/{((SaveManager.SaveData.MM%10 == SaveManager.SaveData.MM) ? "0" + SaveManager.SaveData.MM : SaveManager.SaveData.MM)}/{((SaveManager.SaveData.DD%10 == SaveManager.SaveData.DD) ? "0" + SaveManager.SaveData.DD : SaveManager.SaveData.DD)}";
        }
    }
}
