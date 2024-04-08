using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buiiet : MonoBehaviour
{
    public float speed = 8f;  //탄알의 이동 속력
    private Rigidbody bulletRigidbody;  // 이동에 사용할 Rigidbody 컴포넌트

    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed;
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("충돌 시작");
        if (other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();

            if (playerController != null)
            {
                playerController.Die();
            }


        }
    }
}