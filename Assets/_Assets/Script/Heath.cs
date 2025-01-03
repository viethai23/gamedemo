using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heath : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint;
    private int healthPoint;
    

    private void Start()
    {
        healthPoint = defaultHealthPoint;
    }
    

    protected virtual void Die()
    {
        var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(explosion, 1);
        Destroy(gameObject);
    }

    public void TakeDame(int dame)
    {
        
        if (healthPoint <= 0) return;

        healthPoint -= dame;
        if (healthPoint <= 0) Die();

    }
}
