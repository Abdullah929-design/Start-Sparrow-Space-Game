using System.Collections;
using UnityEngine;

public class MissileBehavior : MonoBehaviour
{
    public float speed = 10f;
    private Transform player;

    void Start()
    {
        
        GameObject playerObj = GameObject.FindWithTag("Player");
        if (playerObj != null)
            player = playerObj.transform;

        StartCoroutine(DestroyIfOffScreen());
    }

    void Update()
    {
        if (player == null) return;

        
        Vector3 direction = (player.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;

        
        Quaternion targetRotation = Quaternion.LookRotation(direction, Vector3.back);
        transform.rotation = targetRotation;
    }

    void OnTriggerEnter(Collider other)
    {
        playerhelp ph = other.GetComponent<playerhelp>();
        if (ph != null)
        {
            ph.crash();              
            Destroy(gameObject);     
        }
    }

    
    IEnumerator DestroyIfOffScreen()
    {
        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
    }
}