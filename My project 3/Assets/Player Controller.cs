using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody PlayerRigidBody;   //�÷��̾� ������Ʈ�� �ִ� RigidBody ������Ʈ�� �����ϱ� ���� ����
    public float speed = 8f;   //�̵� �ӵ� ��ġ ���� �����ϴ� ����

    // Start is called before the first frame update
    void Start()
    {
        PlayerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
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
    }


    public void Die()     //�÷��̾� ĳ���Ͱ� ����� ȣ��ǰ� �̺κ� ������ ó����.
    {
        gameObject.SetActive(false);
    }     
    
}