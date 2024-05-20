using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace BBang
{
    public class CreateCustomer : MonoBehaviour
    {
        [FormerlySerializedAs("eotk")] public bool endOfTalk = false;
        [FormerlySerializedAs("bread1")] public int bread1Count = 0;
        [FormerlySerializedAs("bread2")] public int bread2Count = 0;
        [FormerlySerializedAs("bread3")] public int bread3Count = 0;
        public int score = 0;

        [FormerlySerializedAs("B1")] public int b1 = 0;
        [FormerlySerializedAs("B2")] public int b2 = 0;
        [FormerlySerializedAs("B3")] public int b3 = 0;
        public static int B1G = 0;
        public static int B2G = 0;
        public static int B3G = 0;
        [FormerlySerializedAs("Customer")] [SerializeField]
        public GameObject customer;

        [FormerlySerializedAs("Text")] public GameObject text;

        [FormerlySerializedAs("Bread1")] public GameObject bread1;
        [FormerlySerializedAs("Bread2")] public GameObject bread2;
        [FormerlySerializedAs("Bread3")] public GameObject bread3;

        [FormerlySerializedAs("Button")] public Button button;
        [FormerlySerializedAs("Button1")] public Button button1;
        [FormerlySerializedAs("Button2")] public Button button2;
        // Start is called before the first frame update


        private void Start()
        {
            Create();
            StartCoroutine(Delay(8f));
        
            button.onClick.AddListener(ClickB1);
            button1.onClick.AddListener(ClickB2);
            button2.onClick.AddListener(ClickB3);
        }

        private IEnumerator Delay(float time)
        {
            endOfTalk = false;
            var timeElapsed = 0f;
            while(timeElapsed<time)
            {
                timeElapsed += Time.deltaTime;
                yield return null;
            }
        
            yield return new WaitForSecondsRealtime(2f);
            Create();
            StartCoroutine(Delay(4f));
        }
        private void Create()
        {
            b1 = 0;
            b2 = 0;
            b3 = 0;
            B1G = 0;
            B2G = 0;
            B3G = 0;
            bread1Count = Random.Range(1, 4);
            bread2Count = Random.Range(1, 4);
            bread3Count = Random.Range(1, 4);
            var cloneC = Instantiate(customer);
            var cloneT = Instantiate(text);
            cloneC.transform.position = new Vector3(-4, 2, 0);
            cloneT.transform.position = new Vector3(3.8f, 2.75f, 0f);
            switch (bread1Count)
            {
                case 1:
                {
                    var cloneB1 = Instantiate(bread1);
                    cloneB1.transform.position = new Vector3(0.9f, 2.9f, 0f);
                    Destroy(cloneB1,4f);
                    B1G++;
                    break;
                }
                case 2:
                {
                    var cloneB2 = Instantiate(bread2);
                    cloneB2.transform.position = new Vector3(0.8f, 2.9f, 0f);
                    Destroy(cloneB2,4f);
                    B2G++;
                    break;
                }
                case 3:
                {
                    var cloneB3 = Instantiate(bread3);
                    cloneB3.transform.position = new Vector3(0.95f, 2.7f, 0f);
                    Destroy(cloneB3,4f);
                    B3G++;
                    break;
                }
            }
        
            switch (bread2Count)
            {
                case 1:
                {
                    var cloneB1 = Instantiate(bread1);
                    cloneB1.transform.position = new Vector3(3.7f, 2.9f, 0f);
                    Destroy(cloneB1,4f);
                    B1G++;
                    break;
                }
                case 2:
                {
                    var cloneB2 = Instantiate(bread2);
                    cloneB2.transform.position = new Vector3(3.6f, 2.9f, 0f);
                    Destroy(cloneB2,4f);
                    B2G++;
                    break;
                }
                case 3:
                {
                    var cloneB3 = Instantiate(bread3);
                    cloneB3.transform.position = new Vector3(3.75f, 2.7f, 0f);
                    Destroy(cloneB3,4f);
                    B3G++;
                    break;
                }
            }
        
            switch (bread3Count)
            {
                case 1:
                {
                    var cloneB1 = Instantiate(bread1);
                    cloneB1.transform.position = new Vector3(6.5f, 2.9f, 0f);
                    Destroy(cloneB1,4f);
                    B1G++;
                    break;
                }
                case 2:
                {
                    var cloneB2 = Instantiate(bread2);
                    cloneB2.transform.position = new Vector3(6.4f, 2.9f, 0f);
                    Destroy(cloneB2,4f);
                    B2G++;
                    break;
                }
                case 3:
                {
                    var cloneB3 = Instantiate(bread3);
                    cloneB3.transform.position = new Vector3(6.45f, 2.7f, 0f);
                    Destroy(cloneB3,4f);
                    B3G++;
                    break;
                }
            }
            Destroy(cloneC, 4f);
            Destroy(cloneT, 4f);
        
            endOfTalk = true;
        }

        private void Update()
        {
            if (B1G != b1 || B2G != b2 || B3G != b3) return;
            score += 1000;
            b1 = 0;
            b2 = 0;
            b3 = 0;
        }

        private void ClickB1()
        {
            b1++;
        }

        private void ClickB2()
        {
            b2++;
        }

        private void ClickB3()
        {
            b3++;
        }
    }
}
