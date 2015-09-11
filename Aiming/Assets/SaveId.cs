using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using MiniJSON;

public class SaveId : MonoBehaviour {




	public static string strId, strRo, strIp;
	public InputField inputFieldId,inputFieldRo,inputFieldIp;
	//public Text textId;
	public static string  state ,role;
	public static long user_id,play_id;

	public GameObject notice;


	void Start(){

		// This will return the game object named Hand in the scene.
		notice = GameObject.Find("Canvas/Notice");

		notice.SetActive(false);

	}
	void Update(){
		if (state == "waiting") {
			notice.SetActive (true);

			StartCoroutine (GetData ());// updating game state
		} else if (state == "playing") {

			Debug.Log(" The Game will start ");
			Application.LoadLevel("main");
		}

	}

	public void SaveTextId () { // LOG In ボタンが押されたら実行
		strId = inputFieldId.text;　
		strRo = inputFieldRo.text;
		strIp = inputFieldIp.text;


		Debug.Log (strId);
		StartCoroutine(PostData());

}
//	192.168.33.11:3000
	 IEnumerator PostData(){

		Debug.Log("in get data");
		string url = strIp+"/users/login";
		WWWForm form = new WWWForm();
		form.AddField("name", strId);
		form.AddField("room_no", strRo);
		WWW www = new WWW(url, form);
		yield return www;



		if (www.error == null) {
			Debug.Log(www.text);
			var textAsset =www;
			var jsonText = textAsset.text;
			

			var json = Json.Deserialize (jsonText) as Dictionary<string, object>;
			user_id= (long)json["user_id"];
			Debug.Log (user_id);
			play_id= (long)json["play_id"];
			Debug.Log (play_id);
			state= (string)json["state"];
			Debug.Log (state);
			role= (string)json["role"];
			Debug.Log (role);

		}
	}
	IEnumerator GetData(){
		
		Debug.Log("in get data");
		string url = strIp+"/plays/"+play_id+"/state";
	
		WWW www = new WWW(url);
		yield return www;
		if (www.error == null) {
			Debug.Log(www.text);
			var textAsset =www;
			var jsonText = textAsset.text;
			var json = Json.Deserialize (jsonText) as Dictionary<string, object>;

	 state= (string)json["state"];
			Debug.Log (state);

		}
	}

	}

