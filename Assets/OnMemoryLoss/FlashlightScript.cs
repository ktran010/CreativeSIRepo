using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightScript : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;

    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        // Store offset = gameobject world pos - mouse world pos
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    }

    private Vector3 GetMouseAsWorldPoint()
    {
        // Pixel coordinates of mouse (x,y)
        Vector3 mousePoint = Input.mousePosition;
        // z coordinate of game object on screen
        mousePoint.z = mZCoord;
        // Convert it to world points
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseAsWorldPoint() + mOffset;
    }

    void keyboardNavigation()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
			transform.Translate (this.transform.right * -25f * Time.deltaTime);
		}
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate (this.transform.right * 25f * Time.deltaTime);
        }
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        keyboardNavigation();
    }
}