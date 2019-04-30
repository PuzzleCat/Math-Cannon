using UnityEngine;
using System.Collections;

public class CoverPage : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (delay ());
		PlayerPrefs.SetInt ("Return", 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator delay(){
		yield return new WaitForSeconds (2);
		Application.LoadLevel ("Start");
	}
}
