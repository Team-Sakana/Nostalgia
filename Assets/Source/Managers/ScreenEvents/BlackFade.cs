using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

namespace Source.Managers.ScreenEvents
{
    public class BlackFade : MonoBehaviour
    {
        [FormerlySerializedAs("FadeTime")] [Header("페이드 진행속도")] public float fadeTime;
        [Header("Blackfade 개체")] public GameObject blackFade;
        private Action _onCompleteCallback;

        [FormerlySerializedAs("Dbutton")] public GameObject dButton;
        [FormerlySerializedAs("Pbutton")] public GameObject pButton;
        private void Start()
        {
            if (blackFade) return;
            Debug.Log("BlackFade 개체를 찾지 못함");
            throw new MissingComponentException();
        }

        private IEnumerator BlackFadeOut(float term)
        {
            blackFade.SetActive(true);
            dButton.SetActive(false);
            pButton.SetActive(false);
            var elapsedTime = 0f;
            while (elapsedTime <= fadeTime)
            {
                blackFade.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(0f, 1f, elapsedTime / fadeTime));
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            yield return new WaitForSeconds(term);
            elapsedTime = 0f;
            while (elapsedTime <= fadeTime)
            {
                blackFade.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(1f, 0f, elapsedTime / fadeTime));
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            blackFade.SetActive(false);
            pButton.SetActive(true);
            dButton.SetActive(true);
        }

        public void RegisterCallback(Action callback)
        {
            _onCompleteCallback = callback;
        }

        private IEnumerator StartFade(float term)
        {
            var elapsedTime = 0f;
            blackFade.SetActive(true);
            pButton.SetActive(false);
            dButton.SetActive(false);
            while (elapsedTime <= fadeTime)
            {
                blackFade.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(1f, 0f, elapsedTime / fadeTime));
                elapsedTime += Time.deltaTime;
                yield return null;
            }
            blackFade.SetActive(false);
            dButton.SetActive(true);
            pButton.SetActive(true);
        }
    }
}
