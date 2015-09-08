using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
public	IEnumerator Start () {

		string url = "http://192.168.3.83:3000/play.json";
		WWW www = new WWW(url);
		yield return www;
		if (www.error == null) {
			Debug.Log("outou"+www.text);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
