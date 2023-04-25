using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bomb : MonoBehaviour
{
    public int GameOver = 1;
    [SerializeField]
    public GameObject explosion;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            //Destroy(collision.gameObject);
            Renderer[] allRenderers = gameObject.GetComponentsInChildren<Renderer>();
            foreach (Renderer c in allRenderers) c.enabled = false;
            Collider[] allColliders = gameObject.GetComponentsInChildren<Collider>();
            foreach (Collider c in allColliders) c.enabled = false;

            StartCoroutine(EndGame(2.0f));
        }
           
    }


    public IEnumerator EndGame(float waitTime)
    {

        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);
        SceneManager.LoadScene(GameOver);
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
