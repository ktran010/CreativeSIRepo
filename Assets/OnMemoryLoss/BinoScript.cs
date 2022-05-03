using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinoScript : MonoBehaviour
{
    private Vector3 mOffset2;
    private float mZCoord2;

    void OnMouseDown()
    {
        mZCoord2 = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        // Store offset = gameobject world pos - mouse world pos
        mOffset2 = gameObject.transform.position - GetMouseAsWorldPoint();
    }

    private Vector3 GetMouseAsWorldPoint()
    {
        // Pixel coordinates of mouse (x,y)
        Vector3 mousePoint = Input.mousePosition;
        // z coordinate of game object on screen
        mousePoint.z = mZCoord2;
        // Convert it to world points
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseAsWorldPoint() + mOffset2;
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        keyboardNavigation();
    }
}