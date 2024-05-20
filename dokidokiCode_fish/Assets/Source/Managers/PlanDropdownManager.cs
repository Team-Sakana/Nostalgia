using System.Collections.Generic;
using UnityEngine;

namespace Source.Managers
{
    public static class PlanDropdownManager
    {
        [Header("드롭다운 이미지 텍스쳐들(인게임 도중 수정)")]
        public static List<Sprite> MorningImages = new();
        public static List<Sprite> LunchImages = new();
        public static List<Sprite> NightImages = new();
        [Header("아침 선택지들의 텍스트(인게임 도중 수정)")] 
        public static List<string> MorningPlans = new();
        public static List<string> LunchPlans = new();
        public static List<string> NightPlans = new();
        [Header("아침/점심/저녁 선택지 별 대사 파일(Plans,Imgages와 함께 수정)")]
        public static List<string> MorningFiles = new();
        public static List<string> LunchFiles = new();
        public static List<string> NightFiles = new();
        [Header("당일의 플랜(인게임 내 매일 수정)")]
        public static string[] TodayPlan = new string[3];
        [Header("현재 아침/점심/저녁(인게임에서 접근)")]
        public static bool IsMorning = true;
        public static bool IsLunch = false;
        public static bool IsNight = false;
        public static void ChangeMorningPlan(string whatPlan)//plan은 filepath로 받자.
        {
            TodayPlan[0] = whatPlan;
        }
        public static void ChangeLunchPlan(string whatPlan)//plan은 filepath로 받자.
        {
            TodayPlan[1] = whatPlan;
        }
        public static void ChangeNightPlan(string whatPlan)//plan은 filepath로 받자.
        {
            TodayPlan[2] = whatPlan;
        }
    }
}
