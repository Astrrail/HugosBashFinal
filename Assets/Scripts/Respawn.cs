using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Transform respawnPoint;

    private void OnCollisionEnter(Collision collision)
    {
        player.transform.position = respawnPoint.transform.position;
        Debug.Log("TOUCHDOWN");
    }
}
