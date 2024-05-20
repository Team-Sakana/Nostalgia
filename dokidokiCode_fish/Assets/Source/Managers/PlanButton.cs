using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace Source.Managers
{
    public class PlanButton : MonoBehaviour
    {
        [FormerlySerializedAs("MorningDrop")] [SerializeField] private TMP_Dropdown morningDrop;
        [FormerlySerializedAs("LunchDrop")] [SerializeField] private TMP_Dropdown lunchDrop;
        [FormerlySerializedAs("NightDrop")] [SerializeField] private TMP_Dropdown nightDrop;
        private void Start()
        {//Plan 설정 scene 진입 
            morningDrop.options.Clear();
            lunchDrop.options.Clear();
            nightDrop.options.Clear();
            FillMorning();
            FillLunch();
            FillNight();
        }

        public void FillMorning()
        {
            var i = 0;
            foreach (var c in PlanDropdownManager.MorningPlans)
            {
                morningDrop.options.Add(new TMP_Dropdown.OptionData(){text = c,/*image = PlanDropdownManager.MorningImgs[i++]*/});
            }
        }
        public void FillLunch()
        {
            var i = 0;
            foreach (var c in PlanDropdownManager.LunchPlans)
            {
                lunchDrop.options.Add(new TMP_Dropdown.OptionData(){text = c,/*,image = PlanDropdownManager.LunchImgs[i++]*/});
            }
        }
        public void FillNight()
        {
            var i = 0;
            foreach (var c in PlanDropdownManager.NightPlans)
            {
                nightDrop.options.Add(new TMP_Dropdown.OptionData(){text = c,/*image = PlanDropdownManager.NightImgs[i++]*/});
            }
        }
        public void PlanSubmit()
        {
            PlanDropdownManager.ChangeMorningPlan(PlanDropdownManager.MorningFiles[morningDrop.value]);
            PlanDropdownManager.ChangeLunchPlan(PlanDropdownManager.LunchFiles[lunchDrop.value]);
            PlanDropdownManager.ChangeNightPlan(PlanDropdownManager.NightFiles[nightDrop.value]);
            SceneManager.LoadScene("WeMaking");
        }
    }
}
