using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Katana : MonoBehaviour
{
    public UnityEvent unityEvent = new UnityEvent();

    public GameObject katana;
    public GameObject katanaUI;
    // Start is called before the first frame update
    void Start()
    {
        katana = this.gameObject;

    }

    public void KatanaDescription()
    {
        katanaUI.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void CloseKatanaDescription()
    {
        katanaUI.SetActive(false);
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
