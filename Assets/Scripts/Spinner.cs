using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    [SerializeField] float x = 5f;
    [SerializeField] float y = 8f;
    [SerializeField] float z = 5f;
    void Update()
    {
        transform.Rotate(x,y,z);
    }
}
