using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testy : MonoBehaviour
{
    public GameObject Sphere;
    Vector3 position;
    public GameObject wall;

    // Start is called before the first frame update
    void Start()
    {
        position = wall.transform.position;
        StartCoroutine(Create());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator Create() {
        Instantiate(Sphere, position, wall.transform.rotation);
        yield return new WaitForSeconds(2);
    }
}
