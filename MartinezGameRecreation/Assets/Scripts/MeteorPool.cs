using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorPool : MonoBehaviour
{
    public int meteorPoolSize = 5;
    public GameObject meteorPrefab;
    public float spawnRate = 4f;
    public float meteorMin = -1f;
    public float meteorMax = 3.5f;

    private GameObject[] meteors;
    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    private float timeSinceLastSpawned;
    private float spawnXPosition = 10f;
    private int currentMeteor = 0;
    // Start is called before the first frame update
    void Start()
    {
        meteors = new GameObject[meteorPoolSize];
        for (int i = 0; i < meteorPoolSize; i++)
        {
            meteors[i] = (GameObject)Instantiate(meteorPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;
        if (GameController.instance.gameOver == false  && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0f;
            float spawnYPosition = Random.Range (meteorMin, meteorMax);
            meteors[currentMeteor].transform.position = new Vector2 (spawnXPosition, spawnYPosition);
            currentMeteor++;
            if (currentMeteor >= meteorPoolSize)
            {
                currentMeteor = 0;
            }
        }
    }
}
