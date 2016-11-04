using UnityEngine;
using System.Collections;

public class TouchScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Input.touches -=- array
		//Touch myTouch = Input.GetTouch (0); -=- individual Touch
	}

	void OnGUI()
	{
		foreach (Touch touch in Input.touches)
		{
			string message = "";
			message += "ID: " +touch.fingerId +"\n";
			message += "Phase: " +touch.phase.ToString() +"\n";
			message += "TapCount: " + touch.tapCount +"\n";
			message += "Pos: " + touch.position +"\n";

			int num = touch.fingerId;
			GUI.Label(new Rect (0+num*120,0,120,100),message);
		}
	}
}
