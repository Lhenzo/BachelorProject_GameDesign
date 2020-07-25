using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterController : MonoBehaviour
{
    public float Speed;


    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }



    void PlayerMovement()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(horizontalMovement, 0f, verticalMovement).normalized * Speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
        
    }
}
