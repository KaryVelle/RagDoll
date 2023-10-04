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

   private void Update()
   {
      if (Input.GetKeyDown("w"))
      {
        player.velocity = Vector3.forward * speed;
      }
      
      if (Input.GetKeyDown("s"))
      {
          player.velocity = Vector3.forward * -1 * speed;
      }
      
      if (Input.GetKeyDown("d"))
      {
          player.velocity = Vector3.right * speed ;
      }
      if (Input.GetKeyDown("a"))
      {
          player.velocity = Vector3.right * speed *-1;
      }

      float mouseX = Input.GetAxis("Mouse X");
      player.transform.Rotate(new Vector3(0,mouseX,0));







   }
}
