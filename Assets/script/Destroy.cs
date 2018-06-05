using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
	public GameObject abc;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

	void OnTriggerEnter(Collider collider){
		Debug.Log ("good");
		Destroy(this.gameObject);


		//abc.SetActive(false);

	}
 
}
