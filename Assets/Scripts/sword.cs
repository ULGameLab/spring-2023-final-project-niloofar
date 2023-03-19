using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    bool cut = false;

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        GameObject victim = collision.collider.gameObject;
        if (victim != null)
        {
            //GameObject.Find(victim.name)
            StartCutting();
            Debug.Log("Hello!");
            //check for previous project collision!
        }
    }

    void StartCutting()
    {
        cut= true;
    }

    
}
