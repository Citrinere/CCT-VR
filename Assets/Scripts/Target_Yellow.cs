using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Yellow : MonoBehaviour
{
    public bool isDestroyed;
    float yStart;
    float yChange;
    
    
    // Start is called before the first frame update
    void Start()
    {
        isDestroyed = false;
        yStart = transform.position.y;
        yChange = Random.Range(-1f, 1f) * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        float yNew = transform.position.y + yChange;

        transform.position = new Vector3(transform.position.x, yNew, transform.position.z);

        if((yNew > yStart + 3) || (yNew < yStart -2))
        {
            yChange = -1 * yChange;
        }

        if (isDestroyed == true)
        {
            Debug.Log("Yellow was Destroyed.");
            ScoreManager.instance.AddPoints("Yellow");
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
}
