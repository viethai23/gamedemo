using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    
    public GameObject bulletPrefab;
    public float bulletTime;
    public float lastBulletTime;
    Vector3 BulletOfset = new Vector3(0,0.5f,0);
    public int dame;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            

            if (Time.time - lastBulletTime > bulletTime)
            {
                
                prefabBullet();
                lastBulletTime = Time.time;
            }
            
             
        }

    }
    
    void prefabBullet()
    {
        
        bulletPrefab =  Instantiate(bulletPrefab, transform.position + BulletOfset, transform.rotation);
        Destroy(bulletPrefab, 4f );
        
    }
}

