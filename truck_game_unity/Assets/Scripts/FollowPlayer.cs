using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);  // described private to hide the camera

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate() // We changed name of func from Update() to LateUpdate() -> this made Smooth the Camera
    {
        // Offset the camera behind the player by adding the player's position
        //transform.position = player.transform.position + new Vector3(0, 5, -7);
        // new Vector3(0, 5, -7) fixed the position of the camera
        transform.position = player.transform.position + offset;

    }
}
