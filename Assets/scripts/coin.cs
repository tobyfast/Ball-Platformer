using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class coin : MonoBehaviour
{
    public float turnSp = 90f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "Player")
        {
            return;
        }
        manager.inst.IncreamentScore();


        Destroy(gameObject);
    }

    private void Start()
    {

    }


    private void Update()
    {
        transform.Rotate(0, 0, turnSp = Time.deltaTime);
    }
}
