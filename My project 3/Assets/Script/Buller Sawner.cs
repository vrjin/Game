using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner: MonoBehaviour
{
    public GameObject bulleprefab;
    public float spawnReteMin = 0.5f;
    public float spawnReteMax = 3f;

    private Transform target;
    private float spawnRate;
    private float timeAfterspwn;
    // Start is called before the first frame update
    void Start()
    {
        timeAfterspwn = 0f;
        spawnRate = Random.Range(spawnReteMin, spawnReteMax);
        target = FindAnyObjectByType<PlayerController>().transform;

    }

    // Update is called once per frame
    void Update()
    {
        timeAfterspwn += Time.deltaTime;

        if (timeAfterspwn > spawnRate) 
        {
            timeAfterspwn = 0;

            GameObject buiiet = Instantiate(bulleprefab, transform.position, transform.rotation); 

            buiiet.transform.LookAt(target);

            spawnRate = Random.Range(spawnReteMin, spawnReteMax);
        }
    }
}
