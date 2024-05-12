using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoSceneButton : MonoBehaviour
{
    public void changeScene(string Scenename)
    {
        SceneManager.LoadScene(Scenename);
    }
}
