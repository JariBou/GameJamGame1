using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScirpt : MonoBehaviour
{

    public GameObject target;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var position = target.transform.position;
        var transform1 = transform;
        transform1.position =
            new Vector3(position.x, position.y, transform1.position.z);
    }
}
