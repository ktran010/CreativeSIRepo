using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Bino : MonoBehaviour
{
    private GameObject Canvas1;//clock
    private GameObject Canvas2;

    private GameObject Canvas3;//crane
    private GameObject Canvas4;

    private GameObject Canvas5;//vase
    private GameObject Canvas6;

    private GameObject Canvas7;//necklace
    private GameObject Canvas8;

    private GameObject Canvas9;//Present
    private GameObject Canvas10;

    private GameObject Canvas11;//clamp
    private GameObject Canvas12;

    private GameObject Canvas13;//pciture
    private GameObject Canvas14;

    private GameObject Canvas15;//camera
    private GameObject Canvas16;

    private void OnTriggerEnter(Collider c)
    {
        
        if(c.gameObject.tag == "CLOCK")
        {
        print("TextClock2 appears BINO!");
            // TextClock1.gameObject.SetActive(true);
            // text_tap.gameObject.SetActive(true);
            Canvas2.SetActive(true);
            if(Canvas1.activeSelf == true)
            {
                Canvas1.SetActive(false);
            }
        }

         if(c.gameObject.tag == "CRANE")
        {
        print("TextCrane2 appears FLASH!");
            // TextClock1.gameObject.SetActive(true);
            // text_tap.gameObject.SetActive(true);
            Canvas4.SetActive(true);
            if(Canvas3.activeSelf == true)
            {
                Canvas3.SetActive(false);
            }
        }

        if(c.gameObject.tag == "VASE")
        {
        print("TextVase2 appears FLASH!");
            // TextClock1.gameObject.SetActive(true);
            // text_tap.gameObject.SetActive(true);
            Canvas6.SetActive(true);
            if(Canvas5.activeSelf == true)
            {
                Canvas5.SetActive(false);
            }
        }

        if(c.gameObject.tag == "NECKLACE")
        {
            print("TextNecklace2 appears FLASH!");
            // TextClock1.gameObject.SetActive(true);
            // text_tap.gameObject.SetActive(true);
            Canvas8.SetActive(true);
            if(Canvas7.activeSelf == true)
            {
                Canvas7.SetActive(false);
            }
        }

        if(c.gameObject.tag == "PRESENT")
        {
        print("TextPresent2 appears FLASH!");
            // TextClock1.gameObject.SetActive(true);
            // text_tap.gameObject.SetActive(true);
            Canvas10.SetActive(true);
            if(Canvas11.activeSelf == true)
            {
                Canvas11.SetActive(false);
            }
        }
        
        if(c.gameObject.tag == "LAMP")
        {
        print("TextLamp2 appears FLASH!");
            // TextClock1.gameObject.SetActive(true);
            // text_tap.gameObject.SetActive(true);
            Canvas12.SetActive(true);
            if(Canvas11.activeSelf == true)
            {
                Canvas11.SetActive(false);
            }
        }

        if(c.gameObject.tag == "PICTURE")
        {
        print("TextPicture2 appears FLASH!");
            // TextClock1.gameObject.SetActive(true);
            // text_tap.gameObject.SetActive(true);
            Canvas14.SetActive(true);
            if(Canvas13.activeSelf == true)
            {
                Canvas13.SetActive(false);
            }
        }
        
        if(c.gameObject.tag == "CAMERA")
        {
            print("TextCamera2 appears FLASH!");
            // TextClock1.gameObject.SetActive(true);
            // text_tap.gameObject.SetActive(true);
            Canvas16.SetActive(true);
            if(Canvas15.activeSelf == true)
            {
                Canvas15.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider c)
    {
        Canvas2.SetActive(false);
        Canvas4.SetActive(false);
        Canvas6.SetActive(false);
        Canvas8.SetActive(false);
        Canvas10.SetActive(false);
        Canvas12.SetActive(false);
        Canvas14.SetActive(false);
        Canvas16.SetActive(false);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Canvas1 = GameObject.Find("CanvasClock1");
        Canvas1.SetActive(false);

        Canvas2 = GameObject.Find("CanvasClock2");
        Canvas2.SetActive(false);

        Canvas3 = GameObject.Find("CanvasCrane1");
        Canvas3.SetActive(false);

        Canvas4 = GameObject.Find("CanvasCrane2");
        Canvas4.SetActive(false);

        Canvas5 = GameObject.Find("CanvasVase1");
        Canvas5.SetActive(false);

        Canvas6 = GameObject.Find("CanvasVase2");
        Canvas6.SetActive(false);

        Canvas7 = GameObject.Find("CanvasNecklace1");
        Canvas7.SetActive(false);

        Canvas8 = GameObject.Find("CanvasNecklace2");
        Canvas8.SetActive(false);

        Canvas9 = GameObject.Find("CanvasPresent1");
        Canvas9.SetActive(false);

        Canvas10 = GameObject.Find("CanvasPresent2");
        Canvas10.SetActive(false);

        Canvas11 = GameObject.Find("CanvasLamp1");
        Canvas11.SetActive(false);

        Canvas12 = GameObject.Find("CanvasLamp2");
        Canvas12.SetActive(false);

        Canvas13 = GameObject.Find("CanvasPicture1");
        Canvas13.SetActive(false);

        Canvas14 = GameObject.Find("CanvasPicture2");
        Canvas14.SetActive(false);

        Canvas15 = GameObject.Find("CanvasCamera1");
        Canvas15.SetActive(false);

        Canvas16 = GameObject.Find("CanvasCamera2");
        Canvas16.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
