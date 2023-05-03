using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform carPosition;
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        difference = carPosition.position.z - transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x;
        float y = transform.position.y;
        float z = carPosition.position.z - difference;
        transform.position = new Vector3(x,y,z);
    }
}
