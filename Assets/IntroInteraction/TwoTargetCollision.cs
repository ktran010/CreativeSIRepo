using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoTargetCollision : MonoBehaviour
{
    public GameObject currentSelected;
    
    // Start is called before the first frame update
    void Start()
    {
        currentSelected = new GameObject(null);
    }

    // Update is called once per frame
    void Update()
    {
    }

  private void OnTriggerEnter(Collider c)
    {
        currentSelected = c.gameObject;
        Renderer rend = currentSelected.GetComponent<Renderer>();
        // Renderer rend = this.GetComponent<Renderer>();
        // Renderer rend = GameObject.Find("Sphere2").GetComponent<Renderer>();
        rend.material.SetColor("_Color", Color.green);
    }

}


