using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Planbutton : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown MorningDrop;
    [SerializeField] private TMP_Dropdown LunchDrop;
    [SerializeField] private TMP_Dropdown NightDrop;
    private void Start()
    {//Plan 설정 scene 진입 
        MorningDrop.options.Clear();
        LunchDrop.options.Clear();
        NightDrop.options.Clear();
        fillMorning();
        fillLunch();
        fillNight();
    }

    public void fillMorning()
    {
        int i = 0;
        foreach (string C in PlanDropdownManager.MorningPlans)
        {
            MorningDrop.options.Add(new TMP_Dropdown.OptionData(){text = C,/*image = PlanDropdownManager.MorningImgs[i++]*/});
        }
    }
    public void fillLunch()
    {
        int i = 0;
        foreach (string C in PlanDropdownManager.LunchPlans)
        {
            LunchDrop.options.Add(new TMP_Dropdown.OptionData(){text = C,/*,image = PlanDropdownManager.LunchImgs[i++]*/});
        }
    }
    public void fillNight()
    {
        int i = 0;
        foreach (string C in PlanDropdownManager.NightPlans)
        {
            NightDrop.options.Add(new TMP_Dropdown.OptionData(){text = C,/*image = PlanDropdownManager.NightImgs[i++]*/});
        }
    }
    public void Plansubmit()
    {
        PlanDropdownManager.ChangeMorningPlan(PlanDropdownManager.MorningFiles[MorningDrop.value]);
        PlanDropdownManager.ChangelunchPlan(PlanDropdownManager.LunchFiles[LunchDrop.value]);
        PlanDropdownManager.ChangenightPlan(PlanDropdownManager.NightFiles[NightDrop.value]);
        SceneManager.LoadScene("WeMaking");
    }
}
