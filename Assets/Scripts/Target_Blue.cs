using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Blue : MonoBehaviour
{
    public bool isDestroyed;

    public Vector3 playerPosition;

    // Start is called before the first frame update
    void Start()
    {
        isDestroyed = false;
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        TargetRotation();

        if (isDestroyed == true)
        {
            Debug.Log("Blue was Destroyed.");
            ScoreManager.instance.AddPoints("Blue");
            RandomTargetSpawner.instance.TargetDestroyed("Blue");
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Balls")
        {
            isDestroyed = true;
        }
    }

    void TargetRotation()
    {
        Vector3 lookVector = playerPosition - transform.position;

        transform.rotation = Quaternion.LookRotation(lookVector);
    }
}
