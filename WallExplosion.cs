using UnityEngine;
using System.Collections;

public class WallExplosion : MonoBehaviour {

	public AudioClip cannon;

	private AudioSource source;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Cannonball")) {
			source.PlayOneShot (cannon, 1);
		}
	}
}
