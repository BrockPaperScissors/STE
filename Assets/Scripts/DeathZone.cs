using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DeathZone : MonoBehaviour
{
    public GameObject player;
    public Transform respawnPoint;

    private void OnCollisionEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.transform.position = respawnPoint.position;
        }
    }
}
