using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timecount : MonoBehaviour {

	// Use this for initialization
	public static ScoreControl Instance;
	// Use this for initialization
	private float time = 60.0f;
	private int time_change = 0;
	private Text m_time;
	void Start () {
		m_time = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		time_change  = Mathf.CeilToInt(time);
		m_time.text = time_change.ToString ();
		time = time - 1.0f *Time.deltaTime;
		if(time < 0)
		{
			Application.LoadLevel(2);
		}

	}
}
