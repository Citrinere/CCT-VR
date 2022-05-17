using UnityEngine;
using System.Collections;
 
public class RealtimeReflection : MonoBehaviour 
{
    ReflectionProbe probe;
 
    void Awake() 
    {
        probe = GetComponent<ReflectionProbe>();
    }
 
    void Update () 
    {
        probe.transform.position = Camera.main.transform.position;
        probe.RenderProbe();
    }
}