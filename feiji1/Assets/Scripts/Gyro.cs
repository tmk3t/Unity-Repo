using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyro : MonoBehaviour
{
    private float x;
    private float y;
    private float z;

    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, -180) * Quaternion.Euler(-90,0,0) * Input.gyro.attitude *
            Quaternion.Euler(0, 0, 180);
        if (transform.rotation.y > 0) {
            transform.Translate(new Vector3(1, 0, 0));
        }
        if (transform.rotation.y > 0) {
            transform.Translate(new Vector3(-1, 0, 0));
        }

        // x = Input.acceleration.x;
        // y = Input.acceleration.y;
        // z = Input.acceleration.z;
        // transform.Translate(x, y, z);
    }
}
