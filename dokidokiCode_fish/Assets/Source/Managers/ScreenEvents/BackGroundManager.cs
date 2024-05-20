using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Source.Managers.ScreenEvents
{
    public class BackGroundManager : MonoBehaviour
    {
        [FormerlySerializedAs("BackGround")] [Header("BackGround")]
        public GameObject backGround;
        [FormerlySerializedAs("IMGs")] public Texture[] images;
        //public float ChangeBackGroundTime;//추후추가

        public enum BackGroundImages
        {
            Station,
            Street,
            StreetFrontMansion,
            Bakery,
            Kitchen
        }

        private void Start()
        {
            backGround.GetComponent<RawImage>().texture = images[(int)BackGroundImages.Station];
        }
        public void ChangeImg(BackGroundImages whatImage)
        {
            backGround.GetComponent<RawImage>().texture = images[(int)whatImage];
        }
        public void ChangeImg(BackGroundImages whatImage,float waitingTime)
        {
            StartCoroutine(WaitingTime(waitingTime, whatImage));
        }

        private IEnumerator WaitingTime(float waitingTime,BackGroundImages image)
        {
            var timeElapsed = 0f;
            while (timeElapsed <= waitingTime)
            {
                timeElapsed += Time.deltaTime;
                yield return null;
            }
            backGround.GetComponent<RawImage>().texture = images[(int)image];
        }
    }
}
