using System;
using System.Collections;
using System.IO;
using Source.Managers.ScreenEvents;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace Source.Managers
{
    public class TalkProgressManager : MonoBehaviour
    {
        public static int Progress = 0;
        [FormerlySerializedAs("TalkTextUI")] public TextMeshProUGUI talkTextUI;
        [Header("타이핑 지연시간")] public float typingDelay;
        private WaitForSeconds _time;
        private IEnumerator _startTyping;
        [FormerlySerializedAs("PlayingCheck")] public bool playingCheck = false;
        private string[] _write;
        private static int[] _noTextActionProgressList;
        private static int[] _actionProgressList;
        private int _temp;
        public int writeIndex = 0;
        [FormerlySerializedAs("AnimationMinus")] public int animationMinus = 0;
        public string filePath;
        [FormerlySerializedAs("ScreenEventManager")] public GameObject screenEventManager;
        [Header("페이드 인/아웃 중간 시간 기본")] 
        public float term;
        [FormerlySerializedAs("TalkNameMannager")] public GameObject talkNameManager;
        private bool _isPS1;
        [FormerlySerializedAs("PlanSetter")] public PlanSetter planSetter = new();
    
        private void Awake()
        {
            Debug.Log(PlanDropdownManager.TodayPlan[0]);
            _time = new WaitForSeconds(typingDelay);
            if (!SaveManager.SaveData.IsFirst) return;
            PlanSetter.SetMorningPlan(0,PlanSetter.PlanImage.Unemployed,"백수짓","throwThisLOL");
            PlanSetter.SetMorningPlan(1,PlanSetter.PlanImage.Bread,"하율에게 제빵 배우기","Assets/Source/Managers/Lines/BreadTutoreal.data");
            PlanSetter.SetLunchPlan(0,PlanSetter.PlanImage.Gym,"운동 배우기","Assets/Source/Managers/Lines/GYMFirst.data");
            PlanSetter.SetNightPlan(0,PlanSetter.PlanImage.Game,"게임하기","Assets/Source/Managers/Lines/GameFirst.data");
            _isPS1 = true;
            //SaveManager.SetDefaultInfo1();
            PlanDropdownManager.ChangeMorningPlan("Assets/Source/Managers/Lines/Scene0.data");
            Debug.Log(PlanDropdownManager.TodayPlan[0]);
            _noTextActionProgressList = new[] { 3,25 }; //PS1의 글을 넘기지 않으면서 텍스트를 진행시키는 Progress값의 list
            if (PlanDropdownManager.IsMorning) 
                filePath = PlanDropdownManager.TodayPlan[0];
            if (PlanDropdownManager.IsLunch)
                filePath = PlanDropdownManager.TodayPlan[1];
            if (PlanDropdownManager.IsNight)
                filePath = PlanDropdownManager.TodayPlan[2];
        }
        private void Start()
        {
            screenEventManager.GetComponent<BlackFade>().StartCoroutine("StartFade",0.5);
            var temp = ReadData(filePath);
            temp = temp.Replace("\n","");
            _write = temp.Split("|");
        }

        private static string ReadData(string filePath)
        {
            var fileInfo = new FileInfo(filePath);
            var value = "";

            if (fileInfo.Exists)
            {
                var reader = new StreamReader(filePath);
                value = reader.ReadToEnd();
                reader.Close();
            }

            else
                value = "파일이 없습니다.";

            return value;
        }
        public void ClickButton()
        {
            if (!playingCheck)
            {
                Progress++;
            }
            if (_isPS1)
            {
                PS1(Progress);
            }
        }

        // Update is called once per frame
        private void PS1(int progress)
        {
            if (!Array.Exists(_noTextActionProgressList, x => x == progress - animationMinus)) 
            {
                if (_write.Length == progress-animationMinus)
                {
                    _isPS1 = false;
                    screenEventManager.GetComponent<ScenePackManager>().ScenePack();
                }
                if (!playingCheck) 
                { 
                    switch (progress - animationMinus) //같이 진행할 애니메이션
                    { 
                        case 1: 
                            screenEventManager.GetComponent<TalkBackGroundManager>().TalkBackGroundSet(); 
                            screenEventManager.GetComponent<TalkNameManager>().ChangeName("나"); 
                            break;
                        case 5:
                            screenEventManager.GetComponent<BlackFade>().StartCoroutine("BlackFadeOut",1.5f);
                            screenEventManager.GetComponent<BackGroundManager>().ChangeImg(BackGroundManager.BackGroundImages.Bakery,1.5f);
                            break;
                        case 6:
                            screenEventManager.GetComponent<BlackFade>().StartCoroutine("BlackFadeOut", 0.3f);
                            screenEventManager.GetComponent<BackGroundManager>().ChangeImg(BackGroundManager.BackGroundImages.Kitchen,0.5f);
                            break;
                        case 10:
                            screenEventManager.GetComponent<TalkNameManager>().ChangeName("???");
                            screenEventManager.GetComponent<HayoulManager>().BeDark();
                            screenEventManager.GetComponent<HayoulManager>().HayoulGetIn();
                            break;
                        case 11:
                            screenEventManager.GetComponent<TalkNameManager>().ChangeName("나");
                            break;
                        case 14:
                            screenEventManager.GetComponent<TalkNameManager>().ChangeName("???");
                            break;
                        case 15:
                            screenEventManager.GetComponent<TalkNameManager>().ChangeName("나");
                            break;
                        case 16:
                            screenEventManager.GetComponent<TalkNameManager>().ChangeName("???");
                            break;
                        case 18:
                            screenEventManager.GetComponent<TalkNameManager>().ChangeName("나");
                            break;
                        case 19:
                            screenEventManager.GetComponent<HayoulManager>().BeLight();
                            screenEventManager.GetComponent<TalkNameManager>().ChangeName("하율");
                            break;
                        case 20:
                            screenEventManager.GetComponent<TalkNameManager>().ChangeName("나");
                            break;
                    }
                    _startTyping = TypingText(progress - animationMinus); 
                    playingCheck = true; 
                    StartCoroutine(_startTyping);
                }
                else
                { 
                    StopCoroutine(_startTyping);
                    talkTextUI.text = _write[progress - animationMinus]; 
                    playingCheck = false;
                }
            }
            else
            { 
                switch (progress + animationMinus) //nextprograss()일때 대사를 진행시키지 않으면서 애니메이션만 재생하는 Progress
                {
                    case 3:
                        screenEventManager.GetComponent<BlackFade>().fadeTime = 0.5f;
                        screenEventManager.GetComponent<BlackFade>().StartCoroutine("BlackFadeOut", 0.5f);
                        screenEventManager.GetComponent<BackGroundManager>().ChangeImg(BackGroundManager.BackGroundImages.Street,0.5f);
                        animationMinus++;
                        break;
                    case 25:
                        SaveManager.SaveData.IsFirst = false;
                        PlayerData.SaveInSlot1(SaveManager.SaveData);
                        SceneManager.LoadScene("DayPlan");
                        break;
                }
            }
        }

        private IEnumerator TypingText(int progress)
        {
            for (var i = 0; i < _write[progress].Length + 1; i++)
            {
                var pageText = _write[progress][..i];
                talkTextUI.text = pageText;
                yield return _time;
            }
            playingCheck = false;
        }

        private void NextTime()
        {
            if (PlanDropdownManager.IsMorning)
            {
                PlanDropdownManager.IsMorning = false;
                PlanDropdownManager.IsLunch = true;
            }
            else if (PlanDropdownManager.IsLunch)
            {
                PlanDropdownManager.IsLunch = false;
                PlanDropdownManager.IsNight = true;
            }
            else
            {
                // dayEnd를 따로 구현하자.이게 night가 끝난거니까
            }
        }
    }
}
