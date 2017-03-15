using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillBox : MonoBehaviour
{   
  void OnTriggerEnter(Collider boll)
       
    {
        Debug.LogWarning("rabotayat");
        if (boll.tag == "Player") 
        {    
            Application.LoadLevel(0);
        }
    }
	
}
