using UnityEngine;
using UnityEngine.Serialization;

namespace Source.Managers
{
    public class PhoneManager : MonoBehaviour
    {
        [FormerlySerializedAs("OnBG")] public GameObject onBg;//On시 켜지는 전체 버튼
        [FormerlySerializedAs("phoneanim")] public Animator phoneAni;
        [FormerlySerializedAs("PButtonanim")] public Animator pButtonAni;
        private bool _itsDropped = false;

        public void GetPhone()
        {
            if (!_itsDropped)
            {
                GetDown();
                _itsDropped = true;
            }
            else
            {
                GetUp();
                _itsDropped = false;
            }
        }
        private void GetDown()
        {
            onBg.SetActive(true);
            phoneAni.Play("PhoneDown");
            pButtonAni.Play("PhoneButtonClick");
        }

        private void GetUp()
        {
            onBg.SetActive(false);
            phoneAni.Play("PhoneUp");
        }
    }
}
