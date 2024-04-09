using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float height;
    public float width;
    public float verticalRotation = 45f; // Fixed vertical rotation angle

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Update camera position and rotation
        this.transform.position = player.transform.position + Vector3.up * height + Vector3.back * width;
        this.transform.eulerAngles = new Vector3(verticalRotation, this.transform.eulerAngles.y, this.transform.eulerAngles.z);
    }
}
