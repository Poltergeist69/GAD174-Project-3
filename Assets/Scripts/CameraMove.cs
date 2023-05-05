using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float sensitivity;
    public float xRotation;

    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mousex = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mousey = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation -= mousey;
        xRotation = Mathf.Clamp(xRotation, -90f, 0f);

        player.Rotate(Vector3.up * mousex);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}
