using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace BBang
{
    public class CreateCustomer : MonoBehaviour
    {
        public TMP_Text scoreText;
        public bool breadSubmit;
        private int _bread1;
        private int _bread2;
        private int _bread3;
        private int _score;

        private int _b1;
        private int _b2;
        private int _b3;
        private static int _b1G;
        private static int _b2G;
        private static int _b3G;

        private bool _doNotChangeThisVariable;
        
        public GameObject customer;

        public GameObject text;

        public GameObject bread1;
        public GameObject bread2;
        public GameObject bread3;

        public Button button;
        public Button button1;
        public Button button2;

        private GameObject _cB1;
        private GameObject _cB2;
        private GameObject _cB3;
        private GameObject _cC;
        private GameObject _cT;

        static CreateCustomer()
        {
            _b1G = 0;
        }

        private void Start()
        {
            Create();
            StartCoroutine(Delay(4f));
            scoreText.text = _score.ToString();
        
            button.onClick.AddListener(ClickB1);
            button1.onClick.AddListener(ClickB2);
            button2.onClick.AddListener(ClickB3);
        }

        private IEnumerator Delay(float time)
        {
            if (_doNotChangeThisVariable) yield break;
            var timeElapsed = 0f;
            while(timeElapsed<time)
            {
                timeElapsed += Time.deltaTime;
                yield return null;
            }
            yield return new WaitForSecondsRealtime(2f);
            Create();
            StartCoroutine(Delay(time));
        }
        private void Create()
        {
            breadSubmit = false;
            _b1 = 0;
            _b2 = 0;
            _b3 = 0;
            _b1G = 0;
            _b2G = 0;
            _b3G = 0;
            _bread1 = Random.Range(1, 4);
            _bread2 = Random.Range(1, 4);
            _bread3 = Random.Range(1, 4);
            var cloneC = Instantiate(customer);
            var cloneT = Instantiate(text);
            cloneC.transform.position = new Vector3(-5.2f, 0.625f, 0);
            cloneT.transform.position = new Vector3(3.35f, 1.7f, 0f);
            switch (_bread1)
            {
                case 1:
                {
                    var cloneB1 = Instantiate(bread1);
                    cloneB1.transform.position = new Vector3(0f, 1.9f, 0f);
                    _cB1 = cloneB1;
                    Destroy(cloneB1,4f);
                    _b1G++;
                    break;
                }
                case 2:
                {
                    var cloneB2 = Instantiate(bread2);
                    cloneB2.transform.position = new Vector3(0f, 1.9f, 0f);
                    _cB1 = cloneB2;
                    Destroy(cloneB2,4f);
                    _b2G++;
                    break;
                }
                case 3:
                {
                    var cloneB3 = Instantiate(bread3);
                    cloneB3.transform.position = new Vector3(0f, 1.9f, 0f);
                    _cB1 = cloneB3;
                    Destroy(cloneB3,4f);
                    _b3G++;
                    break;
                }
            }
        
            switch (_bread2)
            {
                case 1:
                {
                    var cloneB1 = Instantiate(bread1);
                    cloneB1.transform.position = new Vector3(3.2f, 1.9f, 0f);
                    _cB2 = cloneB1;
                    Destroy(cloneB1,4f);
                    _b1G++;
                    break;
                }
                case 2:
                {
                    var cloneB2 = Instantiate(bread2);
                    cloneB2.transform.position = new Vector3(3.2f, 1.9f, 0f);
                    _cB2 = cloneB2;
                    Destroy(cloneB2,4f);
                    _b2G++;
                    break;
                }
                case 3:
                {
                    var cloneB3 = Instantiate(bread3);
                    cloneB3.transform.position = new Vector3(3.2f, 1.9f, 0f);
                    _cB2 = cloneB3;
                    Destroy(cloneB3,4f);
                    _b3G++;
                    break;
                }
            }
        
            switch (_bread3)
            {
                case 1:
                {
                    var cloneB1 = Instantiate(bread1);
                    cloneB1.transform.position = new Vector3(6.4f, 1.9f, 0f);
                    _cB3 = cloneB1;
                    Destroy(cloneB1,4f);
                    _b1G++;
                    break;
                }
                case 2:
                {
                    var cloneB2 = Instantiate(bread2);
                    cloneB2.transform.position = new Vector3(6.4f, 1.9f, 0f);
                    _cB3 = cloneB2;
                    Destroy(cloneB2,4f);
                    _b2G++;
                    break;
                }
                case 3:
                {
                    var cloneB3 = Instantiate(bread3);
                    cloneB3.transform.position = new Vector3(6.4f, 1.9f, 0f);
                    _cB3 = cloneB3;
                    Destroy(cloneB3,4f);
                    _b3G++;
                    break;
                }
            }
            _cC = cloneC;
            _cT = cloneT;
            Destroy(cloneC, 4f);
            Destroy(cloneT, 4f);
            StartCoroutine(BreadSubmitTimeOver());
        }

        private IEnumerator BreadSubmitTimeOver()
        {
            yield return new WaitForSecondsRealtime(4f);
            breadSubmit = true;
        }

        private void Update()
        {
            if (breadSubmit) return;
            if (_b1 > _b1G || _b2 > _b2G || _b3 > _b3G)
            {
                Destroy(_cB1);
                Destroy(_cB2);
                Destroy(_cB3);
                Destroy(_cC);
                Destroy(_cT);
                _b1 = 0;
                _b2 = 0;
                _b3 = 0;
                breadSubmit = true;
                return;
            }
            if (_b1G != _b1 || _b2G != _b2 || _b3G != _b3) return;
            Destroy(_cB1);
            Destroy(_cB2);
            Destroy(_cB3);
            Destroy(_cC);
            Destroy(_cT);
            _score += 1000;
            _b1 = 0;
            _b2 = 0;
            _b3 = 0;
            breadSubmit = true;
            scoreText.text = (_score).ToString();
        }

        private void ClickB1()
        {
            _b1++;
        }

        private void ClickB2()
        {
            _b2++;
        }

        private void ClickB3()
        {
            _b3++;
        }
    }
}
