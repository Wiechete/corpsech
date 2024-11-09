using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : Singleton<PlayerSpawner>
{
    [SerializeField]
    private GameObject playerPrefab;

    private void Start()
    {
        SpawnPlayer();
    }

    public void SpawnPlayer()
    {
        Instantiate(playerPrefab, transform.position, transform.rotation);
    }
}
