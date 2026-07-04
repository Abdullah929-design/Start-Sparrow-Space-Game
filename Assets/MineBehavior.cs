using System.Collections;
using UnityEngine;

public class MineBehavior : MonoBehaviour
{
    public float lifetime = 3f;

    void Start()
    {
        
        StartCoroutine(DestroyAfterLifetime());
    }

    public void OnTriggerEnter(Collider other)
    {
       
        playerhelp player = other.GetComponent<playerhelp>();
        if (player != null)
        {
            Destroy(gameObject); 
           
        }
    }

    IEnumerator DestroyAfterLifetime()
    {
        yield return new WaitForSeconds(lifetime);
        Destroy(gameObject);
    }
}