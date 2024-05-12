using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public static class PlanDropdownManager
{
    [Header("드롭다운 이미지 텍스쳐들(인게임 도중 수정)")]
    public static List<Sprite> MorningImgs = new List<Sprite>();
    public static List<Sprite> LunchImgs = new List<Sprite>();
    public static List<Sprite> NightImgs = new List<Sprite>();
    [Header("아침 선택지들의 텍스트(인게임 도중 수정)")] 
    public static List<string> MorningPlans = new List<string>();
    public static List<string> LunchPlans = new List<string>();
    public static List<string> NightPlans = new List<string>();
    [Header("아침/점심/저녁 선택지 별 대사 파일(Plans,Imgs와 함께 수정)")]
    public static List<string> MorningFiles = new List<string>();
    public static List<string> LunchFiles = new List<string>();
    public static List<string> NightFiles = new List<string>();
    [Header("당일의 플랜(인게임 내 매일 수정)")]
    public static string[] todayPlan = new string[3];
    [Header("현재 아침/점심/저녁(인게임에서 접근)")]
    public static bool ismorning = true;
    public static bool islunch = false;
    public static bool isnigth = false;
    public static void ChangeMorningPlan(string WhatPlan)//plan은 filepath로 받자.
    {
        todayPlan[0] = WhatPlan;
    }
    public static void ChangelunchPlan(string WhatPlan)//plan은 filepath로 받자.
    {
        todayPlan[1] = WhatPlan;
    }
    public static void ChangenightPlan(string WhatPlan)//plan은 filepath로 받자.
    {
        todayPlan[2] = WhatPlan;
    }
}
