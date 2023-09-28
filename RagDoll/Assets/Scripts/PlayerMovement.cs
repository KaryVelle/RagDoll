using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] Rigidbody rb;
    [SerializeField] int speed;
    [SerializeField] float mouseX;
    

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d"))
        {
            rb.velocity= (new Vector3(1 * speed,0, 0) );
        }
        if (Input.GetKeyDown("a"))
        {
            rb.velocity = (new Vector3(1 * speed *-1, 0, 0));
        }
        if (Input.GetKeyDown("w"))
        {
            rb.velocity = (new Vector3(0 , 0, 1 * speed));
        }
        if (Input.GetKeyDown("s"))
        {
            rb.velocity = (new Vector3(0, 0, 1 * speed *-1));
        }

        mouseX = Input.GetAxis("Mouse X");
       
        rb.transform.Rotate(0, mouseX, 0);

    }
}
