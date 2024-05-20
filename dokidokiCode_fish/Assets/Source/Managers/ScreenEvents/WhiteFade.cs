using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

namespace Source.Managers.ScreenEvents
{
    public class WhiteFade : MonoBehaviour
    {
        [FormerlySerializedAs("FadeTime")] [Header("페이드 진행속도")] public float fadeTime;
        [Header("Whitefade 개체")] public GameObject whiteFade;
        private Action _onCompleteCallback;

        private void Start()
        {
            if (whiteFade) return;
            Debug.Log("whiteFade 개체를 찾지 못함");
            throw new MissingComponentException();
        }

        private IEnumerator WhiteFadeOut(float term)
        {
            var elapsedTime = 0f;
            while (elapsedTime <= fadeTime)
            {
                whiteFade.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(0f, 1f, elapsedTime / fadeTime));
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            yield return new WaitForSeconds(term);
            elapsedTime = 0f;
            whiteFade.SetActive(true);
            while (elapsedTime <= fadeTime)
            {
                whiteFade.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(1f, 0f, elapsedTime / fadeTime));
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            whiteFade.SetActive(false);
        }

        public void RegisterCallback(Action callback)
        {
            _onCompleteCallback = callback;
        }
    }
}
