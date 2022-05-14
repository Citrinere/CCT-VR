using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Red : MonoBehaviour
{

    public bool isDestroyed;

    // Start is called before the first frame update
    void Start()
    {
        isDestroyed = false;    
    }

    // Update is called once per frame
    void Update()
    {
        if (isDestroyed == true)
        {
            Debug.Log("Red was Destroyed.");
            ScoreManager.instance.AddPoints("Red");
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
