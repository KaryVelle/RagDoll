using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCheck : MonoBehaviour
{
    public HingeJoint door;
    public ObstacleController obsController;
    private JointMotor motor;
    public bool door2;
   // public AudioSource rasputin;


    private void Start()
    {
        motor = door.motor;
       // rasputin.Pause();
       motor.targetVelocity = 100;
       motor.force = 1000;
       door.motor = motor;
    }

    void Update()
    {
        for(int i=obsController.obstacleList.Count - 1; i>=0; i--)
        {
            if (obsController.obstacleList[i].gameObject == null)
            {
                Destroy(obsController.obstacleList[i].gameObject);
                obsController.obstacleList.RemoveAt(i);
            }
        }

       
        if (obsController.obstacleList.Count == 0)
        {
            OpenDoor();
            
            
          
        }
        
        
    }

    private void OpenDoor()
    {
       /* JointLimits limits = door.limits;
        limits.min = -180;
        limits.max = 180;
        door.limits = limits;
        motor.targetVelocity = -5000f;
        door.motor = motor;
        Debug.Log("ABRETE");
      //  rasputin.Play();*/

      
    }

}
    
