using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneManager : MonoBehaviour
{
    public GameObject OnBG;//On시 켜지는 전체 버튼
    public Animator phoneanim;
    public Animator PButtonanim;
    private bool itsDropped = false;

    public void getPhone()
    {
        if (!itsDropped)
        {
            GetDown();
            itsDropped = true;
        }
        else
        {
            GetUp();
            itsDropped = false;
        }
    }
    private void GetDown()
    {
        OnBG.SetActive(true);
        phoneanim.Play("PhoneDown");
        PButtonanim.Play("PhoneButtonClick");
    }

    private void GetUp()
    {
        OnBG.SetActive(false);
        phoneanim.Play("PhoneUp");
    }
}
