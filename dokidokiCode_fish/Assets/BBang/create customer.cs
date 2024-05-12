using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class createcustomer : MonoBehaviour
{
    public bool eotk = false;
    public int bread1 = 0;
    public int bread2 = 0;
    public int bread3 = 0;
    public int score = 0;

    public int B1 = 0;
    public int B2 = 0;
    public int B3 = 0;
    public static int b1g = 0;
    public static int b2g = 0;
    public static int b3g = 0;
    [SerializeField]
    public GameObject Customer;

    public GameObject Text;

    public GameObject Bread1;
    public GameObject Bread2;
    public GameObject Bread3;

    public Button Button;
    public Button Button1;
    public Button Button2;
    // Start is called before the first frame update

    
    

    void Start()
    {
        Create();
        StartCoroutine(Delay(8f));
        
        Button.onClick.AddListener(clickb1);
        Button1.onClick.AddListener(clickb2);
        Button2.onClick.AddListener(clickb3);
    }

    IEnumerator Delay(float time)
    {
        eotk = false;
        float elepsedtime = 0f;
        while(elepsedtime<time)
        {
            elepsedtime += UnityEngine.Time.deltaTime;
            yield return null;
        }
        
        yield return new WaitForSecondsRealtime(2f);
        Create();
        StartCoroutine(Delay(4f));
        yield break;

    }
    private void Create()
    {
        B1 = 0;
        B2 = 0;
        B3 = 0;
        b1g = 0;
        b2g = 0;
        b3g = 0;
        bread1 = Random.Range(1, 4);
        bread2 = Random.Range(1, 4);
        bread3 = Random.Range(1, 4);
        var clonec = Instantiate(Customer);
        var clonet = Instantiate(Text);
        clonec.transform.position = new Vector3(-4, 2, 0);
        clonet.transform.position = new Vector3(3.8f, 2.75f, 0f);
        if (bread1 == 1)
        {
            var cloneb1 = Instantiate(Bread1);
            cloneb1.transform.position = new Vector3(0.9f, 2.9f, 0f);
            Destroy(cloneb1,4f);
            b1g++;
        }
        else if (bread1 == 2)
        {
            var cloneb2 = Instantiate(Bread2);
            cloneb2.transform.position = new Vector3(0.8f, 2.9f, 0f);
            Destroy(cloneb2,4f);
            b2g++;
        }
        else if (bread1 == 3)
        {
            var cloneb3 = Instantiate(Bread3);
            cloneb3.transform.position = new Vector3(0.95f, 2.7f, 0f);
            Destroy(cloneb3,4f);
            b3g++;
        }
        
        if (bread2 == 1)
        {
            var cloneb1 = Instantiate(Bread1);
            cloneb1.transform.position = new Vector3(3.7f, 2.9f, 0f);
            Destroy(cloneb1,4f);
            b1g++;
        }
        else if (bread2 == 2)
        {
            var cloneb2 = Instantiate(Bread2);
            cloneb2.transform.position = new Vector3(3.6f, 2.9f, 0f);
            Destroy(cloneb2,4f);
            b2g++;
        }
        else if (bread2 == 3)
        {
            var cloneb3 = Instantiate(Bread3);
            cloneb3.transform.position = new Vector3(3.75f, 2.7f, 0f);
            Destroy(cloneb3,4f);
            b3g++;
        }
        
        if (bread3 == 1)
        {
            var cloneb1 = Instantiate(Bread1);
            cloneb1.transform.position = new Vector3(6.5f, 2.9f, 0f);
            Destroy(cloneb1,4f);
            b1g++;
        }
        else if (bread3 == 2)
        {
            var cloneb2 = Instantiate(Bread2);
            cloneb2.transform.position = new Vector3(6.4f, 2.9f, 0f);
            Destroy(cloneb2,4f);
            b2g++;
        }
        else if (bread3 == 3)
        {
            var cloneb3 = Instantiate(Bread3);
            cloneb3.transform.position = new Vector3(6.45f, 2.7f, 0f);
            Destroy(cloneb3,4f);
            b3g++;
        }
        Destroy(clonec, 4f);
        Destroy(clonet, 4f);
        
        eotk = true;
    }

    void Update ()
    {
          
        if (b1g == B1 && b2g == B2 && b3g == B3)
        {
            score += 1000;
            B1 = 0;
            B2 = 0;
            B3 = 0;
        }
    }

    void clickb1()
    {
        B1++;
    }

    void clickb2()
    {
        B2++;
    }

    void clickb3()
    {
        B3++;
    }
}
