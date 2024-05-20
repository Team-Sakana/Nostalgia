using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace BBang
{
    public class Timer : MonoBehaviour
    {
        [FormerlySerializedAs("TimeText")] public Text timeText;


        private void Start()
        {
            StartCoroutine(Wait(60f));
        }

        private static IEnumerator Wait(float time)
        {
            var timeElapsed = 0f;
            while(timeElapsed<time)
            {
                timeElapsed += UnityEngine.Time.deltaTime;
                yield return null;
            }
            SceneManager.LoadScene("New Scene");
        }
        // Update is called once per frame
        private void Update()
        {
       
        }
    
    }
}
