using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO : MonoBehaviour
{
    public GameObject particleObj;    
    public GameObject wall;
    public Transform target;
    public float speed = 0.3f;
    public float rapTimer = 10f;
    public float addSpeed = 0.1f;
    public float addRapTimer = 10f;
    public int hitCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Heart").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // 時間を計測
        if(Time.time > rapTimer) {
            speed += addSpeed;
            rapTimer += addRapTimer;
        }   

        transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (target.position - transform.position), 0.3f);
        transform.position += transform.forward * speed;

        // 当たった回数
        if(hitCount > 10) {
            
        }
    }

    public void Explode() 
    {
        Destroy(gameObject);
        Instantiate(particleObj, this.transform.position, Quaternion.identity);
    }

    private void OnTriggerEnter(Collider collider) {
        if(collider.gameObject.name == "Heart") {
            Destroy(gameObject);
            hitCount += 1;
        }
    }
}
