using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_LightBlue : MonoBehaviour
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
            Debug.Log("Light-Blue was Destroyed.");
            ScoreManager.instance.AddPoints("Light-Blue");
            RandomTargetSpawner.instance.TargetDestroyed("Light-Blue");
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
