using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitSpawner : MonoBehaviour
{
    public GameObject[] fruitPrefab;
    
    public float fruitSpawn = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnFruit());
        
    }

    // Update is called once per frame
    void Update()
    {
     //the rate of generating the fruit will be increased based on the time 
        switch (Time.realtimeSinceStartup)
        {
            case >30 and <= 60:
                fruitSpawn = 1.0f;
                break;
            case >=60:
                fruitSpawn = 0.5f;
                break;
        }
    }

    IEnumerator SpawnFruit()
    { // Generating the fruits
        while (true)
        {
            GameObject go = Instantiate(fruitPrefab[Random.Range(0,fruitPrefab.Length)]);
            Rigidbody temp = go.GetComponent<Rigidbody>();

            temp.velocity = new Vector3(0f, 7f, 1f);
            temp.useGravity= true;

            Vector3 pos = transform.position;
            go.transform.position = pos;

            yield return new WaitForSeconds(fruitSpawn);
        }
    }

    
   
}
