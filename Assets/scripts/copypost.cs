using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copypost : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Transform transTarget;

    // Update is called once per frame
    void Update()
    {
        transform.position = transTarget.position;
    }
}
