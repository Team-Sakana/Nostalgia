using UnityEngine;
using UnityEngine.Serialization;

namespace Source.Managers
{
    public class DropDownManager : MonoBehaviour
    {
        public GameObject halfFade;//On시 켜지는 창 뒤쪽 전체 버튼
        [FormerlySerializedAs("dropdownanim")] public Animator dropDownAni;
        [FormerlySerializedAs("DButtonanim")] public Animator dButtonAni;
        private bool _itsDropped = false;

        public void GetDrop()
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
            halfFade.SetActive(true);
            dropDownAni.Play("DropdownAnim");
            dButtonAni.Play("dropButtonOn");
        }

        private void GetUp()
        {
            halfFade.SetActive(false);
            dropDownAni.Play("DropUp");
            dButtonAni.Play("dropButtonOff");
        }
    }
}
