using UnityEngine;
using UnityEngine.Serialization;

namespace BBang
{
    public class BreadPlus1 : MonoBehaviour
    {
        public static int B1 = 0;
    
        [FormerlySerializedAs("b1g")] public int b1G = CreateCustomer.B1G;
        // Start is called before the first frame update
        private void Start()
        {
        
        }

        // Update is called once per frame
        private void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                B1++;
            }
        }
    }
}
