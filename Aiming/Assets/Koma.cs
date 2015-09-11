using UnityEngine;
using System.Collections;

public class Koma: MonoBehaviour 
	
{	
	public Transform target;
	public  string Name{ get; set;}
	public int Id{ get; set;}
	public long Posx { get; set; }
	
	public  long Posy { get; set; }
	public	Vector3 vec;
	public long rtrsx;
	public long rtrsy;

	bool s=false;
	 void Update()
	{

		if (Input.GetMouseButtonDown (0) && s == true) {
			vec = Input.mousePosition;
		




			Debug.Log (transform.localPosition);
		
	
			transform.SetParent (GameObject.Find ("main").transform, false);
			this.transform.position = vec;
			s = false;
		}

}
	public void Click(){

		s=true;



	}

	void Trs(){

		/*if (xx == 0) {
			rtrsx = 5;
		} else if (xx <= 0) {
			rtrsx = xx / 60 - 5;
		} else {
			rtrsx = 5- xx / 60;
		}
		if (xx == 0) {
			rtrsy = 5;
		} else if (xx <= 0) {
			rtrsy = xx / 64 - 5;
		} else {
			rtrsy= 5- xx / 64;
		}*/
	}
	
}