using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreControl : MonoBehaviour {
	// Use this for initialization
	private int CallFunction = 0;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}



	void OnTriggerEnter(Collider collider){
		Debug.Log ("good");
		Destroy(this.gameObject);
		//abc.SetActive(false);
	//	playerprefab.setbool("CallFunction",true);
		PlayerPrefs.SetInt("CallFunction",1);
	}
}
