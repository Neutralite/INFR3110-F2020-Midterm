using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Transform playerBody;
    public Transform spawnPoint;

    void OnTriggerEnter(Collider other)
    {
        playerBody.transform.position = spawnPoint.transform.position;
    }
}
