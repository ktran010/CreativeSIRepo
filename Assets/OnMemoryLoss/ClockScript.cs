using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockScript : MonoBehaviour
{
    private GameObject Canvas1;
    private GameObject Canvas2;
    // private TextMesh text_tap;

    //Start is called before the first frame update
	void mouseRayCast()
    {   
        if (Input.GetMouseButtonDown(0))
        { // if left mouse button is clicked 
            print("TextClock1 appears yay!");
            // TextClock1.gameObject.SetActive(true);
            // text_tap.gameObject.SetActive(true);
            Canvas1.SetActive(true);
            if(Canvas2.activeSelf == true)
            {
                Canvas2.SetActive(false);
            }
		}

        if(Input.GetKeyDown(KeyCode.Space))
        {
            print("TextClock2 appears!");
            Canvas2.SetActive(true);

            if(Canvas1.activeSelf == true)
            {
                Canvas1.SetActive(false);
            }
        }
	}

    	// Use this for initialization
	void Start () {
        // text_tap = GameObject.Find("CanvasClock").GetComponent<TextMesh>();
        Canvas1 = GameObject.Find("CanvasClock1");
        Canvas1.SetActive(false);

        Canvas2 = GameObject.Find("CanvasClock2");
        Canvas2.SetActive(false);
        
        // text_tap.gameObject.SetActive(false);
        // TextClock1.gameObject.SetActive(false);
	}

	// Update is called once per frame
	void Update () {
		mouseRayCast ();
        // showText ();
	}
}
