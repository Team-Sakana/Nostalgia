using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

namespace Source.Managers.ScreenEvents
{
    public class ScenePackManager : MonoBehaviour
    {
        [FormerlySerializedAs("scenepack")] public GameObject scenePack;
        [FormerlySerializedAs("fadetime")] public float fadeTime;
        //팩 이미지 변경 기능 추가
        private void Start()
        {
            scenePack.SetActive(false);
            scenePack.GetComponent<CanvasRenderer>().SetAlpha(0f);
        }

        public void ScenePack()
        {
            scenePack.SetActive(true);
            StartCoroutine(PackScene());
        }

        private IEnumerator PackScene()
        {
            var timeElapsed = 0f;
            while (timeElapsed<=fadeTime)
            {
                scenePack.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(0f, 1f, timeElapsed / fadeTime));
                timeElapsed += Time.deltaTime;
                yield return null;
            }
        }
    }
}
