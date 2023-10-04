using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class ObstacleController : MonoBehaviour
{
  public GameObject obstacle;
  public float radio;
  public List<GameObject> obstacleList;
  public List<Vector3> ObstaclePosition;
  public float maxSpawn;
  public float [] rangoX;
  public float [] rangoZ;

  private void Start()
  {
    float total = Random.Range(1, maxSpawn);
    
    for (int i = 0; i <= total; i++)
    {
      Vector3 randomPos = new Vector3(Random.Range(rangoX[0], rangoX[1]), 1f, Random.Range(rangoZ[0],rangoZ[1]));
      if (IsPositionEmpty(randomPos))
      {
        GameObject NewInst = Instantiate(obstacle, randomPos, Quaternion.identity);
        obstacleList.Add(NewInst);
        ObstaclePosition.Add(NewInst.transform.position);
      }
    }
  }
  
  bool IsPositionEmpty(Vector3 position)
  {
    foreach (var obstacle in obstacleList)
    {
      if (Vector3.Distance(position, obstacle.transform.position) < radio)
      {
        return false;
      }
    }

    return true;
  }

}
