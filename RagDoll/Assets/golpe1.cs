using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golpe1 : MonoBehaviour
{
    public Transform target1;
    public Transform target2;
    public int golpeDistance;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d"))
        {
            target1.transform.position = new Vector3(target1.transform.position.x + golpeDistance, 
                target1.transform.position.y + 0, 
                target1.transform.position.z + 0
                );
        }
        if (Input.GetKeyUp("d"))
        {
            target1.transform.position = new Vector3(target1.transform.position.x, 
                target1.transform.position.y + 0, 
                target1.transform.position.z + 0
            );
        }
        
        if (Input.GetKeyDown("a"))
        {
            target1.transform.position = new Vector3(target2.transform.position.x + golpeDistance, 
                target2.transform.position.y , 
                target2.transform.position.z
            );
        }
        if (Input.GetKeyUp("a"))
        {
            target1.transform.position = new Vector3(target2.transform.position.x , 
                -1.52f, 
                target2.transform.position.z 
            );
        }
    }
}
