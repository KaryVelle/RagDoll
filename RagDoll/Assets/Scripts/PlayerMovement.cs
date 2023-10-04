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
    [SerializeField] float mouseY;
    public CharacterController cc;
    private Vector3 moveDirection = Vector3.zero;

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
        mouseY = Input.GetAxis("Mouse Y");
        Vector3 move = transform.right * x +
                        transform.forward * z;
       
        rb.transform.Rotate( 0, mouseX, 0);
        cc.Move(move * speed * Time.deltaTime);

        if (cc.isGrounded)
        {
            moveDirection = move * speed;
        }
        else
        {
            // Si el personaje no está en el suelo, aplicar gravedad
            moveDirection += Physics.gravity * 9.81f * Time.deltaTime;
        }

        cc.Move(moveDirection * Time.deltaTime);
    }
}
