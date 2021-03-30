using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
  // mouseSense controls mouse speed
  public float mouseSense = 100f;
  //
  public Transform playerBody;
  //
  float xRotate = 0f;
  void Start()
  {
    Cursor.lockState = CursorLockMode.Locked;
  }
  void Update()
  {
    //Get Mouse Input
    float mouseX = Input.GetAxis("Mouse X") * mouseSense * Time.deltaTime;
    float mouseY = Input.GetAxis("Mouse Y") * mouseSense * Time.deltaTime;
    xRotate -= mouseY;
    //prevent looking all the way up
    xRotate = Mathf.Clamp(xRotate, -90f, 90f);

    transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f);
    playerBody.Rotate(Vector3.up * mouseX);
  }
}