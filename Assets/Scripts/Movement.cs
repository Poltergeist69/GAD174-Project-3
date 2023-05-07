using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 15f;

    public AudioSource walkAudio;
    
    public CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        walkAudio = GameObject.Find("walking Audio").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputx = Input.GetAxis("Horizontal");
        float inputz = Input.GetAxis("Vertical");

        Vector3 move = transform.right * inputx + transform.forward * inputz;

        characterController.Move(move * movementSpeed * Time.deltaTime);
    }
}
