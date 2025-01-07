using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    public SpriteRenderer spriteBullet;
    public float Speed;
    public int dame;
    private void Start()
    {
        spriteBullet = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        var newPosition = transform.position;
        newPosition.y -= Speed * Time.deltaTime;
        transform.position = newPosition;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<PlayerHeath>();
        if (player != null)
        {
            player.TakeDame(dame);
        }
        Destroy(gameObject);

    }
}
