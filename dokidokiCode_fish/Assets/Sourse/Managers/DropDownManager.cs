using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDownManager : MonoBehaviour
{
    public GameObject halfFade;//On시 켜지는 창 뒤쪽 전체 버튼
    public Animator dropdownanim;
    public Animator DButtonanim;
    private bool itsDropped = false;

    public void getDrop()
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
        halfFade.SetActive(true);
        dropdownanim.Play("DropdownAnim");
        DButtonanim.Play("dropButtonOn");
    }

    private void GetUp()
    {
        halfFade.SetActive(false);
        dropdownanim.Play("DropUp");
        DButtonanim.Play("dropButtonOff");
    }
}
