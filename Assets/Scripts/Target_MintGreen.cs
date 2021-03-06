using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_MintGreen : MonoBehaviour
{
    public bool isDestroyed;
    float xStart;
    float xChange;

    public Vector3 playerPosition;

    // Start is called before the first frame update
    void Start()
    {
        isDestroyed = false;
        xStart = transform.position.x;
        xChange = Random.Range(-1f, 1f) * Time.deltaTime;
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        TargetRotation();

        float xNew = transform.position.x + xChange;

        transform.position = new Vector3(xNew, transform.position.y, transform.position.z);

        if ((xNew > xStart + 4) || (xNew < xStart - 3))
        {
            xChange = -1 * xChange;
        }


        if (isDestroyed == true)
        {
            Debug.Log("Mint-Green was Destroyed.");
            ScoreManager.instance.AddPoints("Mint-Green");
            RandomTargetSpawner.instance.TargetDestroyed("Mint-Green");
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
