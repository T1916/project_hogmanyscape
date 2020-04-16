using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ArrowSpawner : MonoBehaviour
{

    [SerializeField]
    private float xLimit;
    [SerializeField]
    private float[] xPositions;
    [SerializeField]
    private Wave[] wave;
    [SerializeField]
    private GameObject arrowPrefab;

    private float currentTime;

    List<float> remainingPositions = new List<float>();
    private int waveIndex;
    float xPos = 0;
    int rand;

    public object ObjectPooling { get; private set; }
    void DestroyObjectDelayed()
    {
        // Kills the game object in 5 seconds after loading the object
        Destroy(gameObject, 5);
    }
    

    // Use this for initialization
    void Start()
    {
        currentTime = 0;
        remainingPositions.AddRange(xPositions);
    }

    // Update is called once per frame
    void Update()
    {
            currentTime -= Time.deltaTime;
            if (currentTime <= 0)
            {
                SelectWave();
            }

 
        
    }

    void SpawnEnemy(float xPos)
    {
        GameObject enemyObj = Instantiate(arrowPrefab, new Vector3(xPos, transform.position.y, 0), Quaternion.identity);
    }

    void SelectWave()
    {
        remainingPositions = new List<float>();
        remainingPositions.AddRange(xPositions);

        waveIndex = Random.Range(0, wave.Length);

        currentTime = wave[waveIndex].delayTime;

        if (wave[waveIndex].spawnAmount == 1)
            xPos = Random.Range(-xLimit, xLimit);
        else if (wave[waveIndex].spawnAmount > 1)
        {
            rand = Random.Range(0, remainingPositions.Count);
            xPos = remainingPositions[rand];
            remainingPositions.RemoveAt(rand);
        }

        for (int i = 0; i < wave[waveIndex].spawnAmount; i++)
        {
            SpawnEnemy(xPos);
            rand = Random.Range(0, remainingPositions.Count);
            xPos = remainingPositions[rand];
            remainingPositions.RemoveAt(rand);
        }
    }

}

[System.Serializable]
public class Wave
{
    public float delayTime;
    public float spawnAmount;
}