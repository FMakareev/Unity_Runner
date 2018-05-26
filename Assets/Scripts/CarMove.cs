using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    
    Animator CarAnimatorController;
    
    Animation CarMoveAnimation;

    public float Speed = 10f;

    
    // Use this for initialization
    void Start()
    {
        
        CarAnimatorController = GetComponent<Animator>();
        
        CarAnimatorController.SetFloat("CarSpeedAnimation", Speed);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKey(KeyCode.A) && transform.position.x > 46)
        {
            CarAnimatorController.SetInteger("CarMove", -1);
            transform.position +=  Vector3.left * (Time.deltaTime * Speed);
        }
        else if (Input.GetKey(KeyCode.D) && transform.position.x < 54)
        {
            CarAnimatorController.SetInteger("CarMove", 1);
            transform.position += Vector3.right * (Time.deltaTime * Speed);
        }
        else
        {
            CarAnimatorController.SetInteger("CarMove", 0);
        }
        
        transform.position = new Vector3(transform.position.x, transform.position.y, 45);
    }
}