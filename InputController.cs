using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InputController : MonoBehaviour {

	public Text number;
	public GameObject spaceship;
	public GameObject spaceship1;
	public GameObject spaceship2;
	public Text levelMode;

	private string n;

	// Use this for initialization
	void Start () {
		n = "";
		number.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		if (levelMode.text == "Fibonacci") {
			if (spaceship.activeSelf == false) {
				n = "";
				spaceship.SetActive (true);
				spaceship.GetComponent<ProblemGenerator> ().reset ();
			}
		}
		if (spaceship.activeSelf == false && spaceship1.activeSelf == false && spaceship2.activeSelf == false) {
			n = "";
			int r = Random.Range(0, 3);
			if(r == 0){
				spaceship.SetActive(true);
				spaceship.GetComponent<ProblemGenerator>().reset();
			}
			else if(r == 1){
				spaceship1.SetActive(true);
				spaceship1.GetComponent<ProblemGenerator>().reset();
			}
			else{
				spaceship2.SetActive(true);
				spaceship2.GetComponent<ProblemGenerator>().reset();
			}
		}
		number.text = n;
	}

	public void press0(){
		n = n + "0";
	}
	public void press1(){
		n = n + "1";
	}
	public void press2(){
		n = n + "2";
	}
	public void press3(){
		n = n + "3";
	}
	public void press4(){
		n = n + "4";
	}
	public void press5(){
		n = n + "5";
	}
	public void press6(){
		n = n + "6";
	}
	public void press7(){
		n = n + "7";
	}
	public void press8(){
		n = n + "8";
	}
	public void press9(){
		n = n + "9";
	}
	public void clear(){
		n = "";
	}
	public void negative(){
		n = "-" + n;
	}
	public void lessThan(){
		n = "<";
	}
	public void equalTo(){
		n = "=";
	}
	public void greaterThan(){
		n = ">";
	}

}
