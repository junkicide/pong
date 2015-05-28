using UnityEngine;
using System.Collections;



public class Scores : MonoBehaviour {
	int mescore;
	int enemyscore;
	public GUISkin ScoreSkin;
	// Use this for initialization
	void Start () {
	
	}
	public void IncreaseScore (int PlayerType) {
		if (PlayerType == 1) {
			mescore++;
		}
		if (PlayerType == 2) {
			enemyscore++;
		}
	}
	void OnGUI()
	{
		if (GUI.skin != ScoreSkin)
		{
			GUI.skin = ScoreSkin;
		}

		GUI.Label (new Rect(10,10,300,30), "My Score: " + mescore.ToString());
		           GUI.Label (new Rect(10,35,300,30), "Enemy Score: " + enemyscore.ToString());
		           }
		           // Update is called once per frame
	void Update () {
	
	}
}
