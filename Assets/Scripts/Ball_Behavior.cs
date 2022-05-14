using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Behavior : MonoBehaviour
{
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Red")
        {
            Debug.Log("Red got Hit.");
            Destroy(gameObject, 2f);
        }
        if (collisionInfo.collider.tag == "Blue")
        {
            Debug.Log("Blue got Hit.");
            Destroy(gameObject, 2f);
        }
        if (collisionInfo.collider.tag == "Yellow")
        {
            Debug.Log("Yellow got Hit.");
            Destroy(gameObject, 2f);
        }
        if (collisionInfo.collider.tag == "Light-Blue")
        {
            Debug.Log("Light-Blue got Hit.");
            Destroy(gameObject, 2f);
        }
        if (collisionInfo.collider.tag == "Mint-Green")
        {
            Debug.Log("Mint-Green got Hit.");
            Destroy(gameObject, 2f);
        }
        if (collisionInfo.collider.tag == "Ground")
        {
            Debug.Log("Ball verlässt Spawn");
            Destroy(gameObject, 8f);
        }
    }
}
