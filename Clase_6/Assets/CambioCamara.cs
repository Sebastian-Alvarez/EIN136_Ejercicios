using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCamara : MonoBehaviour
{
    public GameObject camMain;
    public GameObject zoomCam;

    private void Start()
    {
        zoomCam.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            zoomCam.SetActive(true);
            camMain.SetActive(false);

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            zoomCam.SetActive(false);
            camMain.SetActive(true);

        }
    }
}
