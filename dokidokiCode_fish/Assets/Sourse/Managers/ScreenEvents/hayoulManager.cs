using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hayoulManager : MonoBehaviour
{
    [Header("하율")]
    public Animator Hayulanim;
    public GameObject hayul;
    public Texture DarkHayoul;
    public Texture hayoul;
    public void beDark()
    {
        hayul.GetComponent<RawImage>().texture = DarkHayoul;
    }

    public void beLight()
    {
        hayul.GetComponent<RawImage>().texture = hayoul;
    }
    public void HayoulTalkOut()
    {
        
        Hayulanim.Play("HayoulNotTalk");
    }
    public void HayoulTalkIn()
    {
        Hayulanim.Play("HayulTalk");
    }

    public void HayoulGetOut()
    {
        Hayulanim.Play("HayoulGetOut");
    }
    
    public void HayoulGetIn()
    {
        Hayulanim.Play("HayoulGetIn");
    }
}
