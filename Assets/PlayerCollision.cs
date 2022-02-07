using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DanmakU;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField]
    private GameObject player;



    // Start is called before the first frame update
    void Start()
    {
        GetComponent<DanmakuCollider>().OnDanmakuCollision += OnDanmakuCollision;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnDanmakuCollision(DanmakuCollisionList collisionList)
    {
        foreach (DanmakuCollision collision in collisionList)
        {
            Debug.Log(collision.ToString());
        }

        Destroy(player);

    }
}
