using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody PlayerRigidBody;   //�÷��̾� ������Ʈ�� �ִ� RigidBody ������Ʈ�� �����ϱ� ���� ����
    public float speed = 8f;   //�̵� �ӵ� ��ġ ���� �����ϴ� ����

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
        //������� �������� �Է°��� �����Ͽ� ����
        float xlnput = Input.GetAxis("Horizontal");
        float zlnput = Input.GetAxis("Vertical");

        float xSpeed = xlnput * speed;
        float zSpeed = zlnput * speed;

        Vector3 newVelcity = new Vector3(xSpeed, 0f, zSpeed);

        PlayerRigidBody.velocity = newVelcity;



    }
    public void Die()     //�÷��̾� ĳ���Ͱ� ����� ȣ��ǰ� �̺κ� ������ ó����.
    {
        gameObject.SetActive(false);
    }     
    
}