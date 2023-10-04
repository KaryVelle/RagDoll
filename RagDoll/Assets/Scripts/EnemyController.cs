using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform target;
    public Seek seek;

    private void Update()
    {
        seek.target = target.position;
    }
}
