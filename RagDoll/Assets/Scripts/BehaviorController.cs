using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviorController : MonoBehaviour
{
    public List<SteeringBehavior> behaviors = new List<SteeringBehavior>();
    public Rigidbody rigidBody;
    public Vector3 velocity;
    public Vector3 totalForce = Vector3.zero;

    void FixedUpdate()
    {
        //inicializando en ceros
        totalForce = Vector3.zero;

        //Sacar el vector de la fuerza
        foreach ( SteeringBehavior behavior in behaviors)
        {
            if(behavior.target != null)
            {
                transform.LookAt(behavior.target);
            }
            behavior.position = transform.position;
            totalForce += behavior.GetForce();
        }

        velocity += totalForce;
        transform.position += velocity * Time.deltaTime;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -50, 50), Mathf.Clamp(transform.position.y, -3, 3), Mathf.Clamp(transform.position.z, -53,48));
        
    }
}
