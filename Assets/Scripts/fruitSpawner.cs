using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitSpawner : MonoBehaviour
{
    public GameObject[] fruitPrefab;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(SpawnFruit());
        
    }

    IEnumerator SpawnFruit()
    {
        while (true)
        {
            GameObject go = Instantiate(fruitPrefab[Random.Range(0,fruitPrefab.Length)]);
            Rigidbody temp = go.GetComponent<Rigidbody>();

            temp.velocity = new Vector3(0f, 10f, .5f);
            temp.useGravity= true;

            Vector3 pos = transform.position;
            //pos.x += Random.Range(-1f, 1f);
            go.transform.position = pos;

            yield return new WaitForSeconds(10.8f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
