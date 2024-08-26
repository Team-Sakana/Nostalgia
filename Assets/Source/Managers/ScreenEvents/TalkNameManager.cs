using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace Source.Managers.ScreenEvents
{
    public class TalkNameManager : MonoBehaviour
    {
        [FormerlySerializedAs("NamePad")] public TMP_Text namePad;

        public void ChangeName(string s)
        {
            namePad.text = s;
        }
    }
}
