using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Transform spawnPoint;

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("hello?");
        other.transform.position = spawnPoint.transform.position;
    }
}
