using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    GameObject enemyPrefab;
    bool spawning = false;
    float interval = 5.0f;
    public int timer;
    bool timerEnabled = true;
    public GameObject wall;

    public float angle;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(SpawnTimer());
        StartCoroutine(IntervalTimer());
       // enemyPrefab.transform.Translate(new Vector3(0, 0, -0.15f));

    }

    

    IEnumerator SpawnTimer()
    {

        if (!spawning)
        {
            spawning = true;
            yield return new WaitForSeconds(interval);
            SpawnEnemy();
            spawning = false;
        }
        else{
            yield return null;
        }

        yield return null;
    }

    void SpawnEnemy()
    {
        //GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        // Vector3 position = new Vector3(transform.position.x + 10, transform.position.y, transform.position.z);
        float wallX = wall.transform.position.x;
        float wallY = wall.transform.position.y;
        float wallZ = wall.transform.position.z;
        float x = Random.Range(-100, 100);
        float y = Random.Range(-75, 75);
        // float sin = Mathf.Sin(angle);
        // Debug.Log(sin);
        // float cos = Mathf.Cos(angle);
        // float z = Random.Range(-300f * sin, 300f * sin);
        // float y = Random.Range(-1 * Mathf.Abs(Mathf.Sqrt(Mathf.Pow(300f, 2f) - Mathf.Pow(z, 2f))), Mathf.Abs(Mathf.Sqrt(Mathf.Pow(300f, 2f) - Mathf.Pow(z, 2f))));
        // float x = Random.Range(-1 * Mathf.Abs(Mathf.Sqrt(Mathf.Pow(300f, 2f) - Mathf.Pow(y, 2f)  - Mathf.Pow(z, 2f))), Mathf.Abs(Mathf.Sqrt(Mathf.Pow(300f, 2f) - Mathf.Pow(y, 2f)  - Mathf.Pow(z, 2f))));




        Vector3 position = new Vector3(wallX + x, wallY + y, wallZ);
        // Vector3 position = new Vector3(x, y, x);
        // Debug.Log(z + ", " + y + ", " + x);
        Instantiate(enemyPrefab, position, wall.transform.rotation);
        
    }
    IEnumerator IntervalTimer()
    {
        if (timerEnabled)
        {
            timerEnabled = false;
            yield return new WaitForSeconds(1);

            timerEnabled = true;
            timer = timer + 1;


           // if timer(10秒で0.5秒減らす。)
        }
        else
        {
            yield return null;
        }

        yield return null;

    }
}
