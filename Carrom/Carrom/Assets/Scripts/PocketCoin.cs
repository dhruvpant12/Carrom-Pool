using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocketCoin : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("WhiteCoin"))
        {
            print("go");
            other.gameObject.SetActive(false);
            UIManager.instance.UpdatePlayerCoins();
        }
        if (other.gameObject.CompareTag("BlackCoin"))
        {
            print("go");
            other.gameObject.SetActive(false);
            UIManager.instance.UpdateAICoins();
        }
        if (other.gameObject.CompareTag("Queen"))
        {
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Striker"))
        {

        }

    }
   

    
}
