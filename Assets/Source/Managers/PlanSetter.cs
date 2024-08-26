using UnityEngine;
using UnityEngine.Serialization;

namespace Source.Managers
{
    public class PlanSetter : MonoBehaviour
    {
        [FormerlySerializedAs("PlanImgs")] public Sprite[] planImages = {};

        public enum PlanImage
        {
            Game,Bread,Gym,Hayoul,Unemployed
        }

        public static void SetMorningPlan(int insertSlot, PlanImage dropImg, string dropString, string lineFilepath)
        {
            PlanDropdownManager.MorningFiles.Insert(insertSlot,lineFilepath);
            Debug.Log(PlanDropdownManager.MorningFiles[insertSlot]);
            Debug.Log(PlanDropdownManager.MorningImages.Count);
            //PlanDropdownManager.MorningImgs.Add(PlanImgs[1]);//Insert(insertSlot,PlanImgs[(int)dropImg]);
            PlanDropdownManager.MorningPlans.Insert(insertSlot,dropString);
        }
        public static void SetLunchPlan(int insertSlot, PlanImage dropImg, string dropString, string lineFilepath)
        {
            PlanDropdownManager.LunchFiles.Insert(insertSlot,lineFilepath);
            //PlanDropdownManager.LunchImgs.Insert(insertSlot,PlanImgs[(int)dropImg]);
            PlanDropdownManager.LunchPlans.Insert(insertSlot,dropString);
        }
        public static void SetNightPlan(int insertSlot, PlanImage dropImg, string dropString, string lineFilepath)
        {
            PlanDropdownManager.NightFiles.Insert(insertSlot,lineFilepath);
            //PlanDropdownManager.NightImgs.Insert(insertSlot,PlanImgs[(int)dropImg]);
            PlanDropdownManager.NightPlans.Insert(insertSlot,dropString);
        }
    }
}
