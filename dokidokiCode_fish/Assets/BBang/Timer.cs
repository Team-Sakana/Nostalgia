using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public TMP_Text TimeText;
    
    
    void Start()
    {
        StartCoroutine(wait(60f));
    }

    IEnumerator wait(float Time)
    {
        float elepsedtime = 0f;
        while(elepsedtime<Time)
        {
            elepsedtime += UnityEngine.Time.deltaTime;
            TimeText.text = (Time - elepsedtime).ToString("0.00");
            yield return null;
        }
        SceneManager.LoadScene("New Scene");
        yield break;
    }
    // Update is called once per frame
    void Update()
    {
       
    }
   
    
}