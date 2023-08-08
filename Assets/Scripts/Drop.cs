using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    [SerializeField] float timeToDrop = 5f;
    MeshRenderer renderer; 
    Rigidbody rd;
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rd = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rd.useGravity = false;
    }

    void Update()
    {
        if(Time.time > timeToDrop)
        {
            renderer.enabled = true;
            rd.useGravity = true;
        }
    }
}
