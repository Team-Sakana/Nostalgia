using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class setPlanDate : MonoBehaviour
{
    public TMP_Text YYYYMMDD;
    private DateManager DateManager = new DateManager();
    public void Start()
    {
        YYYYMMDD.text = $"{SaveManager.SaveData.YYYY}/{((SaveManager.SaveData.MM%10 == SaveManager.SaveData.MM) ? "0" + SaveManager.SaveData.MM : SaveManager.SaveData.MM)}/{((SaveManager.SaveData.DD%10 == SaveManager.SaveData.DD) ? "0" + SaveManager.SaveData.DD : SaveManager.SaveData.DD)}";
    }

    public void click()
    {
        DateManager.Dplus();
        YYYYMMDD.text = $"{SaveManager.SaveData.YYYY}/{((SaveManager.SaveData.MM%10 == SaveManager.SaveData.MM) ? "0" + SaveManager.SaveData.MM : SaveManager.SaveData.MM)}/{((SaveManager.SaveData.DD%10 == SaveManager.SaveData.DD) ? "0" + SaveManager.SaveData.DD : SaveManager.SaveData.DD)}";
    }
}
