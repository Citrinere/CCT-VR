using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTargetSpawner : MonoBehaviour
{

    public GameObject[] myTargets;

    int xSpawnPos;
    int ySpawnPos;
    int zSpawnPos, zSpawnNeg;
    Vector3 objectRotation = new Vector3(90, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            int RandomIndex = Random.Range(0, myTargets.Length);

            xSpawnPos = Random.Range(4, 11);
            //if(xSpawnPos < 4 && xSpawnPos > -4)
            //    xSpawnPos = Random.Range(-10, 11);

            ySpawnPos = Random.Range(2, 3);

            zSpawnPos = Random.Range(4, 11);
            zSpawnNeg = Random.Range(-4, -11);

            Vector3 randomSpawnposition = new Vector3(Random.Range(xSpawnPos, zSpawnNeg), ySpawnPos, Random.Range(zSpawnPos, zSpawnNeg));

            Instantiate(myTargets[RandomIndex], randomSpawnposition, transform.rotation*Quaternion.Euler(90f,0f,0f));
            Debug.Log("New Target has spawned");
        }
    }
}
