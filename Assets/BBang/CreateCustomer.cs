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
        private int _clickedB;
        private int Custom;

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
        [SerializeField] private GameObject _cC;
        private GameObject _cT;
        
        private GameObject _cB1Display;
        private GameObject _cB1Display1;
        private GameObject _cB1Display2;
        private GameObject _cB2Display;
        private GameObject _cB2Display1;
        private GameObject _cB2Display2;
        private GameObject _cB3Display;
        private GameObject _cB3Display1;
        private GameObject _cB3Display2;

        public GameObject b1Display;
        public GameObject b2Display;
        public GameObject b3Display;
        private SpriteRenderer _spriteRenderer;

        static CreateCustomer()
        {
            _b1G = 0;
        }

        private void Start()
        {
            _spriteRenderer = _cC.GetComponent<SpriteRenderer>();
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
            Custom = 0;
            _b1 = 0;
            _b2 = 0;
            _b3 = 0;
            _b1G = 0;
            _b2G = 0;
            _b3G = 0;
            _clickedB = 0;
            _bread1 = Random.Range(1, 4);
            _bread2 = Random.Range(1, 4);
            _bread3 = Random.Range(1, 4);
            Custom = Random.Range(1, 3);
            var cloneC = Instantiate(customer);
            var cloneCSprite = cloneC.GetComponent<SpriteRenderer>();
            cloneCSprite.sprite = SpriteManager.GetSprite("Cutomers/Customer" + Custom + "(default)");
            var cloneT = Instantiate(text);
            cloneC.transform.position = new Vector3(-5.2f, 0.56f, 0);
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
            if (_b1 <= _b1G && _b2 <= _b2G && _b3 <= _b3G && (_b1G != _b1 || _b2G != _b2 || _b3G != _b3)) return;
            var isSuccess = (_b1G == _b1 && _b2G == _b2 && _b3G == _b3);
            _spriteRenderer.sprite = SpriteManager.GetSprite("Cutomers/Customer" + Custom + "(" + (isSuccess ? "Success" : "Fail") + ")");
            _cC.GetComponent<SpriteRenderer>().sprite = _spriteRenderer.sprite;
            DestroyAll(0, _cB1, _cB2, _cB3, _cT);
            Destroy(_cC, 0.5f);
            DestroyAll(0.2f, _cB1Display, _cB1Display1, _cB1Display2, _cB2Display, _cB2Display1, _cB2Display2, _cB3Display, _cB3Display1, _cB3Display2);
            _b1 = 0;
            _b2 = 0;
            _b3 = 0;
            _clickedB = 0;
            breadSubmit = true;
            if(isSuccess)
            _score += 1000;
            scoreText.text = _score.ToString();
        }

        private static void DestroyAll(float t, params GameObject[] objects)
        {
            foreach (var o in objects) Destroy(o, t);
        }

        private void ClickB1()
        {
            _b1++;
            switch (_clickedB)
            {
                case 0:
                {
                    var cloneB1Display = Instantiate(b1Display);
                    cloneB1Display.transform.position = new Vector3(-1.5f, -4.5f, 0f);
                    _cB1Display = cloneB1Display;
                    Destroy(cloneB1Display,4f);
                    break;
                }
                case 1:
                {
                    var cloneB1Display1 = Instantiate(b1Display);
                    cloneB1Display1.transform.position = new Vector3(0f, -4.5f, 0f);
                    _cB1Display1 = cloneB1Display1;
                    Destroy(cloneB1Display1,4f);
                    break;
                }
                case 2:
                {
                    var cloneB1Display2 = Instantiate(b1Display);
                    cloneB1Display2.transform.position = new Vector3(1.5f, -4.5f, 0f);
                    _cB1Display2 = cloneB1Display2;
                    Destroy(cloneB1Display2,4f);
                    break;
                }
            }
            _clickedB++;
        }

        private void ClickB2()
        {
            _b2++;
            switch (_clickedB)
            {
                case 0:
                {
                    var cloneB2Display = Instantiate(b2Display);
                    cloneB2Display.transform.position = new Vector3(-1.5f, -4.5f, 0f);
                    _cB2Display = cloneB2Display;
                    Destroy(cloneB2Display,4f);
                    break;
                }
                case 1:
                {
                    var cloneB2Display1 = Instantiate(b2Display);
                    cloneB2Display1.transform.position = new Vector3(0f, -4.5f, 0f);
                    _cB2Display1 = cloneB2Display1;
                    Destroy(cloneB2Display1,4f);
                    break;
                }
                case 2:
                {
                    var cloneB2Display2 = Instantiate(b2Display);
                    cloneB2Display2.transform.position = new Vector3(1.5f, -4.5f, 0f);
                    _cB2Display2 = cloneB2Display2;
                    Destroy(cloneB2Display2,4f);
                    break;
                }
            }
            _clickedB++;
        }

        private void ClickB3()
        {
            _b3++;
            switch (_clickedB)
            {
                case 0:
                {
                    var cloneB3Display = Instantiate(b3Display);
                    cloneB3Display.transform.position = new Vector3(-1.5f, -4.5f, 0f);
                    _cB3Display = cloneB3Display;
                    Destroy(cloneB3Display,4f);
                    break;
                }
                case 1:
                {
                    var cloneB3Display1 = Instantiate(b3Display);
                    cloneB3Display1.transform.position = new Vector3(0f, -4.5f, 0f);
                    _cB3Display1 = cloneB3Display1;
                    Destroy(cloneB3Display1,4f);
                    break;
                }
                case 2:
                {
                    var cloneB3Display2 = Instantiate(b3Display);
                    cloneB3Display2.transform.position = new Vector3(1.5f, -4.5f, 0f);
                    _cB3Display2 = cloneB3Display2;
                    Destroy(cloneB3Display2,4f);
                    break;
                }
            }
            _clickedB++;
        }
    }
}
