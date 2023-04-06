using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoreUI : MonoBehaviour
{
    private TextMeshProUGUI Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = GetComponent<TextMeshProUGUI>();        ;
    }
    //update the UI for score
    public void UpdateScore(playerInventory playerInventory)
    {
        Debug.Log(1368);
        Score.text = "Score : " + playerInventory.NumberOfFruits.ToString();
    }
   
}
