using UnityEngine;
using UnityEngine.Serialization;

namespace BBang
{
    public class BreadPlus3 : MonoBehaviour
    {
        public static int B3 = 0;
    
        [FormerlySerializedAs("b3g")] public int b3G = CreateCustomer.B3G;
        // Start is called before the first frame update
        private void Start()
        {
        
        }

        // Update is called once per frame
        private void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                B3++;
            }
        }
    }
}
