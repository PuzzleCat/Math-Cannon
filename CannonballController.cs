using UnityEngine;
using System.Collections;

public class CannonballController : MonoBehaviour {
	
	private Vector3 original;

	// Use this for initialization
	void Start () {
		original = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.CompareTag("Wall")){
			transform.position = original;
			gameObject.SetActive(false);
		}
		else if(other.gameObject.CompareTag("Problem")){
			transform.position = original;
			gameObject.SetActive(false);
		}
	}
}
