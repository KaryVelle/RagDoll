using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaterShoot : MonoBehaviour
{
    public float speed = 20;
    public Rigidbody projectile;
    public Transform gun;
 
 
 
    // Use this for initialization
    void Start () {
   
    }
   
    // Update is called once per frame
    void Update () {
 
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody instantiatedProjectile = Instantiate(projectile,
                    gun.position ,Quaternion.identity
                   );
 
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0,speed));
            Destroy(projectile, 3);
        }
    }
}
