using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Quaternion guideRotation;
    public GameObject GuideCube;
    GuideRotate guide;

    // Start is called before the first frame update
    void Start()
    {
        // guide = GuideCube.GetComponent<GuideRotate>();
    }

    // Update is called once per frame
    // void Update()
    // {
    //     // float x = this.transform.rotation.y - guide.guideRotation.y;
    //     // this.transform.Translate(x, 0, 0);
    // }

    
    void Update()
    {
        Vector3 accelVecCam = new Vector3(Input.acceleration.x * 10, Input.acceleration.y * 10, -Input.acceleration.z * 10);
        this.transform.position = accelVecCam;
        // //確認用. 適当なGameObjectをカメラの子にする
        // transform.GetChild(0).localPosition = accelVecCam*20; 
    }
}
