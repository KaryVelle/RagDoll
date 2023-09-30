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
    public CharacterController cc;
    

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        mouseX = Input.GetAxis("Mouse X");
        Vector3 move = transform.right * x + transform.forward * z;
       
        rb.transform.Rotate(0, mouseX, 0);
        cc.Move(move * speed * Time.deltaTime);



    }
}
