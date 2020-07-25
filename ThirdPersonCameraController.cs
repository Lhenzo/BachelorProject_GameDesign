using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour
{
    public float RotationSpeed = 1;
    public Transform Target, Player;
    float mouseHorizontal, mouseVertical;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void LateUpdate()
    {
        CamControl();
    }

    void CamControl()
    {
        mouseHorizontal += Input.GetAxis("Mouse X") * RotationSpeed;
        mouseVertical -= Input.GetAxis("Mouse Y") * RotationSpeed;
        //Pour éviter que la caméra flip : 
        mouseVertical = Mathf.Clamp(mouseVertical, -80, 100);

        transform.LookAt(Target);

        if (Input.GetMouseButton(1)) //clique droit enfoncé
        {
            Target.rotation = Quaternion.Euler(mouseVertical, mouseHorizontal, 0);
        }
        else
        {
            Target.rotation = Quaternion.Euler(mouseVertical, mouseHorizontal, 0);
            Player.rotation = Quaternion.Euler(0, mouseHorizontal, 0);
        }
        
    }

}
