using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 12f;
    public float turnSpeed = 180f;
    private Rigidbody rigidbody;

    private float movementInputValue;
    private float turnInputValue;

    void Awake(){
       rigidbody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        rigidbody.isKinematic = false;

        movementInputValue = 0f;
        turnInputValue = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        movementInputValue = Input.GetAxis("Vertical");
        turnInputValue = Input.GetAxis("Horizontal");

        Vector3 movement = transform.forward * moveSpeed * movementInputValue * Time.deltaTime;
        rigidbody.MovePosition(rigidbody.position + movement);

        float turn = turnInputValue * turnSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f,turn,0f);
        rigidbody.MoveRotation(rigidbody.rotation * turnRotation);
    }
}
