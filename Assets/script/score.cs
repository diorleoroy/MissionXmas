using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class score : MonoBehaviour {

//	public static ScoreControl Instance;
	// Use this for initialization
	public static int m_score = 0;
	private Text m_text;
	void Start () {
		m_text = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		m_text.text = m_score.ToString ();


		if(PlayerPrefs.GetInt("CallFunction")==1)
		{
			AddScore();
		}
		PlayerPrefs.SetInt("CallFunction",0);
	}
		
	public void AddScore()
	{
		m_score ++;
	}
}
