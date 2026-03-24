using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform playerTransform;
    public GameObject bullet;

    private float spawnRateMin = 0.5f;
    private float spawnRateMax = 3f;

    private float spawnRate;
    private float timeAfterSpawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerTransform = GameObject.FindWithTag("Player")?.transform;

        spawnRate = Random.Range(spawnRateMax, spawnRateMax);
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;

        if (timeAfterSpawn >= spawnRate)
        {
            timeAfterSpawn = 0;
            SpawnBullet();
        }
    }

    void SpawnBullet()
    {
        bullet.transform.position = transform.position;
        bullet.transform.LookAt(playerTransform);
        Instantiate(bullet);
    }
}
