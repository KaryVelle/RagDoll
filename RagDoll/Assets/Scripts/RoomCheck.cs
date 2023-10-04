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
        for(int i=obsController.obstacleList.Count - 1; i>=0; i--)
        {
            if (obsController.obstacleList[i].gameObject == null)
            {
                Destroy(obsController.obstacleList[i].gameObject);
                obsController.obstacleList.RemoveAt(i);
            }
        }

        JointLimits limits = door.limits;
        if (obsController.obstacleList.Count == 0)
        {
            limits.min = -180;
            limits.max = 180;
            door.limits = limits;
        }
    }
        
}
    
