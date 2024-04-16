using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody PlayerRigidBody;   //플레이어 오브젝트에 있는 RigidBody 컴포넌트를 연결하기 위한 변수
    public float speed = 8f;   //이동 속도 수치 값을 저장하는 변수

    // Start is called before the first frame update
    void Start()
    {
        PlayerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {  /*
        if (Input.GetKey(KeyCode.UpArrow))
        {
            PlayerRigidBody.AddForce(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            PlayerRigidBody.AddForce(0, 0, -speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            PlayerRigidBody.AddForce(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            PlayerRigidBody.AddForce(-speed, 0, 0);
        }
       */
        //수평축과 수직축의 입력값을 감지하여 저장
        float xlnput = Input.GetAxis("Horizontal");
        float zlnput = Input.GetAxis("Vertical");

        float xSpeed = xlnput * speed;
        float zSpeed = zlnput * speed;

        Vector3 newVelcity = new Vector3(xSpeed, 0f, zSpeed);

        PlayerRigidBody.velocity = newVelcity;



    }
    public void Die()     //플레이어 캐릭터가 사망시 호출되고 이부분 내용이 처리됨.
    {
        gameObject.SetActive(false);
    }     
    
}