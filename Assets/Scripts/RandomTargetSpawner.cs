using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTargetSpawner : MonoBehaviour
{
    public static RandomTargetSpawner instance;

    public GameObject[] myTargets;
    int targetCounter;

    int ySpawnPos;
    int xzSpawnPos, xzSpawnNeg;
    public float[] randomRotation = new float[] { 0, 30, 45, 90 };
    Vector3 randomSpawnposition;

    float timeValue;
    bool resetTime;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        targetCounter = 6;
        for(int i = 0; i <= targetCounter; i++)
        {
            SpawnTarget();
            Debug.Log("Starting Targets have been spawned");
        }
        
        timeValue = 12;
        resetTime = false; 
    }

    // Update is called once per frame
    void Update()
    {

        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
            resetTime = true;
            Debug.Log("Spawn Time over");
        }

        if (timeValue == 0) // Für eingabe mit Leertaste : Input.GetKeyDown(KeyCode.Space)
        {
            SpawnTarget();
            targetCounter++;
        }

        if(resetTime == true)
        {
            ResetSpawnTime();
        }
    }

    void SpawnTarget()
    {
        if (targetCounter >= 12)
        {
            Debug.Log("To Many Targets on the Field");
        }
        else
        { 
            int RandomIndex = Random.Range(0, myTargets.Length);

            ySpawnPos = Random.Range(3, 5);
            xzSpawnPos = Random.Range(7, 11);
            xzSpawnNeg = Random.Range(-11, -7);
            
            randomSpawnposition = new Vector3(Random.Range(xzSpawnNeg, xzSpawnPos), ySpawnPos, Random.Range(xzSpawnNeg, xzSpawnPos));

            if (randomSpawnposition.x < 7 || randomSpawnposition.x > -7)
            {
                randomSpawnposition = new Vector3(Random.Range(xzSpawnNeg, xzSpawnPos), ySpawnPos, Random.Range(xzSpawnNeg, xzSpawnPos));
            }
            else if (randomSpawnposition.z < 7 || randomSpawnposition.z > -7)
            {
                randomSpawnposition = new Vector3(Random.Range(xzSpawnNeg, xzSpawnPos), ySpawnPos, Random.Range(xzSpawnNeg, xzSpawnPos));
            }

            Instantiate(myTargets[RandomIndex], randomSpawnposition, transform.rotation);
            Debug.Log("New Target has spawned");
        }
    }

    public void TargetDestroyed(string targetname)
    {
        if (targetname == "Red")
        {
            targetCounter -= 1;
            Debug.Log("-1 Target, " + targetCounter + " are left.");
        }
        if (targetname == "Mint-Green")
        {
            targetCounter -= 1;
            Debug.Log("-1 Target, " + targetCounter + " are left.");
        }
        if (targetname == "Yellow")
        {
            targetCounter -= 1;
            Debug.Log("-1 Target, " + targetCounter + " are left.");
        }
        if (targetname == "Light-Blue")
        {
            targetCounter -= 1;
            Debug.Log("-1 Target, " + targetCounter + " are left.");
        }
        if (targetname == "Blue")
        {
            targetCounter -= 1;
            Debug.Log("-1 Target, " + targetCounter + " are left.");
        }
    }

    void ResetSpawnTime()
    {
        resetTime = false;
        timeValue = 12;
        Debug.Log("Reset Targetspawn Time");
    }

}
