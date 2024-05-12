using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breadplus1 : MonoBehaviour
{
    public static int b1 = 0;

    public int b1g = createcustomer.b1g;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            b1++;
        }
    }
}
