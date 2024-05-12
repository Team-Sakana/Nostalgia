using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breadplus3 : MonoBehaviour
{
    public static int b3 = 0;
    
    public int b3g = createcustomer.b3g;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            b3++;
        }
    }
}
