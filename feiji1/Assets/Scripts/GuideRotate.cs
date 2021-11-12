using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideRotate : MonoBehaviour
{
    public GameObject player;
    public Quaternion guideRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(this.transform.rotation)
        guideRotation = Quaternion.Slerp (transform.rotation, player.transform.rotation, 0.05f);
        transform.rotation = guideRotation;
    }
}
