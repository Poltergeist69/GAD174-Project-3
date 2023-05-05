using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Gamemanager : MonoBehaviour
{
    public UnityEvent unityEvent = new UnityEvent();

    public GameObject sai;
    public GameObject saiUI;

    void Start()
    {
        sai = this.gameObject;
    }

    public void SaiDescription()
    {
        saiUI.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
    }


    public void CloseSaiDescription()
    {
        saiUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

  
    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                unityEvent.Invoke();
            }
        }
    }
}
