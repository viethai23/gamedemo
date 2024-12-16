using JetBrains.Annotations;
using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlplayer : MonoBehaviour
{
    public float playerSpeed = 10f;
    
    private Vector3 lastMousePose ;

    void Start()
    {
        lastMousePose = GetMouseWorldPosition();
        


    }
    void Update()
    {
        Vector3 currentMouseButten = GetMouseWorldPosition();
        if (currentMouseButten.x > -3 && currentMouseButten.x < 3 && currentMouseButten.y > -5 && currentMouseButten.y < 5
            && transform.position.x > -3 && transform.position.x < 3 && transform.position.y > -5 && transform.position.y < 5)
        {
            Vector3 currentMousePose = GetMouseWorldPosition();

            Vector3 mouseDelta = currentMousePose - lastMousePose;

            if (mouseDelta.sqrMagnitude > 0.01f)
            {
                Vector3 mouseDirection = mouseDelta.normalized;
                transform.position += mouseDirection * playerSpeed * Time.deltaTime;

                lastMousePose = currentMousePose;
            }
        }
        else
        {
            transform.position = lastMousePose;
        }

    }
    private Vector3 GetMouseWorldPosition()
    {

        if(Input.GetMouseButton(0))
        {
            Vector3 mouseScreenPose = Input.mousePosition;
            Vector3 mouseWorldPose = Camera.main.ScreenToWorldPoint(new Vector3(mouseScreenPose.x, mouseScreenPose.y, -10));
            mouseWorldPose.z = 0;
            return mouseWorldPose;
            
        }
        else 
        {
            return Vector3.zero;
        }

    }
}
