using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
   public Text TimeText;
    
    
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
