using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	bool touching = false;
	public Material[] met = new Material[2];
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.touchCount==1/*&&touching == false*/) {
			gameObject.GetComponent<Renderer>().material = met[0];
			//transform.Translate(Input.touches[0].deltaPosition.x*0.25f,Input.touches[0].deltaPosition.y*0.25f,0);
			//this.gameObject.transform.Translate(new Vector3(0,1,0));
			this.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.touches[0].position.x,Input.touches[0].position.y,10));
			/*touching = true;*/
		}
		if (Input.touchCount == 0) {
			gameObject.GetComponent<Renderer>().material = met[1];
			/*touching = false;*/
		}

	}
}
