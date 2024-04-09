using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed=2;
        print(this.transform.position);
        this.transform.position += Vector3.forward * speed * Time.deltaTime;
    }
}
