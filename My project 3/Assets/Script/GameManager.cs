using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;                   //���ӿ��� �� Ȱ��ȭ�� �ؽ���
    public Text timetext;                             // ���� �ð��� ǥ���� �ؽ�Ʈ ������Ʈ
    public Text recordText;                           // �ְ� ����� ǥ���� �ؽ�Ʈ ������Ʈ

    private float surviveTime;                        // �����ð�
    private bool isGameover;                          // ���� ���� ���� (true == ����
    // Start is called before the first frame update
    void Start()
    {
        surviveTime = 0;
        isGameover = false;        
    }

    // Update is called once per frame
    void Update()
    {
        // ���� ������ �ƴ� ����
        if (!isGameover)
        {
            // ���� �ð� ����
            surviveTime += Time.deltaTime;

            //������ ���� �ð��� timeText �ؽ�Ʈ ������Ʈ�� �̿��� ǥ��
            timetext.text = "Time : " + (int)surviveTime;
        }
        else
        {
            gameoverText.SetActive(true);

            //���ӿ��� ���¿���  R�� ���� ���
            if (Input.GetKey(KeyCode.R))
            {
                //SampleScene ���� 
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    public void EndGame()
    {
        //���� ���¸� ���� ���� ���·� ��ȯ
        isGameover = true;
        //���� ���� �ؽ�Ʈ ���� ������Ʈ�� Ȱ��ȭ
        gameoverText.SetActive(true);

        //BestTime Ű�� ����� ���������� �ְ� ��� ��������
        float bestTime = PlayerPrefs.GetFloat("BestTime");

        //���������� �ְ� ��Ϻ��� ���� ���� �ð��� �� ũ��
        if (surviveTime > bestTime)
        {
            //�ְ� ��� ���� ���� ���� �ð� ������ ����
            bestTime = surviveTime;
            //����� �ְ� ������� Bset TimeŰ�� ����

            PlayerPrefs.SetFloat("BestTime", bestTime);
        }

        recordText.text = "Best Time :" + (int)bestTime;
    }

}

