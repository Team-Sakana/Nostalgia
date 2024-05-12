using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TalkBackGroundManager : MonoBehaviour
{
    [Header("대사 백그라운드, 명찰 백그라운드")] 
    public CanvasRenderer BackGround;
    public GameObject BackGroundButton;
    public CanvasRenderer BackgroundText;
    public CanvasRenderer Namepad;
    public CanvasRenderer NamepadText;
    private bool isInvisible = true;

    [Header("인/아웃 시간")] 
    public float t;

    private void Start()
    {
        BackGround.SetAlpha(0f);
        Namepad.SetAlpha(0f);
        BackgroundText.SetAlpha(0f);
        NamepadText.SetAlpha(0f);
    }

    public void TalkBackGroundSet()
    {
        if (isInvisible)
        {
            isInvisible = false;
            StartCoroutine("InBackGround");
        }
        else
        {
            isInvisible = true;
            StartCoroutine("OutBackGround");
        }
    }

    private IEnumerator OutBackGround()
    {
        float eslerpT = 0f;
        while (eslerpT < t)
        {
            BackGround.SetAlpha(Mathf.Lerp(1f, 0f, eslerpT));
            Namepad.SetAlpha(Mathf.Lerp(1f, 0f, eslerpT));
            BackgroundText.SetAlpha(Mathf.Lerp(1f, 0f, eslerpT));
            NamepadText.SetAlpha(Mathf.Lerp(1f, 0f, eslerpT));
            eslerpT += Time.deltaTime;
            yield return null;
        }
        BackGround.SetAlpha(0f);
        Namepad.SetAlpha(0f);
        BackgroundText.SetAlpha(0f);
        NamepadText.SetAlpha(0f);
        yield break;
    }
    private IEnumerator InBackGround()
    {
        float eslerpT = 0f;
        while (eslerpT < t)
        {
            BackGround.SetAlpha(Mathf.Lerp(0f, 1f, eslerpT));
            Namepad.SetAlpha(Mathf.Lerp(0f, 1f, eslerpT));
            BackgroundText.SetAlpha(Mathf.Lerp(0f, 1f, eslerpT));
            NamepadText.SetAlpha(Mathf.Lerp(0f, 1f, eslerpT));
            eslerpT += Time.deltaTime;
            yield return null;
        }
        BackGround.SetAlpha(1f);
        Namepad.SetAlpha(1f);
        BackgroundText.SetAlpha(1f);
        NamepadText.SetAlpha(1f);
        yield break;
    }
}