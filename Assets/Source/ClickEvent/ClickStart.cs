using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace Source.ClickEvent
{
    public class ClickEvent : MonoBehaviour
    {
        [FormerlySerializedAs("ChangeTime")] public float changeTime;
        [FormerlySerializedAs("Canvas")] public GameObject canvas;
        public void StartClick()
        {
            StartCoroutine(nameof(ChangeScene));
        }

        private IEnumerator ChangeScene()
        {
            var times = 0f;
            while (times < changeTime)
            {
                canvas.SetActive(true);
                canvas.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(0f, 1f, times / changeTime));
                times += Time.deltaTime;
                yield return null;
            }
            SceneManager.LoadScene("Play");
            canvas.GetComponent<CanvasRenderer>().SetAlpha(0f);
            canvas.SetActive(false);
        }
    }
}