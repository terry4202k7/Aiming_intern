using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using MiniJSON;

public class SaveId : MonoBehaviour {
	
	string strId, strRo;
	public InputField inputFieldId,inputFieldRo ;
	//public Text textId;

	public void SaveTextId () {
		strId = inputFieldId.text;
		strRo = inputFieldRo.text;
		Debug.Log (strId);
		StartCoroutine(GetData());

}

	 IEnumerator GetData(){

		Debug.Log("in get data");
		string url = "192.168.33.11:3000/users/login";
		WWWForm form = new WWWForm();
		form.AddField("name", strId);
		form.AddField("room_no", strRo);
		WWW www = new WWW(url, form);
		yield return www;
		if (www.error == null) {
			Debug.Log(www.text);
			var textAsset =www;
			var jsonText = textAsset.text;
			
			// 文字列を json に合わせて構成された辞書に変換
			var json = Json.Deserialize (jsonText) as Dictionary<string, object>;
			Debug.Log (json["user_id"]);
			Debug.Log (json["play_id"]);
			Debug.Log (json["state"]);
			Debug.Log (json["role"]);
		}
	}

	}

