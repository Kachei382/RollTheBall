using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kcoin : MonoBehaviour
{

    public Renderer Coin;
    void OnTriggerEnter(Collider SombodyOther)
    {
        Coin = GetComponent<Renderer>();
        if (SombodyOther.tag == "Player")
        {
            Coin.enabled = false;
        }
       
        
    }
}
