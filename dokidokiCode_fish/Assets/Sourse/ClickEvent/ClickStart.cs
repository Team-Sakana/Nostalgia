using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickEvent : MonoBehaviour
{
    public float ChangeTime;
    public GameObject Canvas;
    public void StatrClick()
    {
        StartCoroutine("ChangeScene");
    } 
    IEnumerator ChangeScene()
    {
        float Times = 0f;
        while (Times < ChangeTime)
        {
            Canvas.SetActive(true);
            Canvas.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(0f,1f,Times/ChangeTime));
            Times += Time.deltaTime;
            yield return null;
        }

        SceneManager.LoadScene("Play");
        Canvas.GetComponent<CanvasRenderer>().SetAlpha(0f);
        Canvas.SetActive(false);
        yield break;
    }
}