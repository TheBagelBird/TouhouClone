using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightLineBullet : MonoBehaviour
{
    public Transform playerBullet;
    public float bulletSpeed;
    

    // Start is called before the first frame update
    void Start()
    {
        playerBullet.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        playerBullet.Translate(new Vector2(1, 0) * bulletSpeed * Time.deltaTime);

        if (playerBullet.position.x > 30)
        {
            // Destroy( );
        }
    }
}
