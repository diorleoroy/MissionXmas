using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {


	public GameObject Obj_Creat;//要生成的物件
	public float f_Time=10.0f; //生成間隔
	public Transform Tran_CreatPoint;//物件要生成的位置
	public Vector3 V3_Random;//隨機生成位置
	public float Zpos = 220.9f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		Zpos += 40 * Time.deltaTime;

//		V3_Random=new Vector3(Random.Range(-5.5f,5.5f),Random.Range(0,5.5f),  Zpos );
		V3_Random=new Vector3(Random.Range(-180.5f,180.5f),0,  Random.Range(0.5f,300.5f) );
		//Obj_Creat.transform.rotation = transform.Rotate(270, 0, 0);

		//XYZ隨機值
		if (f_Time > 0) {
			f_Time -= Time.deltaTime;
		}
		else{
//			GameObject Obj_Clone = Instantiate (Obj_Creat, V3_Random, Quaternion.identity) as GameObject;
			GameObject Obj_Clone = Instantiate (Obj_Creat, V3_Random, Quaternion.identity) as GameObject;

			f_Time=1.0f;
		}
	}
}
