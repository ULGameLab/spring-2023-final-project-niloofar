using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static UnityEngine.EventSystems.EventTrigger;

public class playerInventory : MonoBehaviour
{ // keeping the amounts of the fruit
    public int NumberOfFruits { get; private set; } 
    public UnityEvent<playerInventory> OnFruitCollected;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FruitCollected()
    {
        NumberOfFruits++;
        OnFruitCollected.Invoke(this);
    }
}
