using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CI_selection : MonoBehaviour {

	public List<GameObject> selectedObjects = new List<GameObject>();
	public RaycastHit prevHit; 
	public bool prev;
    public Renderer rend = new Renderer();
	public float amountToMove = 0.05f;
	public float amountToRotate = 1.0f;
	public float currentTime;
	public float timeToDrop;

	void keyboardManipulation()
	{
		// For Translating the Selected Object
		// ------------------------------------------------------
		if(prev == true)
		{
			// if (Input.GetKey(KeyCode.I)) {
			// 	prevHit.transform.Translate(0.0f, amountToMove, 0.0f);
			// }
			// else if (Input.GetKey(KeyCode.K)) {
			// 	prevHit.transform.Translate(0.0f, -amountToMove, 0.0f);
			// }

			// if (Input.GetKey(KeyCode.J)) {
			// 	prevHit.transform.Translate(-amountToMove, 0.0f, 0.0f);
			// }
			// else if (Input.GetKey(KeyCode.L)) {
			// 	prevHit.transform.Translate(amountToMove, 0.0f, 0.0f);
			// }

			// if (Input.GetKey(KeyCode.Y)) {
			// 	prevHit.transform.Translate(0.0f, 0.0f, amountToMove);
			// }
			// else if (Input.GetKey(KeyCode.H)) {
			// 	prevHit.transform.Translate(0.0f, 0.0f, -amountToMove);
			// }

		// For Rotating the Selected Object
		// ------------------------------------------------------

			if (Input.GetKey(KeyCode.I)) {
				prevHit.transform.Rotate(prevHit.transform.up, amountToRotate);
			}
			else if (Input.GetKey(KeyCode.K)) {
				prevHit.transform.Rotate(prevHit.transform.up, -amountToRotate);
			}

			if (Input.GetKey(KeyCode.J)) {
				prevHit.transform.Rotate(prevHit.transform.right, -amountToRotate);
			}
			else if (Input.GetKey(KeyCode.L)) {
				prevHit.transform.Rotate(prevHit.transform.right, amountToRotate);
			}

			if (Input.GetKey(KeyCode.Y)) {
				prevHit.transform.Rotate(prevHit.transform.forward, amountToRotate);
			}
			else if (Input.GetKey(KeyCode.H)) {
				prevHit.transform.Rotate(prevHit.transform.forward, -amountToRotate);
			}
		}
	}


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

	void mouseRayCast(){   
		//for joystick button, replace mousedown for Input. command for button.
		//for vive use the transform.forward for the joystick controller. 

		LineRenderer ray = GetComponent<LineRenderer>();
	
		Vector3 p= new Vector3(0f,-4f,0f);

        /**part 1: change start point here to camera: ***/
        //  ray.SetPosition (0, new Vector3(0f,0f,0f));
		 ray.SetPosition (0, transform.forward+transform.position);
     

        //Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
		//grab mouse position and convert to the world, because we're working in 3D - x, y, and z axes
	

        /**part 2: change the end of the ray to somewhere in the world - i.e. where the mouse is pointing**/
        // ray.SetPosition(1, new Vector3(10f, 10f, 10f));
		Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
		ray.SetPosition(1, Camera.main.ScreenPointToRay(Input.mousePosition).direction*100f);


        if (Input.GetMouseButtonDown(0)) { // if left mouse button is clicked 
				bool objHit = false;
				RaycastHit raycastHit = new RaycastHit(); 
	

			if (Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out raycastHit)) { 
				 rend = new Renderer();
				if (prev == true) {
					 rend = prevHit.collider.GetComponent<Renderer> ();

                    /** Part 3: change the color back to white here**/
					rend.material.SetColor("_Color", Color.black);
					

                }

                print("p: "+raycastHit.collider.transform.position);
				//set previous to previous color

				
				prevHit = raycastHit;
				prev = true;

				 rend = raycastHit.collider.GetComponent<Renderer>();

				 //Set the main Color of the Material to a color
               		rend.material.SetColor("_Color", Color.blue);
					rend.transform.localPosition = Random.insideUnitSphere*2;

                print(raycastHit.collider.tag);
				}

				
			}
			

	}







	// Use this for initialization
	void Start () {

		timeToDrop = 2.0f;
		currentTime = 0.0f;

  		Material material = new Material(Shader.Find("Unlit/Color"));
        material.color = Color.red;

		LineRenderer ray= gameObject.AddComponent<LineRenderer>();
	
		// assign the material to the renderer
       		ray.GetComponent<Renderer>().material = material;

		ray.material = new Material(Shader.Find("_Color"));
		ray.material.SetColor("_Color", Color.red);

		ray.SetPosition (0, transform.localPosition );
		ray.SetPosition (1, transform.forward * 10f);	// transform.forward is forward vector of the transform

		ray.SetPosition (0, transform.forward+transform.position);//new Vector3(0f,0f,0.001f));\
		ray.SetPosition(1, transform.forward +transform.position*10f);	



		ray.startWidth = 0.001f;
		ray.endWidth = 0.001f;
		ray.enabled = true;

		prev = false;



	}



	void mouseRayCastplusButtonSelect(){   
		//for joystick button, replace mousedown for Input. command for button.
		//for vive use the transform.forward for the joystick controller. 


	}

	
	// Update is called once per frame
	void Update () {
		mouseRayCast ();

		if (currentTime > timeToDrop)
		{
			GameObject breadcrumb = GameObject.CreatePrimitive (PrimitiveType.Cube);
			breadcrumb.AddComponent<Rigidbody> ();
			breadcrumb.transform.localScale = new Vector3 (0.1f, 0.1f, 0.1f);
			breadcrumb.transform.position = transform.position;

			currentTime = 0.0f;
		}
		currentTime += Time.deltaTime;
		print(currentTime);


		keyboardNavigation ();
		keyboardManipulation ();
		//mouseRayCastplusButtonSelect();  
	}
}




