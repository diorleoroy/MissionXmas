using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class showfinall : MonoBehaviour {
	private Text m_finally;
	int finallyscore = score.m_score;
	// Use this for initialization
	void Start () {
		m_finally = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		m_finally.text = finallyscore.ToString ();
	}
}
