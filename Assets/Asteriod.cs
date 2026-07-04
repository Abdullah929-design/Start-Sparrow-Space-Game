using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteriod : MonoBehaviour
{
    public playerhelp playerhealth;
    public void OnTriggerEnter(Collider other)
    {
        
        playerhealth=other.GetComponent<playerhelp>();
        if (playerhealth != null) 
        {
            playerhealth.crash();
        }
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
