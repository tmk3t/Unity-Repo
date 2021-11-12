using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    //GameObject 
    // Start is called before the first frame update
    void Start()
    {
       // Dir = GameObject.Find("muzzleL").GetComponent<TamaL>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(transform.forward * 5f, Space.World);
        if(this.transform.position.z > 200) 
        {
            Destroy(gameObject);
        }
    }

}
