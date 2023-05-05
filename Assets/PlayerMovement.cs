using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public static float moveSpeed = 20f;
    public static int lives = 3;
    public float turnSpeed = 180f;
    private Rigidbody rigidbody;
    private float movementInputValue;
    private float turnInputValue;
    public Text text;
    public AudioSource crash;

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
 
    private void OnCollisionEnter(Collision other){
        print("Collision Detected");
        if(other.gameObject.tag == "Fence"){
            lives -= 1;
            crash.Play();
            if( lives == 0 ){
                lives = 3;
                SceneManager.LoadScene(1);
            }
            text.text = "Lives: " + lives.ToString();
            Destroy(other.gameObject);
        }
    }
}
