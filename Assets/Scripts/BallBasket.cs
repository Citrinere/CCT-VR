using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallBasket : MonoBehaviour
{
    public GameObject ballObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) // = A-Button  ("Button.one" laut Oculus) 
        {
            spawnBall();
        }
    }

    public void spawnBall()
    {
        Instantiate(ballObject, transform.position, transform.rotation);
        Debug.Log("Ball spawned.");
    }
}
