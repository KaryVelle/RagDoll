using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCheck : MonoBehaviour
{
    public HingeJoint door;
    public ObstacleController obsController;
    

    void Update()
    {
        
        JointLimits limits = door.limits;
        if (obsController.obstacleList.Count == 0)
        {
            limits.min = -180;
            limits.max = 180;
            door.limits = limits;
        }
    }
        
}
    
