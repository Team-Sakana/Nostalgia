using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ScenePackManager : MonoBehaviour
{
    public GameObject scenepack;
    public float fadetime;
    //팩 이미지 변경 기능 추가
    private void Start()
    {
        scenepack.SetActive(false);
        scenepack.GetComponent<CanvasRenderer>().SetAlpha(0f);
    }

    public void ScenePack()
    {
        scenepack.SetActive(true);
        StartCoroutine(packscene());
    }

    IEnumerator packscene()
    {
        float elepsedtime = 0f;
        while (elepsedtime<=fadetime)
        {
            scenepack.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(0f, 1f, elepsedtime / fadetime));
            elepsedtime += Time.deltaTime;
            yield return null;
        }
    }
}
