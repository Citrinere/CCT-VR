using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TennisRacket : MonoBehaviour
{

    float force = 3f;
    bool ballhit;

    // Start is called before the first frame update
    void Start()
    {
        ballhit = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Check if Racket hits a Ball
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "balls")
        {
            hitBall();
        }
    }

    // Hitting the Ball with Backforce
    void hitBall ()
    {
        
    }
}
