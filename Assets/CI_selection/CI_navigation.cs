using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class CI_navigation: MonoBehaviour {

	//public Camera mainCam; // it's not neccessary because we can get our camera from Camera.main

	public float currentTime;
	public float timeToDrop;

	void keyboardNavigation(){


		if (Input.GetKey(KeyCode.UpArrow)) {

			transform.Translate (this.transform.forward * Time.deltaTime);
		

		}else if (Input.GetKey(KeyCode.DownArrow)) {

			transform.Translate (this.transform.forward * -1 * Time.deltaTime); // invert transform.forward vector by *-1

		
		}else if (Input.GetKey(KeyCode.LeftArrow)) {

			transform.Translate (this.transform.right * -1 * Time.deltaTime);

			
		}else if (Input.GetKey(KeyCode.RightArrow)) {

			transform.Translate (this.transform.right * Time.deltaTime);

			
		}else if (Input.GetKey(KeyCode.W)) {

			transform.Translate (this.transform.up * Time.deltaTime);

			
		}else if (Input.GetKey(KeyCode.S)) {

			transform.Translate (this.transform.up * -1 * Time.deltaTime);

			
		}
		

		if(Input.GetKey(KeyCode.A)){ // yaw, rotation about the up vector
			//turn left
			transform.Rotate(this.transform.up,-15f*Time.deltaTime);
		}else if(Input.GetKey(KeyCode.D)){
			//turn right
			transform.Rotate(this.transform.up,+15f*Time.deltaTime);
		} //add other turns...


		if(Input.GetKey(KeyCode.Q)){ // roll, rotation about the forward vector
			//turn left
			transform.Rotate(this.transform.forward,-15f*Time.deltaTime);
		}else if(Input.GetKey(KeyCode.Z)){
			//turn right
			transform.Rotate(this.transform.forward,+15f*Time.deltaTime);
		}


		if(Input.GetKey(KeyCode.E)){ // pitch, rotation about the right arrow 
			//turn left
			transform.Rotate(this.transform.right,-15f*Time.deltaTime);
		}else if(Input.GetKey(KeyCode.C)){
			//turn right
			transform.Rotate(this.transform.right,+15f*Time.deltaTime);
		}
	}


	void joystickNavigation(){

		//float x = Input.GetAxis("Horizontal");
		float y = Input.GetAxis("Vertical");
	

		transform.Translate (Vector3.forward * y * Time.deltaTime); 

		if(Input.GetKey(KeyCode.X)){
			//turn left
			transform.Rotate(Vector3.up,-15f*Time.deltaTime);
		}else if(Input.GetKey(KeyCode.W)){
			//turn right
			
		}


	}

	void pointbasedNavigation(){


		//if (Input.GetMouseButtonDown (0)) { 


			RaycastHit raycastHit = new RaycastHit (); // create new raycast hit info object

			transform.Translate (Camera.main.ScreenPointToRay(Input.mousePosition).direction * Time.deltaTime); 

			
		//}
	}



	// Use this for initialization
	void Start () {
		timeToDrop = 2f;
	}

	// Update is called once per frame
	void Update () {
		keyboardNavigation ();
		// keyboardManipulation ();
		//joystickNavigation ();
		//pointbasedNavigation();

		//wayfinding

		
	}



}
