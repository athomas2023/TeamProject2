using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  public CharacterController controller;
  public float speed = 12f;

    // Update is called once per frame
    void Update()
    {
           if(Input.GetKey(KeyCode.W)) {
             transform.position += transform.forward * Time.deltaTime * speed;
         }
         else if(Input.GetKey(KeyCode.S)) {
             transform.position -= transform.forward * Time.deltaTime * speed;
         }
         else if(Input.GetKey(KeyCode.A)) {
             transform.position -= transform.right * Time.deltaTime * speed;
         }
         else if(Input.GetKey(KeyCode.D)) {
             transform.position += transform.right * Time.deltaTime * speed;
         }
         }
    }


