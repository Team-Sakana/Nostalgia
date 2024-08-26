using UnityEngine;

namespace Source.Managers
{
    public class DateManager : MonoBehaviour
    {
        public static void DPlus()
        {
            switch (SaveManager.SaveData.MM)
            {
                case 1 or 3 or 5 or 7 or 8 or 10 or 12 when SaveManager.SaveData.DD==31:
                    SaveManager.SaveData.DD = 1;
                    SaveManager.SaveData.MM++;
                    break;
                case 4 or 6 or 9 or 11 when SaveManager.SaveData.DD==30:
                    SaveManager.SaveData.DD = 1;
                    SaveManager.SaveData.MM++;
                    break;
                case 2 when SaveManager.SaveData.DD == 28:
                    SaveManager.SaveData.DD = 1;
                    SaveManager.SaveData.MM++;
                    break;
                default:
                    SaveManager.SaveData.DD++;
                    break;
            }
            if (SaveManager.SaveData.MM != 13) return;
            SaveManager.SaveData.MM = 1;
            SaveManager.SaveData.YYYY++;
        }
    }
}
