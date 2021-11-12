using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TamaR : MonoBehaviour
{
    public GameObject tamaR;
    public GameObject Pivot;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        Pivot = GameObject.Find("Pivot");
        StartCoroutine(Shoot5());
    }

    IEnumerator Shoot5() {
        for (int i = 0; i < 5; i++) {
            Instantiate(tamaR, this.transform.position, Pivot.transform.rotation);
            yield return new WaitForSeconds(0.1f);
        }
      

    }

    void TamaDestroyer()
    { 
   // Destroyer()
    }
}