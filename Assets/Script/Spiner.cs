using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiner : MonoBehaviour
{
    [SerializeField] float xAngel = 0;
    [SerializeField] float yAngel = 0;
    [SerializeField] float zAngel = 0;


    
    void Update()
    {
        transform.Rotate(xAngel,yAngel,zAngel);
    }
}
