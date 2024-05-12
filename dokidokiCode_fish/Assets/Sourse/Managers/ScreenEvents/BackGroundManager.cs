using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGroundManager : MonoBehaviour
{
    [Header("BackGround")]
    public GameObject BackGround;
    public Texture[] IMGs;
    //public float ChangeBackGroundTime;//추후추가

    public enum BackGroundImgs
    {
        Station,
        street,
        StreetFrontMension,
        Bakery,
        Kitchin
    }
    void Start()
    {
        BackGround.GetComponent<RawImage>().texture = IMGs[(int)BackGroundImgs.Station];
    }
    public void changeImg(BackGroundImgs whatimg)
    {
        BackGround.GetComponent<RawImage>().texture = IMGs[(int)whatimg];
    }
    public void changeImg(BackGroundImgs whatimg,float WaitingTime)
    {
        StartCoroutine(waitingtime(WaitingTime, whatimg));
    }

    IEnumerator waitingtime(float waitingtime,BackGroundImgs img)
    {
        float esleaptime = 0f;
        while (esleaptime <= waitingtime)
        {
            esleaptime += Time.deltaTime;
            yield return null;
        }
        BackGround.GetComponent<RawImage>().texture = IMGs[(int)img];
    }
}
