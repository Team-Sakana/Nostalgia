using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TalkPrograssManager : MonoBehaviour
{
    public static int prograss = 0;
    public TextMeshProUGUI TalkTextUI;
    [Header("타이핑 지연시간")] public float typingDelay;
    WaitForSeconds time;
    IEnumerator startTyping;
    public bool PlayingCheck = false;
    private string[] write;
    private static int[] NoTextActionPrograssList;
    private static int[] ActionPrograssList;
    private int temp;
    public int writeIndex = 0;
    public int AnimationMinus = 0;
    public string filePath;
    public GameObject ScreenEventManager;
    [Header("페이드 인/아웃 중간 시간 기본")] 
    public float term;
    public GameObject TalkNameMannager;
    private bool isPS1;
    public PlanSetter PlanSetter = new PlanSetter();
    
    private void Awake()
    {
        Debug.Log(PlanDropdownManager.todayPlan[0]);
        time = new WaitForSeconds(typingDelay);
        if (SaveManager.SaveData.isfirst)
        {
            PlanSetter.SetMorningPlan(0,PlanSetter.Planimg.Backsu,"백수짓","throwThisLOL");
            PlanSetter.SetMorningPlan(1,PlanSetter.Planimg.Bread,"하율에게 제빵 배우기","Assets/Sourse/Managers/Lines/BreadTutoreal.data");
            PlanSetter.SetLunchPlan(0,PlanSetter.Planimg.GYM,"운동 배우기","Assets/Sourse/Managers/Lines/GYMFirst.data");
            PlanSetter.SetNightPlan(0,PlanSetter.Planimg.Game,"게임하기","Assets/Sourse/Managers/Lines/GameFirst.data");
            isPS1 = true;
            //SaveManager.SetDefaultInfo1();
            PlanDropdownManager.ChangeMorningPlan("Assets/Sourse/Managers/Lines/Scene0.data");
            Debug.Log(PlanDropdownManager.todayPlan[0]);
            NoTextActionPrograssList = new int[] { 3,25 }; //PS1의 글을 넘기지 않으면서 텍스트를 진행시키는 Prograss값의 list
            if (PlanDropdownManager.ismorning) 
                filePath = PlanDropdownManager.todayPlan[0];
            if (PlanDropdownManager.islunch)
                filePath = PlanDropdownManager.todayPlan[1];
            if (PlanDropdownManager.isnigth)
                filePath = PlanDropdownManager.todayPlan[2];
        }
    }
    private void Start()
    {
        ScreenEventManager.GetComponent<BlackFade>().StartCoroutine("StartFade",0.5);
        string temp = ReadData(filePath);
        temp = temp.Replace("\n","");
        write = temp.Split("|");
    }
    string ReadData(string filePath)
    {
        FileInfo fileInfo = new FileInfo(filePath);
        string value = "";

        if (fileInfo.Exists)
        {
            StreamReader reader = new StreamReader(filePath);
            value = reader.ReadToEnd();
            reader.Close();
        }

        else
            value = "파일이 없습니다.";

        return value;
    }
    public void ClickButton()
    {
        if (!PlayingCheck)
        {
            prograss++;
        }
        if (isPS1)
        {
            PS1(prograss);
        }
    }

    // Update is called once per frame
    private void PS1(int Prograss)
    {
        if (!Array.Exists(NoTextActionPrograssList, x => x == Prograss - AnimationMinus)) 
        {
            if (write.Length == Prograss-AnimationMinus)
            {
                isPS1 = false;
                ScreenEventManager.GetComponent<ScenePackManager>().ScenePack();
            }
            if (!PlayingCheck) 
            { 
                switch (Prograss - AnimationMinus) //같이 진행할 애니메이션
                { 
                    case 1: 
                        ScreenEventManager.GetComponent<TalkBackGroundManager>().TalkBackGroundSet(); 
                        ScreenEventManager.GetComponent<TalkNameManager>().ChangeName("나"); 
                        break;
                    case 5:
                        ScreenEventManager.GetComponent<BlackFade>().StartCoroutine("BlackFadeOut",1.5f);
                        ScreenEventManager.GetComponent<BackGroundManager>().changeImg(BackGroundManager.BackGroundImgs.Bakery,1.5f);
                        break;
                    case 6:
                        ScreenEventManager.GetComponent<BlackFade>().StartCoroutine("BlackFadeOut", 0.3f);
                        ScreenEventManager.GetComponent<BackGroundManager>().changeImg(BackGroundManager.BackGroundImgs.Kitchin,0.5f);
                        break;
                    case 10:
                        ScreenEventManager.GetComponent<TalkNameManager>().ChangeName("???");
                        ScreenEventManager.GetComponent<hayoulManager>().beDark();
                        ScreenEventManager.GetComponent<hayoulManager>().HayoulGetIn();
                        break;
                    case 11:
                        ScreenEventManager.GetComponent<TalkNameManager>().ChangeName("나");
                        break;
                    case 14:
                        ScreenEventManager.GetComponent<TalkNameManager>().ChangeName("???");
                        break;
                    case 15:
                        ScreenEventManager.GetComponent<TalkNameManager>().ChangeName("나");
                        break;
                    case 16:
                        ScreenEventManager.GetComponent<TalkNameManager>().ChangeName("???");
                        break;
                    case 18:
                        ScreenEventManager.GetComponent<TalkNameManager>().ChangeName("나");
                        break;
                    case 19:
                        ScreenEventManager.GetComponent<hayoulManager>().beLight();
                        ScreenEventManager.GetComponent<TalkNameManager>().ChangeName("하율");
                        break;
                    case 20:
                        ScreenEventManager.GetComponent<TalkNameManager>().ChangeName("나");
                        break;
                }
                startTyping = TypingText(Prograss - AnimationMinus); 
                PlayingCheck = true; 
                StartCoroutine(startTyping);
            }
            else if (PlayingCheck) 
            { 
                StopCoroutine(startTyping);
                TalkTextUI.text = write[Prograss - AnimationMinus]; 
                PlayingCheck = false;
            }
        }
        else
        { 
            switch (Prograss + AnimationMinus) //nextprograss()일때 대사를 진행시키지 않으면서 애니메이션만 재생하는 Prograss
            {
                case 3:
                    ScreenEventManager.GetComponent<BlackFade>().FadeTime = 0.5f;
                    ScreenEventManager.GetComponent<BlackFade>().StartCoroutine("BlackFadeOut", 0.5f);
                    ScreenEventManager.GetComponent<BackGroundManager>().changeImg(BackGroundManager.BackGroundImgs.street,0.5f);
                    AnimationMinus++;
                    break;
                case 25:
                    SaveManager.SaveData.isfirst = false;
                    PlayerData.SaveInSlot1(SaveManager.SaveData);
                    SceneManager.LoadScene("DayPlan");
                    break;
            }
        }
    }
    
    IEnumerator TypingText(int Prograss)
    {
        string pageText;

        for (int i = 0; i < write[Prograss].Length + 1; i++)
        {
            pageText = write[Prograss].Substring(0, i);
            TalkTextUI.text = pageText;
            yield return time;
        }
        PlayingCheck = false;
    }

    private void nextTime()
    {
        if (PlanDropdownManager.ismorning)
        {
            PlanDropdownManager.ismorning = false;
            PlanDropdownManager.islunch = true;
        }
        else if (PlanDropdownManager.islunch)
        {
            PlanDropdownManager.islunch = false;
            PlanDropdownManager.isnigth = true;
        }
        else
        {
            //dayEnd를 따로 구현하자.이게 night가 끝난거니까
        }
    }
}
