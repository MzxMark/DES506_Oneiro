using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Darkness : MonoBehaviour
{
    public float moveSpeed;
    public PlayerControl player;
    private Vector3 movement;

    void Start()
    {
        if (moveSpeed == 0)
            moveSpeed = .01f;

        movement = new Vector3(moveSpeed, 0, 0);
    }

    void Update()
    {
        transform.position += movement * Time.deltaTime;

        if (player.transform.position.x - transform.position.x <= 1)
            player.Die();
    }
}
