using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hooking : MonoBehaviour
{
    public PlayerHock grappling;
    public DistanceJoint2D joint2D;

    public void Start()
    {
        grappling = GameObject.Find("Player").GetComponent<PlayerHock>();
        joint2D = GetComponent<DistanceJoint2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Ground"))
        {
            joint2D.enabled = true;
            grappling.isAttach = true;
        }
    }
}
