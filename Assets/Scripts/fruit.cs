using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruit : MonoBehaviour
{
    AudioSource Splatter;

    // Start is called before the first frame update
    void Start()
    {
        Splatter = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor") || collision.gameObject.CompareTag("Player"))
        {
             Renderer[] allRenderers = gameObject.GetComponentsInChildren<Renderer>();
             foreach (Renderer c in allRenderers) c.enabled = false;
             Collider[] allColliders = gameObject.GetComponentsInChildren<Collider>();
             foreach (Collider c in allColliders) c.enabled = false;

             StartCoroutine(PlayAndDestroy(1.0f));
        }
        if (collision.gameObject.CompareTag("Player"))
        {

            playerInventory playerInventory = collision.gameObject.GetComponent<playerInventory>();

            if (playerInventory != null)
            {
                Splatter.Play();
                playerInventory.FruitCollected();

            }
        }

        }
    private IEnumerator PlayAndDestroy(float waitTime)
    {
       
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
