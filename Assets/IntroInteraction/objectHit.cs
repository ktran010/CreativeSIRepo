using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(Vector3.up*Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(Vector3.up*-1*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(Vector3.right*-1*Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(Vector3.right*Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision collision) 
    {
        // transform.Translate(thistransform.forward*-1*5.0f)
        // print("Hit!" + collision.gameObject.name);
        Renderer rend;
        rend = collision.gameObject.GetComponent<Renderer>();
        rend.material.SetColor ("_Color", Color.green);

        // if(collision.gameObject.name == "Plane")
        // {
        //     print("Hit! A Thing!");
        //     transform.Translate(this.transform.up*10.0f);
        // }
        print("Hit! A Thing!");
        transform.Translate(this.transform.up*10.0f);
    }

    // private void OnTriggerCollision(Collision c) 
    // {
    //     // transform.Translate(thistransform.forward*-1*5.0f)
    //     // print("Hit!" + collision.gameObject.name);
    //     // Renderer rend;
    //     // rend = c.gameObject.GetComponent<Renderer>();
    //     // c.material.SetColor ("_Color", Color.green);


    //     print("Hit! A Thing!");
    //     transform.Translate(this.transform.up*10.0f);
    // }
}
