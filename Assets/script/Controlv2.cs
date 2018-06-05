using UnityEngine;
using System.Collections;
using Windows.Kinect;
using System.Collections.Generic;
using Kinect = Windows.Kinect;


public class Controlv2 : MonoBehaviour {


	// Use this for initialization
	private GameObject Body;
	private GameObject RightHand,LeftHand;
	private float time;

	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{
		float posz=10;
		float posx=0.0f;


		gameObject.transform.Translate(Vector3.forward*posz * Time.deltaTime);	
		//gameObject.transform.Translate(0, 0, 5 * Time.deltaTime);

		if(Body == null)
		{
			Body = GameObject.Find ("SpineBase");		
		}

		if(RightHand == null)
		{
			RightHand = GameObject.Find ("HandTipRight");		
		}
		else
		{
			if(LeftHand.transform.position.y > (RightHand.transform.position.y+1)){
				//posz=posz-1;
				//posy=posx+1;
				gameObject.transform.Rotate(Vector3.up, 40 * Time.deltaTime);

				//gameObject.transform.Translate(Vector3.forward*posz * Time.deltaTime);	
			}

			//gameObject.transform.Translate(Vector3.forward*posz * Time.deltaTime);	
		}


		if(LeftHand == null)
		{
			LeftHand = GameObject.Find ("HandTipLeft");		
		}
		else
		{
			if((LeftHand.transform.position.y+1) < RightHand.transform.position.y  ){
				//posz=posz-1;
				//posy=posx+1;
				gameObject.transform.Rotate(Vector3.up, -40  * Time.deltaTime);
				//posz=5;
				//		gameObject.transform.Translate(Vector3.forward*posz * Time.deltaTime);	
			}
			//posz=50;
			//gameObject.transform.Translate(Vector3.forward*posz * Time.deltaTime);	
		}



	}
}