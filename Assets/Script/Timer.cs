using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    MeshRenderer Renderer;
    Rigidbody rb;

   [SerializeField] float timetowait = 5f;
    void Start()
    {
        Renderer = GetComponent<MeshRenderer>();
        Renderer.enabled = false;

        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

   
    void Update()
    {
        if (Time.time > timetowait)
        {
            Renderer.enabled = true;
            rb.useGravity = true;

        }
        
    }
}
