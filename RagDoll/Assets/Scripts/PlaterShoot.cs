using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaterShoot : MonoBehaviour
{
    public float speed = 50;
    public GameObject projectile;
    public Transform gun;
    private Rigidbody rb;
 
 
 
    // Use this for initialization
    void Start ()
    {
        rb = projectile.GetComponent<Rigidbody>();
    }
   
    // Update is called once per frame
    void Update () {
 
        if (Input.GetButtonDown("Fire1"))
        {
            
            GameObject instantiatedProjectile = Instantiate(projectile, gun.position, Quaternion.identity);

           
            Rigidbody rb = instantiatedProjectile.GetComponent<Rigidbody>();

            
            rb.velocity = transform.forward * speed;

           
            Destroy(instantiatedProjectile, 2);
        }
    }
}
