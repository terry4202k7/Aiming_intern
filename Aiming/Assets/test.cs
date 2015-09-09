using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using MiniJSON;

public class test : MonoBehaviour {
	public long posx; 
	public long posy; 
	public long owner;

	// Use this for initialization
	void Start () {
		Debug.Log (SaveId.play_id+"in main page");
		StartCoroutine (GetData2());
	}
	
	// Update is called once per frame
	void Update () {	
		//StartCoroutine (GetData2());
	
	}


	IEnumerator GetData2(){
		
		Debug.Log("in get data");
		string url = "192.168.33.11:3000/plays/"+SaveId.play_id+"/pieces";
		
		WWW www = new WWW(url);
		yield return www;
		if (www.error == null) {
			Debug.Log(www.text);
			var textAsset =www;
			var jsonText = textAsset.text;
		
		//	string ss="2";

			var json = Json.Deserialize (jsonText) as Dictionary<string, object>;
		

			for (int i = 1; i < 41; i++){
				string ss=i.ToString();
		
			var description = json[ss] as Dictionary<string, object>;
				posx= (long)description["posx"];
				posy= (long)description["posy"];
				owner= (long)description["owner"];

				Debug.Log(posx+"x:"+posy+"y:"+owner+"own");
		
			}

		}
	}
}
