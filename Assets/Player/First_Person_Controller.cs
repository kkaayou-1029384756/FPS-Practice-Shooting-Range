using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Threading;
using Unity.Collections;
using UnityEngine;


public class First_Person_Controller : MonoBehaviour
{
    
    public GameObject Camera;
    public float verticalRotation = 0.0f;
    public float speed = 4.0f;
    public float sensitivity = 1.0f;
    public float jumpforce = 5.0f;
    public float gravity = -20.0f;

    Vector3 finalVelocity;

    float yVelocity;
    private CharacterController characterController;


    void Start() {
        yVelocity = 0;
        characterController = GetComponent<CharacterController>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    


    void Update()
    {
        float vertical = Input.GetAxis("Vertical") * speed; 
        float horizontal = Input.GetAxis("Horizontal") * speed;
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 8;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 5;
        }

        if (characterController.isGrounded)
        {
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                yVelocity = jumpforce;
            }
        }

        float mX = Input.GetAxis("Mouse X") * sensitivity;
        float mY = Input.GetAxis("Mouse Y") * sensitivity;

        verticalRotation += mY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90.0f, 90.0f);

        transform.Rotate(Vector3.up * mX);
        Camera.transform.localRotation = Quaternion.Euler(-verticalRotation, 0.0f, 0.0f);
        yVelocity += gravity * Time.deltaTime;
        finalVelocity = new Vector3(horizontal, yVelocity, vertical);
        characterController.Move(transform.rotation * finalVelocity * Time.deltaTime);
        Camera.gameObject.transform.rotation *= Quaternion.Euler(-mY, 0, 0);

    }
}
