using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Advertisements;

public class StartButton : MonoBehaviour {

	public GameObject panel;
	public GameObject addition;
	public GameObject subtraction;
	public GameObject multiplication;
	public GameObject division;
	public GameObject mixed;
	public Text timeMode;

	private bool add;
	private bool subtract;
	private bool multiply;
	private bool divide;
	private bool mix;

	// Use this for initialization
	void Start () {
		//Screen.orientation = ScreenOrientation.LandscapeLeft;
		add = false;
		subtract = false;
		multiply = false;
		divide = false;
		mix = false;
		if (PlayerPrefs.GetInt ("Time") == 0) {
			timeMode.text = "Easy";
		} else {
			timeMode.text = "Time Attack";
		}
	}

	IEnumerator wait(){
		yield return new WaitForSeconds (1);
		if (Advertisement.isReady() == true) {
			Advertisement.Show ();
		} else {
			wait ();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Add(){
		if (add == false) {
			addition.SetActive (true);
			add = true;
		} else {
			add = false;
			addition.SetActive (false);
		}
	}
	public void Subtract(){
		if (subtract == false) {
			subtraction.SetActive (true);
			subtract = true;
		} else {
			subtract = false;
			subtraction.SetActive (false);
		}
	}
	public void Multiply(){
		if (multiply == false) {
			multiplication.SetActive (true);
			multiply = true;
		} else {
			multiply = false;
			multiplication.SetActive (false);
		}
	}
	public void Divide(){
		if (divide == false) {
			division.SetActive (true);
			divide = true;
		} else {
			divide = false;
			division.SetActive (false);
		}
	}
	public void Mix(){
		if (mix == false) {
			mixed.SetActive (true);
			mix = true;
		} else {
			mix = false;
			mixed.SetActive (false);
		}
	}

	public void mixedHard(){
		Application.LoadLevel ("Mixed-Hard");
		//Screen.orientation = ScreenOrientation.LandscapeLeft;

		if (PlayerPrefs.GetInt ("Return") == 0) {
			PlayerPrefs.SetInt ("Return", 1);
		}
		else if (PlayerPrefs.GetInt ("Return") == 1) {
			PlayerPrefs.SetInt ("Return", 2);
		}
		else if (PlayerPrefs.GetInt ("Return") == 2) {
			PlayerPrefs.SetInt ("Return", 3);
		}
	}
	public void mixedMedium(){
		Application.LoadLevel ("Mixed-Medium");
		//Screen.orientation = ScreenOrientation.LandscapeLeft;

		if (PlayerPrefs.GetInt ("Return") == 0) {
			PlayerPrefs.SetInt ("Return", 1);
		}
		else if (PlayerPrefs.GetInt ("Return") == 1) {
			PlayerPrefs.SetInt ("Return", 2);
		}
		else if (PlayerPrefs.GetInt ("Return") == 2) {
			PlayerPrefs.SetInt ("Return", 3);
		}
	}
	public void mixedEasy(){
		Application.LoadLevel ("Mixed-Easy");
		//Screen.orientation = ScreenOrientation.LandscapeLeft;

		if (PlayerPrefs.GetInt ("Return") == 0) {
			PlayerPrefs.SetInt ("Return", 1);
		}
		else if (PlayerPrefs.GetInt ("Return") == 1) {
			PlayerPrefs.SetInt ("Return", 2);
		}
		else if (PlayerPrefs.GetInt ("Return") == 2) {
			PlayerPrefs.SetInt ("Return", 3);
		}
	}
	public void additionHard(){
		Application.LoadLevel ("Addition-Hard");
		//Screen.orientation = ScreenOrientation.LandscapeLeft;

		if (PlayerPrefs.GetInt ("Return") == 0) {
			PlayerPrefs.SetInt ("Return", 1);
		}
		else if (PlayerPrefs.GetInt ("Return") == 1) {
			PlayerPrefs.SetInt ("Return", 2);
		}
		else if (PlayerPrefs.GetInt ("Return") == 2) {
			PlayerPrefs.SetInt ("Return", 3);
		}
	}
	public void additionMedium(){
		Application.LoadLevel ("Addition-Medium");
		//Screen.orientation = ScreenOrientation.LandscapeLeft;

		if (PlayerPrefs.GetInt ("Return") == 0) {
			PlayerPrefs.SetInt ("Return", 1);
		}
		else if (PlayerPrefs.GetInt ("Return") == 1) {
			PlayerPrefs.SetInt ("Return", 2);
		}
		else if (PlayerPrefs.GetInt ("Return") == 2) {
			PlayerPrefs.SetInt ("Return", 3);
		}
	}
	public void additionEasy(){
		Application.LoadLevel ("Addition-Easy");
		//Screen.orientation = ScreenOrientation.LandscapeLeft;

		if (PlayerPrefs.GetInt ("Return") == 0) {
			PlayerPrefs.SetInt ("Return", 1);
		}
		else if (PlayerPrefs.GetInt ("Return") == 1) {
			PlayerPrefs.SetInt ("Return", 2);
		}
		else if (PlayerPrefs.GetInt ("Return") == 2) {
			PlayerPrefs.SetInt ("Return", 3);
		}
	}
	public void subtractionHard(){
		Application.LoadLevel ("Subtraction-Hard");
		//Screen.orientation = ScreenOrientation.LandscapeLeft;

		if (PlayerPrefs.GetInt ("Return") == 0) {
			PlayerPrefs.SetInt ("Return", 1);
		}
		else if (PlayerPrefs.GetInt ("Return") == 1) {
			PlayerPrefs.SetInt ("Return", 2);
		}
		else if (PlayerPrefs.GetInt ("Return") == 2) {
			PlayerPrefs.SetInt ("Return", 3);
		}
	}
	public void subtractionMedium(){
		Application.LoadLevel ("Subtraction-Medium");
		//Screen.orientation = ScreenOrientation.LandscapeLeft;

		if (PlayerPrefs.GetInt ("Return") == 0) {
			PlayerPrefs.SetInt ("Return", 1);
		}
		else if (PlayerPrefs.GetInt ("Return") == 1) {
			PlayerPrefs.SetInt ("Return", 2);
		}
		else if (PlayerPrefs.GetInt ("Return") == 2) {
			PlayerPrefs.SetInt ("Return", 3);
		}
	}
	public void subtractionEasy(){
		Application.LoadLevel ("Subtraction-Easy");
		//Screen.orientation = ScreenOrientation.LandscapeLeft;

		if (PlayerPrefs.GetInt ("Return") == 0) {
			PlayerPrefs.SetInt ("Return", 1);
		}
		else if (PlayerPrefs.GetInt ("Return") == 1) {
			PlayerPrefs.SetInt ("Return", 2);
		}
		else if (PlayerPrefs.GetInt ("Return") == 2) {
			PlayerPrefs.SetInt ("Return", 3);
		}
	}
	public void multiplicationHard(){
		Application.LoadLevel ("Multiplication-Hard");
		//Screen.orientation = ScreenOrientation.LandscapeLeft;

		if (PlayerPrefs.GetInt ("Return") == 0) {
			PlayerPrefs.SetInt ("Return", 1);
		}
		else if (PlayerPrefs.GetInt ("Return") == 1) {
			PlayerPrefs.SetInt ("Return", 2);
		}
		else if (PlayerPrefs.GetInt ("Return") == 2) {
			PlayerPrefs.SetInt ("Return", 3);
		}
	}
	public void multiplicationMedium(){
		Application.LoadLevel ("Multiplication-Medium");
		//Screen.orientation = ScreenOrientation.LandscapeLeft;

		if (PlayerPrefs.GetInt ("Return") == 0) {
			PlayerPrefs.SetInt ("Return", 1);
		}
		else if (PlayerPrefs.GetInt ("Return") == 1) {
			PlayerPrefs.SetInt ("Return", 2);
		}
		else if (PlayerPrefs.GetInt ("Return") == 2) {
			PlayerPrefs.SetInt ("Return", 3);
		}
	}
	public void multiplicationEasy(){
		Application.LoadLevel ("Multiplication-Easy");
		//Screen.orientation = ScreenOrientation.LandscapeLeft;

		if (PlayerPrefs.GetInt ("Return") == 0) {
			PlayerPrefs.SetInt ("Return", 1);
		}
		else if (PlayerPrefs.GetInt ("Return") == 1) {
			PlayerPrefs.SetInt ("Return", 2);
		}
		else if (PlayerPrefs.GetInt ("Return") == 2) {
			PlayerPrefs.SetInt ("Return", 3);
		}
	}
	public void divisionHard(){
		Application.LoadLevel ("Division-Hard");
		//Screen.orientation = ScreenOrientation.LandscapeLeft;

		if (PlayerPrefs.GetInt ("Return") == 0) {
			PlayerPrefs.SetInt ("Return", 1);
		}
		else if (PlayerPrefs.GetInt ("Return") == 1) {
			PlayerPrefs.SetInt ("Return", 2);
		}
		else if (PlayerPrefs.GetInt ("Return") == 2) {
			PlayerPrefs.SetInt ("Return", 3);
		}
	}
	public void divisionMedium(){
		Application.LoadLevel ("Division-Medium");
		//Screen.orientation = ScreenOrientation.LandscapeLeft;

		if (PlayerPrefs.GetInt ("Return") == 0) {
			PlayerPrefs.SetInt ("Return", 1);
		}
		else if (PlayerPrefs.GetInt ("Return") == 1) {
			PlayerPrefs.SetInt ("Return", 2);
		}
		else if (PlayerPrefs.GetInt ("Return") == 2) {
			PlayerPrefs.SetInt ("Return", 3);
		}
	}
	public void divisionEasy(){
		Application.LoadLevel ("Division-Easy");
		//Screen.orientation = ScreenOrientation.LandscapeLeft;

		if (PlayerPrefs.GetInt ("Return") == 0) {
			PlayerPrefs.SetInt ("Return", 1);
		}
		else if (PlayerPrefs.GetInt ("Return") == 1) {
			PlayerPrefs.SetInt ("Return", 2);
		}
		else if (PlayerPrefs.GetInt ("Return") == 2) {
			PlayerPrefs.SetInt ("Return", 3);
		}
	}
	public void inequality(){
		Application.LoadLevel ("Inequality");
		//Screen.orientation = ScreenOrientation.LandscapeLeft;

		if (PlayerPrefs.GetInt ("Return") == 0) {
			PlayerPrefs.SetInt ("Return", 1);
		}
		else if (PlayerPrefs.GetInt ("Return") == 1) {
			PlayerPrefs.SetInt ("Return", 2);
		}
		else if (PlayerPrefs.GetInt ("Return") == 2) {
			PlayerPrefs.SetInt ("Return", 3);
		}
	}
	public void fibonacci(){
		Application.LoadLevel ("Fibonacci");
		//Screen.orientation = ScreenOrientation.LandscapeLeft;

		if (PlayerPrefs.GetInt ("Return") == 0) {
			PlayerPrefs.SetInt ("Return", 1);
		}
		else if (PlayerPrefs.GetInt ("Return") == 1) {
			PlayerPrefs.SetInt ("Return", 2);
		}
		else if (PlayerPrefs.GetInt ("Return") == 2) {
			PlayerPrefs.SetInt ("Return", 3);
		}
	}

	public void home(){
		Application.LoadLevel ("Start");
		//Screen.orientation = ScreenOrientation.LandscapeLeft;

		if (PlayerPrefs.GetInt ("Return") == 0) {
			PlayerPrefs.SetInt ("Return", 1);
		}
		else if (PlayerPrefs.GetInt ("Return") == 1) {
			PlayerPrefs.SetInt ("Return", 2);
		}
		else if (PlayerPrefs.GetInt ("Return") == 2) {
			PlayerPrefs.SetInt ("Return", 3);
		}
	}

	public void instructions(){
		panel.SetActive (true);
	}
	public void closeInstructions(){
		panel.SetActive (false);
	}

	public void time(){
		if (PlayerPrefs.GetInt ("Time") == 0) {
			PlayerPrefs.SetInt ("Time", 1);
			timeMode.text = "Time Attack";
		} else {
			PlayerPrefs.SetInt ("Time", 0);
			timeMode.text = "Easy";
		}
	}
}
