using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5;
    void Start()
    {
        
    }

    
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float z =  Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(x , 0f, z);
    }
}
