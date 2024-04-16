using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotarionSpeed = 60f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, rotarionSpeed, 0f);
    }
}
