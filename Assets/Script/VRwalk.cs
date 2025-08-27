using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UIElements;

public class VRwall : MonoBehaviour
{
    // ATRIBUTOS

    public Transform vrCamera;

    //VARIABLES DE CLASE
    public float angles = 30.0f;
    public float speed = 3.0f;
    public Boolean move;
    public CharacterController cc;

    void Start()
    {
     cc = this.GetComponent<CharacterController>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (vrCamera.eulerAngles.x >= angles && vrCamera.eulerAngles.x < 60)
        {
            move = true;
        }
        else
        {
            move = false;
        }

        if (move)
        {
            Vector3 direction = vrCamera.TransformDirection(Vector3.forward);
            cc.SimpleMove(direction*speed);
        }

                
                
    }
}
