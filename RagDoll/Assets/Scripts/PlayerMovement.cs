using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] int speed;
    [SerializeField] float mouseX;
    public CharacterController cc;
    private Vector3 moveDirection = Vector3.zero;

   
    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        mouseX = Input.GetAxis("Mouse X");
        Vector3 move = transform.right * x +
                        transform.forward * z;
       
        transform.Rotate( 0, mouseX, 0);
      

        if (cc.isGrounded)
        {
            moveDirection = move * speed;
        }
        else
        {
            // Si el personaje no está en el suelo, aplicar gravedad
            moveDirection += Physics.gravity * 9.81f;
        }

        cc.Move(moveDirection * Time.deltaTime);
    }
}
