using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanSetter : MonoBehaviour
{
    public Sprite[] PlanImgs = new Sprite[]{};

    public enum Planimg
    {
        Game,Bread,GYM,Hayoul,Backsu
    }

    public void SetMorningPlan(int insertSlot, Planimg dropImg, string dropString, string LineFilepath)
    {
        PlanDropdownManager.MorningFiles.Insert(insertSlot,LineFilepath);
        Debug.Log(PlanDropdownManager.MorningFiles[insertSlot]);
        Debug.Log(PlanDropdownManager.MorningImgs.Count);
        //PlanDropdownManager.MorningImgs.Add(PlanImgs[1]);//Insert(insertSlot,PlanImgs[(int)dropImg]);
        PlanDropdownManager.MorningPlans.Insert(insertSlot,dropString);
    }
    public void SetLunchPlan(int insertSlot, Planimg dropImg, string dropString, string LineFilepath)
    {
        PlanDropdownManager.LunchFiles.Insert(insertSlot,LineFilepath);
        //PlanDropdownManager.LunchImgs.Insert(insertSlot,PlanImgs[(int)dropImg]);
        PlanDropdownManager.LunchPlans.Insert(insertSlot,dropString);
    }
    public void SetNightPlan(int insertSlot, Planimg dropImg, string dropString, string LineFilepath)
    {
        PlanDropdownManager.NightFiles.Insert(insertSlot,LineFilepath);
        //PlanDropdownManager.NightImgs.Insert(insertSlot,PlanImgs[(int)dropImg]);
        PlanDropdownManager.NightPlans.Insert(insertSlot,dropString);
    }
}
