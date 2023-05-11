using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;     // f tells the number is float to system
    public float turnSpeed = 25.0f; //controls vehicle turning speed
    public float horizontalInput;   // controls left/right movement
    public float forwardInput;      // controls vehicle speed

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");  // unity has prepared codes for horizontalInput under the Input Manager >> Horizontal
        forwardInput = Input.GetAxis("Vertical");       // unity has prepared codes for forwardInput under the Input Manager >> Vertical

        /*
        // We'll move the vehicle forward

        //transform.Translate(0, 0, 1);  // let us move the truck in z dimension
        //transform.Translate(Vector3.forward * Time.deltaTime * 20);  // This code does same work like the code that is on upper side

        // * Time.deltaTime  ->  Allows the vehicle to move 1 meter per second
        // * Time.deltaTime * 20  ->  Allows the vehicle to move 20 meters per second

        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
        */

        //We turn the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        /*
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);   // speed * (+1) = move to right  / speed * (-1) = move to left   
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput); // left arrow makes to move left  /  rigth arrow makes to move rigth 
        */

        //We turn the vehicle horizontal
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

    }
}
