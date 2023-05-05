using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Nunchucks : MonoBehaviour
{
    public UnityEvent unityEvent = new UnityEvent();

    public GameObject nunchucks;
    public GameObject nunchucksUI;
    // Start is called before the first frame update
    void Start()
    {
        nunchucks = this.gameObject;
    }

    public void NunchucksDescription()
    {
        nunchucksUI.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void CloseNunchucksDescription()
    {
        nunchucksUI.SetActive(false);
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
