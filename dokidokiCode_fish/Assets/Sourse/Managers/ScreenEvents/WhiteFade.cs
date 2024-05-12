using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteFade : MonoBehaviour
{
    [Header("페이드 진행속도")] public float FadeTime;
    [Header("Whitefade 개체")] public GameObject whiteFade;
    private Action onComplateCallback;

    private void Start()
    {
        if (!whiteFade)
        {
            Debug.Log("whiteFade 개체를 찾지 못함");
            throw new MissingComponentException();
        }
    }

    IEnumerator WhiteFadeOut(float term)
    {
        float elapsedTime = 0f;
        while (elapsedTime <= FadeTime)
        {
            whiteFade.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(0f, 1f, elapsedTime / FadeTime));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        yield return new WaitForSeconds(term);
        elapsedTime = 0f;
        whiteFade.SetActive(true);
        while (elapsedTime <= FadeTime)
        {
            whiteFade.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(1f, 0f, elapsedTime / FadeTime));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        whiteFade.SetActive(false);
    }

    public void RegisterCallback(Action callback)
    {
        onComplateCallback = callback;
    }
}
