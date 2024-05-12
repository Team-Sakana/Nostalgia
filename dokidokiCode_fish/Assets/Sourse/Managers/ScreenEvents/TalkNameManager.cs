using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TalkNameManager : MonoBehaviour
{
    public TMP_Text NamePad;

    public void ChangeName(string name)
    {
        NamePad.text = $"{name}";
    }
}
