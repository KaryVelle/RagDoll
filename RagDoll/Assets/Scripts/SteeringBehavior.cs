using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class SteeringBehavior : MonoBehaviour
{
    public float speed;
    public Vector3 desiredVelocity;
    public Vector3 velocity;
    public Vector3 position;
    public Vector3 target;
    public abstract Vector3 GetForce();
    
}
