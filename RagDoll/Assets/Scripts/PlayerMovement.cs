using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   public Rigidbody player;
   public int speed;

    [SerializeField] Rigidbody rb;
    [SerializeField] int speed;
    [SerializeField] float mouseX;
    public CharacterController cc;
    

      float mouseX = Input.GetAxis("Mouse X");
      player.transform.Rotate(new Vector3(0,mouseX,0));

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
