using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Source.Managers.ScreenEvents
{
    public class HayoulManager : MonoBehaviour
    {
        [FormerlySerializedAs("Hayulanim")] [Header("하율")]
        public Animator hayulAni;
        public GameObject hayul;
        [FormerlySerializedAs("DarkHayoul")] public Texture darkHayoul;
        public Texture hayoul;
        public void BeDark()
        {
            hayul.GetComponent<RawImage>().texture = darkHayoul;
        }

        public void BeLight()
        {
            hayul.GetComponent<RawImage>().texture = hayoul;
        }
        public void HayoulTalkOut()
        {
        
            hayulAni.Play("HayoulNotTalk");
        }
        public void HayoulTalkIn()
        {
            hayulAni.Play("HayulTalk");
        }

        public void HayoulGetOut()
        {
            hayulAni.Play("HayoulGetOut");
        }
    
        public void HayoulGetIn()
        {
            hayulAni.Play("HayoulGetIn");
        }
    }
}
