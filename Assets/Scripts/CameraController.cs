using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = 3.5f;
     private float X;
     private float Y;
 
     void Update() {
         if(Input.GetMouseButton(0)) {
             transform.Rotate(new Vector3(Input.GetAxis("Mouse Y") * speed, -Input.GetAxis("Mouse X") * speed, 0));
             X = transform.rotation.eulerAngles.x;
             Y = transform.rotation.eulerAngles.y;
             transform.rotation = Quaternion.Euler(X, Y, 0);
         }

         if(Input.GetKey(KeyCode.UpArrow))
         {
             Vector3 v3 = transform.position;
             v3.z -= 5*speed * Time.deltaTime;
             transform.position = v3;
         }

         if(Input.GetKey(KeyCode.DownArrow))
         {
             Vector3 v3 = transform.position;
             v3.z += 5*speed * Time.deltaTime;
             transform.position = v3;
         }

         if(Input.GetKey(KeyCode.LeftArrow))
         {
             Vector3 v3 = transform.position;
             v3.x += 5*speed * Time.deltaTime;
             transform.position = v3;
         }

         if(Input.GetKey(KeyCode.RightArrow))
         {
             Vector3 v3 = transform.position;
             v3.x -= 5*speed * Time.deltaTime;
             transform.position = v3;
         }
     }
}
