using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionExample : MonoBehaviour
{
   private float zValue;
   private float zOffset;
   private Vector3 mouseOffset;
   
    // Start is called before the first frame update
    void Start()
    {
        zOffset = 0;
    }

    // Update is called once per frame
    void Update()
    {
        zOffset += Input.mouseScrollDelta.y; // move object in z direction with mouse scroll
    }

    Vector3 getMousePosition(){
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = zValue + zOffset;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDown() {
      zValue = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
      mouseOffset = gameObject.transform.position - getMousePosition();
    }

    void OnMouseDrag(){
        transform.position = getMousePosition()+mouseOffset; // drag object around
    }

    void OnCollisionEnter(Collision collision) 
    {
        // transform.Translate(thistransform.forward*-1*5.0f)
        // print("Hit!" + collision.gameObject.name);

        if(collision.gameObject.name == "Cube1")
        {
            print("Hit! Cube!");
            collision.gameObject.transform.Translate(collision.gameObject.transform.up*10.0f);
        }

        if(collision.gameObject.name == "Sphere1")
        {
            print("Hit! Sphere!");
        }

        if(collision.gameObject.name == "Capsule1")
        {
            print("Hit! Capsule!");
        }
    }
}
