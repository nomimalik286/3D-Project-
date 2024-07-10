using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float Yvalue = 0f;
      [SerializeField] float movespeed = 0.5f;

     
    // Start is called before the first frame update
    void Start()
    {
         FollowInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

    }
   void FollowInstruction()
    {
        Debug.Log("hey i Win");
        Debug.Log("no you  not win");

    }
   void Movement()
    {

        float Xvalue = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        float Zvalue = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;

        transform.Translate(Xvalue, Yvalue, Zvalue);
    }


}
