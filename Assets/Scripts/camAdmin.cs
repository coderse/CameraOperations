using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camAdmin : MonoBehaviour
{
    public Camera MainCam;
    public Camera FirsCamera;
    public Camera SecondCamera;


    // Tuþlara basarak kameralarý deðiþtirme..
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            MainCam.enabled = false;
            SecondCamera.enabled = false;
            FirsCamera.enabled = true;
            FirsCamera.fieldOfView = 10f; //cameranýn componentlerini deðiþtirmek..
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            MainCam.enabled = false;
            FirsCamera.enabled = false;
            SecondCamera.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SecondCamera.enabled = false;
            FirsCamera.enabled = false;
            MainCam.enabled = true;
        }




    }
}
