using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] float mouseX;
    [SerializeField] float mouseY;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X"); 
        mouseY = Input.GetAxis("Mouse Y");
        cam.transform.Rotate(0, mouseX, 0);
       
    }
}
