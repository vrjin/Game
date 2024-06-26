using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;                   //게임오버 시 활성화할 텍스쳐
    public Text timetext;                             // 생존 시간을 표시할 텍스트 컴포넌트
    public Text recordText;                           // 최공 기록을 표시할 텍스트 컴포넌트

    private float surviveTime;                        // 생존시간
    private bool isGameover;                          // 게임 오버 상태 (true == 게임
    // Start is called before the first frame update
    void Start()
    {
        surviveTime = 0;
        isGameover = false;        
    }

    // Update is called once per frame
    void Update()
    {
        // 게임 오버가 아닌 동안
        if (!isGameover)
        {
            // 생존 시간 갱신
            surviveTime += Time.deltaTime;

            //갱신한 생존 시간을 timeText 텍스트 컴포넌트를 이용해 표시
            timetext.text = "Time : " + (int)surviveTime;
        }
        else
        {
            gameoverText.SetActive(true);

            //게임오버 상태에서  R를 누른 경우
            if (Input.GetKey(KeyCode.R))
            {
                //SampleScene 으로 
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    public void EndGame()
    {
        //현재 상태를 게임 오버 상태로 전환
        isGameover = true;
        //게임 오버 텍스트 게임 오브젝트를 활성화
        gameoverText.SetActive(true);

        //BestTime 키로 저장된 이전까지의 최고 기록 가져오기
        float bestTime = PlayerPrefs.GetFloat("BestTime");

        //이전까지의 최고 기록보다 현재 생존 시간이 더 크며
        if (surviveTime > bestTime)
        {
            //최고 기록 값을 현재 생존 시간 값으로 변경
            bestTime = surviveTime;
            //변경된 최고 기록을을 Bset Time키로 설정

            PlayerPrefs.SetFloat("BestTime", bestTime);
        }

        recordText.text = "Best Time :" + (int)bestTime;
    }

}

