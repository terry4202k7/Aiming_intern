using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using MiniJSON;


public class test : MonoBehaviour {
	public string komaName;
	public long posx; 
	public long posy; 
	public long owner;
	public GameObject fu;//gameObject 
	public GameObject kasya;
	public GameObject hisya;
	public GameObject keima;
	public GameObject kaku;
	public GameObject ou;
	public GameObject kin;
	public GameObject gin;
	public GameObject fue;
	public GameObject kasyae;
	public GameObject hisyae;
	public GameObject keimae;
	public GameObject kakue;
	public GameObject oue;
	public GameObject kine;
	public GameObject gine;


	public static List<Koma> komas  = new List<Koma>();





	//p GameObject fu89;

	// Use this for initialization
	void Start () {
		StartCoroutine (GetData2 ());

	}
	void Update () {	
	
	}

	public void make(){//駒の作成を行っている
		
		if (owner %2!=0 ) {
			switch (komaName) {//これは、やばい　要修正！！
			case "fu": 
			
				var obj = Instantiate (this.fu, new Vector3 (posx, posy, 0), Quaternion.identity) as GameObject;
			//error
				obj.transform.SetParent (GameObject.Find ("main").transform, false);

				komas.Add (obj.GetComponent<Koma> ());
				break;
			case "hisha": 
				obj = Instantiate (this.hisya, new Vector3 (posx, posy, 0), Quaternion.identity) as GameObject;
			//error
				obj.transform.SetParent (GameObject.Find ("main").transform, false);
				komas.Add (obj.GetComponent<Koma> ());
				break;
			case "kyosha": 
				obj = Instantiate (this.kasya, new Vector3 (posx, posy, 0), Quaternion.identity) as GameObject;
			//error
				obj.transform.SetParent (GameObject.Find ("main").transform, false);
				komas.Add (obj.GetComponent<Koma> ());
				break;
			case "keima": 
				obj = Instantiate (this.keima, new Vector3 (posx, posy, 0), Quaternion.identity) as GameObject;
			//error
				obj.transform.SetParent (GameObject.Find ("main").transform, false);
				komas.Add (obj.GetComponent<Koma> ());
				break;
			case "kaku": 
				obj = Instantiate (this.kaku, new Vector3 (posx, posy, 0), Quaternion.identity) as GameObject;
			//error
				obj.transform.SetParent (GameObject.Find ("main").transform, false);
				komas.Add (obj.GetComponent<Koma> ());
				break;
			case "kin": 
				obj = Instantiate (this.kin, new Vector3 (posx, posy, 0), Quaternion.identity) as GameObject;
			//error
				obj.transform.SetParent (GameObject.Find ("main").transform, false);
				komas.Add (obj.GetComponent<Koma> ());
				break;
			case "gin": 
				obj = Instantiate (this.gin, new Vector3 (posx, posy, 0), Quaternion.identity) as GameObject;
			//error
				obj.transform.SetParent (GameObject.Find ("main").transform, false);
				komas.Add (obj.GetComponent<Koma> ());
				break;
			case "oh": 
				obj = Instantiate (this.ou, new Vector3 (posx, posy, 0), Quaternion.identity) as GameObject;
			//error
				obj.transform.SetParent (GameObject.Find ("main").transform, false);
				komas.Add (obj.GetComponent<Koma> ());
				break;
	
			}
		} else {
			switch (komaName) {
			case "fu": 
			
				var obj = Instantiate (this.fue, new Vector3 (posx, posy, 0), Quaternion.identity) as GameObject;
			//error
				obj.transform.SetParent (GameObject.Find ("main").transform, false);
				komas.Add (obj.GetComponent<Koma> ());
				break;
			case "hisha": 
				obj = Instantiate (this.hisyae, new Vector3 (posx, posy, 0), Quaternion.identity) as GameObject;
			//error
				obj.transform.SetParent (GameObject.Find ("main").transform, false);
				komas.Add (obj.GetComponent<Koma> ());
				break;
			case "kyosha": 
				obj = Instantiate (this.kasyae, new Vector3 (posx, posy, 0), Quaternion.identity) as GameObject;
			//error
				obj.transform.SetParent (GameObject.Find ("main").transform, false);
				komas.Add (obj.GetComponent<Koma> ());
				break;
			case "keima": 
				obj = Instantiate (this.keimae, new Vector3 (posx, posy, 0), Quaternion.identity) as GameObject;
			//error
				obj.transform.SetParent (GameObject.Find ("main").transform, false);
				komas.Add (obj.GetComponent<Koma> ());
				break;
			case "kaku": 
				obj = Instantiate (this.kakue, new Vector3 (posx, posy, 0), Quaternion.identity) as GameObject;
			//error
				obj.transform.SetParent (GameObject.Find ("main").transform, false);
				komas.Add (obj.GetComponent<Koma> ());
				break;
			case "kin": 
				obj = Instantiate (this.kine, new Vector3 (posx, posy, 0), Quaternion.identity) as GameObject;
			//error
				obj.transform.SetParent (GameObject.Find ("main").transform, false);
				komas.Add (obj.GetComponent<Koma> ());
				break;
			case "gin": 
				obj = Instantiate (this.gine, new Vector3 (posx, posy, 0), Quaternion.identity) as GameObject;
			//error
				obj.transform.SetParent (GameObject.Find ("main").transform, false);
				komas.Add (obj.GetComponent<Koma> ());
				break;
			case "oh": 
				obj = Instantiate (this.oue, new Vector3 (posx, posy, 0), Quaternion.identity) as GameObject;
			//error
				obj.transform.SetParent (GameObject.Find ("main").transform, false);
				komas.Add (obj.GetComponent<Koma> ());
				break;
			}

		}
		
		
	}
	
	
	IEnumerator GetData2(){// 駒の位置情報の取得とパース　ツール化すればよかった。
		
		Debug.Log("in get data");
		string url = SaveId.strIp+"/plays/"+SaveId.play_id+"/pieces";
		
		WWW www = new WWW(url);
		yield return www;
		if (www.error == null) {
			Debug.Log(www.text);
			var textAsset =www;
			var jsonText = textAsset.text;

		/*
		 * パース方法を修正する方法がある
		 * 
		 * 駒別に値を持たせるのが楽になるようにするべき
		 */

			var json = Json.Deserialize (jsonText) as Dictionary<string, object>;
		

			for (int i = 1; i < 41; i++){
				string ss=i.ToString();
		
			var description = json[ss] as Dictionary<string, object>;
				komaName= (string)description["name"];
				posx= (long)description["posx"];
				posy= (long)description["posy"];
				owner= (long)description["owner"];

				posx = Cal.calx1(posx);
				posy = Cal.caly1(posy);




				make ();
		}
	}


}
}