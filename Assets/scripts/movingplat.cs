using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingplat : MonoBehaviour
{

    public GameObject Player;

    void update()
    {
        Debug.Log(transform.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.parent = transform;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player)
        {

            Player.transform.parent = null;
            Debug.Log(transform.position);
        }
    }
}