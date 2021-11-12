using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimController : MonoBehaviour
{
    TamaR tamaR;
    TamaL tamaL;
    // Start is called before the first frame update
    void Start()
    {
        tamaR = GameObject.Find("muzzleR").GetComponent<TamaR>();
        tamaL = GameObject.Find("muzzleL").GetComponent<TamaL>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = 100;
        float duration = 3;
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance, Color.red, duration, false);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 300)) {
            Debug.Log("hit");
            string tagName = hit.collider.gameObject.tag;
            if (tagName == "Enemy") {
                tamaR.Shoot();
                tamaL.Shoot();
                hit.collider.gameObject.GetComponent<UFO>().Explode();
            }
        }

        

    }
}
