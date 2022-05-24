using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_LightBlue : MonoBehaviour
{
    public bool isDestroyed;
    float xStart;
    float xChange;
    float yStart;
    float yChange;

    public Vector3 playerPosition;

    // Start is called before the first frame update
    void Start()
    {
        isDestroyed = false;
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
        xStart = transform.position.x;
        xChange = Random.Range(1f, 2f) * Time.deltaTime;
        yStart = transform.position.y;
        yChange = Random.Range(1f, 2f) * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        TargetRotation();

        //MoveUpDown();
        //MoveLeftRight();
        MoveDiagonal();

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

    //void MoveLeftRight()
    //{
    //    float xNew = transform.position.x + xChange;

    //    transform.position = new Vector3(xNew, transform.position.y, transform.position.z);

    //    if ((xNew > xStart + 3) || (xNew < xStart - 2))
    //    {
    //        xChange = -1 * xChange;
    //    }
    //}

    //void MoveUpDown()
    //{
    //    float yNew = transform.position.y + yChange;

    //    transform.position = new Vector3(transform.position.x, yNew, transform.position.z);

    //    if ((yNew > yStart + 3) || (yNew < yStart - 2))
    //    {
    //        yChange = -1 * yChange;
    //    }
    //}

    void MoveDiagonal()
    {
        float yNew = transform.position.y + yChange;
        float xNew = transform.position.x + xChange;

        transform.position = new Vector3(xNew, yNew, transform.position.z);

        if (((xNew > xStart + 3) || (xNew < xStart - 2)) && ((yNew > yStart + 3) || (yNew < yStart - 2)))
        {
            yChange = -1 * yChange;
            xChange = -1 * xChange;
        }
    }
}
