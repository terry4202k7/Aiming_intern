using UnityEngine;
using System.Collections;

public class Cal{

	public static long posy, posx;


	public static long calx1(long x){


		if (x == 5) {
			posx = 0;
		} else {
			posx = (5 - x) * 60;
		}
		return posx;
	}
	public static long caly1(long y){
		
		
		if (y == 5) {
			posy = 0;
		} else {
			posy = (5 - y) * 64;
		}
		return posy;
	}


/*public static long calx2(long rx){
		
		
		if (rx == 0) {
			rtrsx = 5;
		} else if (rx <= 0) {
			rtrsx = rx / 60 - 5;
		} else {
			rtrsx = 5- rx / 60;
		}
	}
	public static long caly2(long ry){
		
		
		if (y == 5) {
			posy = 0;
		} else {
			posy = (5 - y) * 64;
		}
		return posy;
	}*/

}




