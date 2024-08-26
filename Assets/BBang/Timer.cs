using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BBang
{
    public class Timer : MonoBehaviour
    {
        public TMP_Text timeText;
        [NonSerialized] public static float TimeElapsed;
        
        private void Start()
        {
            StartCoroutine(Wait(60f));
        }

        private IEnumerator Wait(float time)
        {
            var timeElapsed = 0f;
            while(timeElapsed<time)
            {
                timeElapsed += Time.deltaTime;
                TimeElapsed = time - timeElapsed;
                timeText.text = TimeElapsed.ToString("0.00");
                yield return null;
            }
            SceneManager.LoadScene("New Scene");
        }
    }
}