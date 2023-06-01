using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    float timeRemaining; //2 mins time limit for a game to get over.
   [SerializeField] TMP_Text timeDisplay; // Timer display
    int minutes, seconds; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeRemaining += Time.deltaTime; // incrementing time.

        if (timeRemaining >= 121f) // Game over at 2 mins.
        {
            return;

        }


        minutes =(int)(timeRemaining / 60.0f);
        seconds = (int)(timeRemaining % 60.0f);
        timeDisplay.text = "Time - " + string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}
