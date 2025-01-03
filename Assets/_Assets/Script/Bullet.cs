using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    float flySpeed;
    SpriteRenderer spriteBullet;
    public int dame;
    private void Start()
    {
        spriteBullet = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        var newPosition = transform.position;
        newPosition.y += flySpeed * Time.deltaTime;
        transform.position = newPosition;
        
        if (Input.GetMouseButtonDown(0))
        {
            spriteBullet.enabled = true;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var enemy = collision.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDame(dame);
        }
        Destroy(gameObject);

    }
}
