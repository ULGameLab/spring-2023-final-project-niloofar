using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{ //this is a test code
    AudioSource Splatter;

    // Update is called once per frame
    private void Start()
    {
        Splatter = GetComponent<AudioSource>();
    }
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        GameObject victim = collision.collider.gameObject;
        if (victim != null)
        {
            //GameObject.Find(victim.name)
            //Splatter.Play();
           // Debug.Log("Hello!");
            //check for previous project collision!
        }
    }

    void StartCutting()
    {
       
    }

    
}
