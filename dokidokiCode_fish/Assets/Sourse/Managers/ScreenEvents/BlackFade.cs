using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using Color = System.Drawing.Color;

public class BlackFade : MonoBehaviour
{
    [Header("페이드 진행속도")] public float FadeTime;
    [Header("Blackfade 개체")] public GameObject blackFade;
    private Action onComplateCallback;

    public GameObject Dbutton;
    public GameObject Pbutton;
    private void Start()
    {
        if (!blackFade)
        {
            Debug.Log("BlackFade 개체를 찾지 못함");
            throw new MissingComponentException();
        }
    }

    IEnumerator BlackFadeOut(float term)
    {
        blackFade.SetActive(true);
        Dbutton.SetActive(false);
        Pbutton.SetActive(false);
        float elapsedTime = 0f;
        while (elapsedTime <= FadeTime)
        {
            blackFade.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(0f, 1f, elapsedTime / FadeTime));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        yield return new WaitForSeconds(term);
        elapsedTime = 0f;
        while (elapsedTime <= FadeTime)
        {
            blackFade.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(1f, 0f, elapsedTime / FadeTime));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        blackFade.SetActive(false);
        Pbutton.SetActive(true);
        Dbutton.SetActive(true);
    }

    public void RegisterCallback(Action callback)
    {
        onComplateCallback = callback;
    }

    IEnumerator StartFade(float term)
    {
        float elapsedTime = 0f;
        blackFade.SetActive(true);
        Pbutton.SetActive(false);
        Dbutton.SetActive(false);
        while (elapsedTime <= FadeTime)
        {
            blackFade.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(1f, 0f, elapsedTime / FadeTime));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        blackFade.SetActive(false);
        Dbutton.SetActive(true);
        Pbutton.SetActive(true);
        yield break;
    }
}
