using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerNavigation : MonoBehaviour
{
    public GameObject currentCollided;
    // Start is called before the first frame update
    void Start()
    {
        currentCollided = new GameObject(null);
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKey(KeyCode.UpArrow)) 
        // {
        //     Camera.main.transform.Translate (Camera.main.transform.forward * Time.deltaTime); 
        // }
        // else if (Input.GetKey(KeyCode.DownArrow))
        // {
        //     Camera.main.transform.Translate (Camera.main.transform.forward-1 Time.deltaTime); 
        // }
        // else if (Input.GetKey(KeyCode.LeftArrow))
        // {
        //     Camera.main.transform.Translate (Camera.main.transform.right-1 Time.deltaTime); 
        // }
        // else if (Input.GetKey(KeyCode.RightArrow))
        // {
        //     Camera.main.transform.Translate (Camera.main.transform.right* Time.deltaTime); 
        // }
    }

  private void OnTriggerEnter(Collider c)
    {
        GameObject l, r, u, d, f, ba; // left, right, bottom, top, front, back
        l = GameObject.Find("Left");
        r = GameObject.Find("Right");
        d = GameObject.Find("Bottom");
        u = GameObject.Find("Top");
        f = GameObject.Find("Front");
        ba = GameObject.Find("Back");

        currentCollided = c.gameObject;

        if(currentCollided == u) // TRANSLATE CAMERA
        {
            UnityEngine.Camera.main.transform.Translate(Camera.main.transform.up*15f * Time.deltaTime);
            Debug.Log("hit up!");
        }
        else if(currentCollided == d) // TRANSLATE CAMERA
        {
            Camera.main.transform.Translate(Camera.main.transform.up*-15f * Time.deltaTime);
            Debug.Log("hit down!");
        }
        else if(currentCollided == r) // ROTATE CAMERA
        {
            Camera.main.transform.Rotate(Camera.main.transform.right*15f * Time.deltaTime);
            Debug.Log("hit right!");
        }
        else if(currentCollided == l) // ROTATE CAMERA
        {
            Camera.main.transform.Rotate(Camera.main.transform.right*-15f * Time.deltaTime);
            Debug.Log("hit left!");
        }
        else if(currentCollided == f) // TRANSLATE CAMERA
        {
            Camera.main.transform.Translate(Camera.main.transform.forward*15f * Time.deltaTime);
            Debug.Log("hit forward!");
        }
        else if(currentCollided == ba) // TRANSLATE CAMERA
        {
            Camera.main.transform.Translate(Camera.main.transform.forward*-15f * Time.deltaTime);
            Debug.Log("hit back!");
        }
    }
}