using UnityEngine;

namespace BBang
{
    public class FindBread : MonoBehaviour
    {
        private int _bread1;
        private int _bread2 = 0;
        private int _bread3 = 0;

        private void Start()
        {
            _bread1 = Random.Range(0, 3);
            if (_bread1 == 1)
            {
            
            }
        }

        // Update is called once per frame
        private void Update()
        {
        
        }
    }
}
