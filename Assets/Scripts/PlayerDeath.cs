using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField]
    private GameObject ragdollPrefab;

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("Deadly"))
        {
            Die();
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Killzone"))
        {
            DieWithoutRagdoll();
        }
    }

    private void DieWithoutRagdoll()
    {
        PlayerSpawner.Instance.SpawnPlayer();
        Destroy(gameObject);
    }

    private void Die()
    {
        SpawnRagdoll();
        PlayerSpawner.Instance.SpawnPlayer();
        Destroy(gameObject);
    }

    private void SpawnRagdoll()
    {
        Instantiate(ragdollPrefab, transform.position, transform.rotation);
    }
}
