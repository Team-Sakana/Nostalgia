using UnityEngine;
using UnityEngine.Serialization;

namespace BBang
{
    public class BreadPlus2 : MonoBehaviour
    {
        public static int B2 = 0;
    
        [FormerlySerializedAs("b2g")] public int b2G = CreateCustomer.B2G;
        // Start is called before the first frame update
        private void Start()
        {
        
        }

        // Update is called once per frame
        private void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                B2++;
            }
        }
    }
}
