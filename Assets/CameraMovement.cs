using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform carPosition;
    private float diffX;
    private float diffY;
    private float diffZ;

    // Start is called before the first frame update
    void Start()
    {
        diffX = carPosition.position.x - transform.position.x;
        diffY = carPosition.position.y - transform.position.y;
        diffZ = carPosition.position.z - transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        float x = carPosition.position.x - diffX;
        float y = carPosition.position.y - diffY;
        float z = carPosition.position.z - diffZ;
        transform.position = new Vector3(x,y,z);
    }
}
