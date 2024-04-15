using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buiiet : MonoBehaviour
{
    public float speed = 8f;  //ź���� �̵� �ӷ�
    private Rigidbody bulletRigidbody;  // �̵��� ����� Rigidbody ������Ʈ

    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed;
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("�浹 ����");
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