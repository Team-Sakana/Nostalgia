using UnityEngine;
using UnityEngine.SceneManagement;

namespace Source.ClickEvent
{
    public class ClickScene : MonoBehaviour
    {
        // Start is called before the first frame update
        public void StartScenes()
        {
            SceneManager.LoadScene("WatchScenes");
        }
    
    }
}
