using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerSelection : MonoBehaviour
{
  Transform wand;
  Transform arcam;
  public GameObject currentSelected;

  // Start is called before the first frame update
  void Start()
  {
    currentSelected = new GameObject(null);
    wand = GameObject.Find("wand").transform; 
    arcam = GameObject.Find("ArCamera").transform; 
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKey(KeyCode.S))
    {
      if(currentSelected !=null)
      {
        currentSelected.transform.SetParent(wand,true);
      } 
    }
    else if (Input.GetKey(KeyCode.D))
    {
      if(currentSelected !=null)
      {
        //If you want to release your object
        currentSelected.transform.SetParent(arcam,true);
      }
    }
  }

  private void OnTriggerEnter(Collider c)
  {
    currentSelected = c.gameObject;
  }
}


