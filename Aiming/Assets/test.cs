using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using MiniJSON;


public class Koma: MonoBehaviour 

{	
	public  string Name{ get; set;}
	public int Id{ get; set;}
	public long Posx { get; set; }
	
	public  long Posy { get; set; }



	/*public GameObject Pice()

	{

	
	}*/
	
}




public class test : MonoBehaviour {
	public string komaName;
	public long posx; 
	public long posy; 
	public long owner;
	public GameObject fu;
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



	public List<Koma> komas  = new List<Koma>();
	public int fk=2;




	//p GameObject fu89;

	// Use this for initialization
	void Start () {
		Debug.Log (SaveId.play_id+"in main page");
	
	//	stantiate(enemy);

	//	fu1.transform.localPosition = new Vector3(0, 100, 0);
		StartCoroutine (GetData2());
	}



	// Update is called once per frame
	void Update () {	
		//StartCoroutine (GetData2());
		/*
		foreach (Koma ssss in komas) 
		{
		Debug.Log(ssss);
		}
		//Debug.Log(komas[fk]);

*/
	}

	public void make(){// 配列つくって回せばよかった

	





		
		if (owner == 2) {
			switch (komaName) {
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
				komaName= (string)description["name"];
				posx= (long)description["posx"];
				posy= (long)description["posy"];
				owner= (long)description["owner"];

				
				if (posx == 5) {
					posx = 0;
				} else  {
					posx = (5 - posx) * 60;
				}
				if (posy == 5) {
					posy = 0;
				} else  {
					posy = (5 - posy) * 64;
				}

				make ();
				


			//	Debug.Log(posx+"x:"+posy+"y:"+owner+"own");


		}
	}


}
}