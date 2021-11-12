using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceleration : MonoBehaviour
{
    // private Vector3 acceleration;
    float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // this.acceleration = Input.acceleration;
        var dir = Vector3.zero;
        dir.x = Input.acceleration.x;
        dir.y = Input.acceleration.y;

        if(dir.sqrMagnitude > 1){
            dir.Normalize();
        }

        dir *= Time.deltaTime;

        transform.Translate(dir * speed);
    }
}
