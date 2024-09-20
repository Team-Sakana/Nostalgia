using UnityEngine;
using UnityEngine.SceneManagement;

namespace Source.ClickEvent
{
    public class GotoSceneButton : MonoBehaviour
    {
        public void ChangeScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
