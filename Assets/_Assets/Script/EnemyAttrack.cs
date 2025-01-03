using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttrack : MonoBehaviour
{
    public EnemyHealth health;
    public float attrackCooldown;
    public float lastAttrackTime;
    public int dame;
    public GameObject attrackEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            var playerHealth = collision.GetComponent<PlayerHeath>();
            if (playerHealth != null && Time.time - lastAttrackTime >= attrackCooldown)
            {
                lastAttrackTime = Time.time;
                playerHealth.TakeDame(dame);
                health.TakeDame(10);
                PlayAttrackEffect();
            }
        }
        


    }
    void PlayAttrackEffect()
    {
        if (attrackEffect != null)
        {
            var effect = Instantiate(attrackEffect, transform.position, Quaternion.identity);
            Destroy(effect, 3f);
        }
    }

}