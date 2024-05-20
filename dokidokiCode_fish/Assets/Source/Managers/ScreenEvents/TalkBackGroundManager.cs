using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

namespace Source.Managers.ScreenEvents
{
    public class TalkBackGroundManager : MonoBehaviour
    {
        [FormerlySerializedAs("BackGround")] [Header("대사 백그라운드, 명찰 백그라운드")] 
        public CanvasRenderer backGround;
        [FormerlySerializedAs("BackGroundButton")] public GameObject backGroundButton;
        [FormerlySerializedAs("BackgroundText")] public CanvasRenderer backgroundText;
        [FormerlySerializedAs("Namepad")] public CanvasRenderer namePad;
        [FormerlySerializedAs("NamepadText")] public CanvasRenderer namePadText;
        private bool _isInvisible = true;

        [Header("인/아웃 시간")] 
        public float t;

        private void Start()
        {
            backGround.SetAlpha(0f);
            namePad.SetAlpha(0f);
            backgroundText.SetAlpha(0f);
            namePadText.SetAlpha(0f);
        }

        public void TalkBackGroundSet()
        {
            if (_isInvisible)
            {
                _isInvisible = false;
                StartCoroutine(nameof(InBackGround));
            }
            else
            {
                _isInvisible = true;
                StartCoroutine(nameof(OutBackGround));
            }
        }

        private IEnumerator OutBackGround()
        {
            var timeElapsed = 0f;
            while (timeElapsed < t)
            {
                backGround.SetAlpha(Mathf.Lerp(1f, 0f, timeElapsed));
                namePad.SetAlpha(Mathf.Lerp(1f, 0f, timeElapsed));
                backgroundText.SetAlpha(Mathf.Lerp(1f, 0f, timeElapsed));
                namePadText.SetAlpha(Mathf.Lerp(1f, 0f, timeElapsed));
                timeElapsed += Time.deltaTime;
                yield return null;
            }
            backGround.SetAlpha(0f);
            namePad.SetAlpha(0f);
            backgroundText.SetAlpha(0f);
            namePadText.SetAlpha(0f);
        }
        private IEnumerator InBackGround()
        {
            var timeElapsed = 0f;
            while (timeElapsed < t)
            {
                backGround.SetAlpha(Mathf.Lerp(0f, 1f, timeElapsed));
                namePad.SetAlpha(Mathf.Lerp(0f, 1f, timeElapsed));
                backgroundText.SetAlpha(Mathf.Lerp(0f, 1f, timeElapsed));
                namePadText.SetAlpha(Mathf.Lerp(0f, 1f, timeElapsed));
                timeElapsed += Time.deltaTime;
                yield return null;
            }
            backGround.SetAlpha(1f);
            namePad.SetAlpha(1f);
            backgroundText.SetAlpha(1f);
            namePadText.SetAlpha(1f);
        }
    }
}