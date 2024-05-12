using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breadplus2 : MonoBehaviour
{
    public static int b2 = 0;
    
    public int b2g = createcustomer.b2g;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            b2++;
        }
    }
}
