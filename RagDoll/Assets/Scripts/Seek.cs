using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : SteeringBehavior
{
    public bool arrival = false;
    public float slowingRadius;
    public float distance;
    
    public override Vector3 GetForce()
    {
        distance = Vector3.Distance(target, position);
        if (distance < 20)
        {
            //transform.LookAt(target);
        desiredVelocity = (target - position).normalized * speed;
        
        if (arrival)
        {
            if (distance < slowingRadius)
            {
                desiredVelocity = desiredVelocity.normalized * speed * (distance / slowingRadius);
            }
            else
            {
                desiredVelocity = desiredVelocity.normalized * speed;
            }
        }

        transform.position += velocity * Time.deltaTime;
        Vector3 steering = desiredVelocity - velocity;
        velocity = Vector3.ClampMagnitude(velocity + steering, speed);
        return steering;
            
        }

        return Vector3.zero;


    }
}
