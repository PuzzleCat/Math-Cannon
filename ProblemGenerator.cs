using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ProblemGenerator : MonoBehaviour {

	public Text question;
	public Text number;
	public GameObject cannon;
	public float speed;
	public Text Lose;
	public GameObject panel;
	public Text levelMode;
	public Text score;
	public Text highScore;

	private int answer;
	private int n1;
	private int n2;
	private int f;
	private int level;
	private string ans;
	private Vector3 target;
	private Vector3 initial;

	// Use this for initialization
	void Start () {
		if (levelMode.text == "Mixed-Hard") {
			highScore.text = "High Score: " + PlayerPrefs.GetInt ("MixedHardScore");
		}
		else if (levelMode.text == "Mixed-Medium") {
			highScore.text = "High Score: " + PlayerPrefs.GetInt ("MixedMediumScore");
		}
		else if (levelMode.text == "Mixed-Easy") {
			highScore.text = "High Score: " + PlayerPrefs.GetInt ("MixedEasyScore");
		}
		else if (levelMode.text == "Addition-Hard") {
			highScore.text = "High Score: " + PlayerPrefs.GetInt ("AdditionHardScore");
		}
		else if (levelMode.text == "Addition-Medium") {
			highScore.text = "High Score: " + PlayerPrefs.GetInt ("AdditionMediumScore");
		}
		else if (levelMode.text == "Addition-Easy") {
			highScore.text = "High Score: " + PlayerPrefs.GetInt ("AdditionEasyScore");
		}
		else if (levelMode.text == "Subtraction-Hard") {
			highScore.text = "High Score: " + PlayerPrefs.GetInt ("SubtractionHardScore");
		}
		else if (levelMode.text == "Subtraction-Medium") {
			highScore.text = "High Score: " + PlayerPrefs.GetInt ("SubtractionMediumScore");
		}
		else if (levelMode.text == "Subtraction-Easy") {
			highScore.text = "High Score: " + PlayerPrefs.GetInt ("SubtractionEasyScore");
		}
		else if (levelMode.text == "Multiplication-Hard") {
			highScore.text = "High Score: " + PlayerPrefs.GetInt ("MultiplicationHardScore");
		}
		else if (levelMode.text == "Multiplication-Medium") {
			highScore.text = "High Score: " + PlayerPrefs.GetInt ("MultiplicationMediumScore");
		}
		else if (levelMode.text == "Multiplication-Easy") {
			highScore.text = "High Score: " + PlayerPrefs.GetInt ("MultiplicationEasyScore");
		}
		else if (levelMode.text == "Division-Hard") {
			highScore.text = "High Score: " + PlayerPrefs.GetInt ("DivisionHardScore");
		}
		else if (levelMode.text == "Division-Medium") {
			highScore.text = "High Score: " + PlayerPrefs.GetInt ("DivisionMediumScore");
		}
		else if (levelMode.text == "Division-Easy") {
			highScore.text = "High Score: " + PlayerPrefs.GetInt ("DivisionEasyScore");
		}
		else if (levelMode.text == "Inequality") {
			highScore.text = "High Score: " + PlayerPrefs.GetInt ("InequalityScore");
		}
		else if (levelMode.text == "Fibonacci") {
			highScore.text = "High Score: " + PlayerPrefs.GetInt ("FibonacciScore");
		}
		target = cannon.transform.position;
		Lose.text = "";
		initial = transform.position;
		if (levelMode.text == "Mixed-Hard") {
			f = Random.Range (0, 4);
			//0 = addition, 1 = subtraction, 2 = multiplication, 3 = division;
			if (f < 2) {
				level = Random.Range (1, 5);
				if (level == 1) {
					n1 = Random.Range (-10, 10);
					n2 = Random.Range (-10, 10);
				} else if (level == 2) {
					n1 = Random.Range (-100, 100);
					n2 = Random.Range (-100, 100);
				} else if (level == 3) {
					n1 = Random.Range (-1000, 1000);
					n2 = Random.Range (-1000, 1000);
				} else if (level == 4) {
					n1 = Random.Range (-10000, 10000);
					n2 = Random.Range (-10000, 10000);
				}
			} else if (f == 2) {
				level = Random.Range (1, 3);
				if (level == 1) {
					n1 = Random.Range (-10, 10);
					n2 = Random.Range (-10, 10);
				} else if (level == 2) {
					n1 = Random.Range (-100, 100);
					n2 = Random.Range (-100, 100);
				}
			} else {
				level = Random.Range (1, 3);
				if (level == 1) {
					int n = Random.Range (0, 2);
					if (n == 0) {
						n2 = Random.Range (-10, -1);
					} else {
						n2 = Random.Range (1, 10);
					}
					n1 = (Random.Range (-10, 10)) * n2;
				} else if (level == 2) {
					int n = Random.Range (0, 2);
					if (n == 0) {
						n2 = Random.Range (-100, -1);
					} else {
						n2 = Random.Range (1, 100);
					}
					n1 = (Random.Range (-100, 100)) * n2;
				}
			}
			if (f == 0) {
				answer = n1 + n2;
				if (n2 < 0) {
					question.text = "" + n1 + "+(" + n2 + ")";
				} else {
					question.text = "" + n1 + "+" + n2;
				}
			} else if (f == 1) {
				answer = n1 - n2;
				if (n2 < 0) {
					question.text = "" + n1 + "-(" + n2 + ")";
				} else {
					question.text = "" + n1 + "-" + n2;
				}
			} else if (f == 2) {
				answer = n1 * n2;
				if (n2 < 0) {
					question.text = "" + n1 + "*(" + n2 + ")";
				} else {
					question.text = "" + n1 + "*" + n2;
				}
			} else {
				answer = n1 / n2;
				if (n2 < 0) {
					question.text = "" + n1 + "/(" + n2 + ")";
				} else {
					question.text = "" + n1 + "/" + n2;
				}
			}
		} else if (levelMode.text == "Mixed-Medium") {
			f = Random.Range (0, 4);
			//0 = addition, 1 = subtraction, 2 = multiplication, 3 = division;
			if (f < 2) {
				level = Random.Range (1, 3);
				if (level == 1) {
					n1 = Random.Range (-10, 10);
					n2 = Random.Range (-10, 10);
				} else if (level == 2) {
					n1 = Random.Range (-100, 100);
					n2 = Random.Range (-100, 100);
				}
			} else if (f == 2) {
				n1 = Random.Range (-10, 10);
				n2 = Random.Range (-10, 10);
			} else {
				int n = Random.Range (0, 2);
				if (n == 0) {
					n2 = Random.Range (-10, -1);
				} else {
					n2 = Random.Range (1, 10);
				}
				n1 = (Random.Range (-10, 10)) * n2;
			}
			if (f == 0) {
				answer = n1 + n2;
				if (n2 < 0) {
					question.text = "" + n1 + "+(" + n2 + ")";
				} else {
					question.text = "" + n1 + "+" + n2;
				}
			} else if (f == 1) {
				answer = n1 - n2;
				if (n2 < 0) {
					question.text = "" + n1 + "-(" + n2 + ")";
				} else {
					question.text = "" + n1 + "-" + n2;
				}
			} else if (f == 2) {
				answer = n1 * n2;
				if (n2 < 0) {
					question.text = "" + n1 + "*(" + n2 + ")";
				} else {
					question.text = "" + n1 + "*" + n2;
				}
			} else {
				answer = n1 / n2;
				if (n2 < 0) {
					question.text = "" + n1 + "/(" + n2 + ")";
				} else {
					question.text = "" + n1 + "/" + n2;
				}
			}
		} else if (levelMode.text == "Mixed-Easy") {
			f = Random.Range (0, 4);
			//0 = addition, 1 = subtraction, 2 = multiplication, 3 = division;
			if (f == 0) {
				n1 = Random.Range (0, 10);
				n2 = Random.Range (0, 10);
			}
			if (f == 1) {
				n2 = Random.Range (0, 10);
				n1 = Random.Range (0, 10) + n2;
			} else if (f == 2) {
				n1 = Random.Range (0, 10);
				n2 = Random.Range (0, 10);
			} else {
				n2 = Random.Range (1, 10);
				n1 = (Random.Range (0, 10)) * n2;
			}
			if (f == 0) {
				answer = n1 + n2;
				if (n2 < 0) {
					question.text = "" + n1 + "+(" + n2 + ")";
				} else {
					question.text = "" + n1 + "+" + n2;
				}
			} else if (f == 1) {
				answer = n1 - n2;
				if (n2 < 0) {
					question.text = "" + n1 + "-(" + n2 + ")";
				} else {
					question.text = "" + n1 + "-" + n2;
				}
			} else if (f == 2) {
				answer = n1 * n2;
				if (n2 < 0) {
					question.text = "" + n1 + "*(" + n2 + ")";
				} else {
					question.text = "" + n1 + "*" + n2;
				}
			} else {
				answer = n1 / n2;
				if (n2 < 0) {
					question.text = "" + n1 + "/(" + n2 + ")";
				} else {
					question.text = "" + n1 + "/" + n2;
				}
			}
		} else if (levelMode.text == "Addition-Hard") {
			level = Random.Range (1, 5);
			if (level == 1) {
				n1 = Random.Range (0, 10);
				n2 = Random.Range (0, 10);
			} else if (level == 2) {
				n1 = Random.Range (0, 100);
				n2 = Random.Range (0, 100);
			} else if (level == 3) {
				n1 = Random.Range (0, 1000);
				n2 = Random.Range (0, 1000);
			} else if (level == 4) {
				n1 = Random.Range (0, 10000);
				n2 = Random.Range (0, 10000);
			}
			answer = n1 + n2;
			if (n2 < 0) {
				question.text = "" + n1 + "+(" + n2 + ")";
			} else {
				question.text = "" + n1 + "+" + n2;
			}
		} else if (levelMode.text == "Addition-Medium") {
			level = Random.Range (1, 3);
			if (level == 1) {
				n1 = Random.Range (0, 10);
				n2 = Random.Range (0, 10);
			} else if (level == 2) {
				n1 = Random.Range (0, 100);
				n2 = Random.Range (0, 100);
			}
			answer = n1 + n2;
			if (n2 < 0) {
				question.text = "" + n1 + "+(" + n2 + ")";
			} else {
				question.text = "" + n1 + "+" + n2;
			}
		} else if (levelMode.text == "Addition-Easy") {
			n1 = Random.Range (0, 10);
			n2 = Random.Range (0, 10);
			answer = n1 + n2;
			if (n2 < 0) {
				question.text = "" + n1 + "+(" + n2 + ")";
			} else {
				question.text = "" + n1 + "+" + n2;
			}
		} else if (levelMode.text == "Subtraction-Hard") {
			level = Random.Range (1, 5);
			if (level == 1) {
				n1 = Random.Range (-10, 10);
				n2 = Random.Range (-10, 10);
			} else if (level == 2) {
				n1 = Random.Range (-100, 100);
				n2 = Random.Range (-100, 100);
			} else if (level == 3) {
				n1 = Random.Range (-1000, 1000);
				n2 = Random.Range (-1000, 1000);
			} else if (level == 4) {
				n1 = Random.Range (-10000, 10000);
				n2 = Random.Range (-10000, 10000);
			}
			answer = n1 - n2;
			if (n2 < 0) {
				question.text = "" + n1 + "-(" + n2 + ")";
			} else {
				question.text = "" + n1 + "-" + n2;
			}
		} else if (levelMode.text == "Subtraction-Medium") {
			level = Random.Range (1, 3);
			if (level == 1) {
				n1 = Random.Range (-10, 10);
				n2 = Random.Range (-10, 10);
			} else if (level == 2) {
				n1 = Random.Range (-100, 100);
				n2 = Random.Range (-100, 100);
			}
			answer = n1 - n2;
			if (n2 < 0) {
				question.text = "" + n1 + "-(" + n2 + ")";
			} else {
				question.text = "" + n1 + "-" + n2;
			}
		} else if (levelMode.text == "Subtraction-Easy") {
			level = Random.Range (1, 3);
			if (level == 1) {
				n2 = Random.Range (0, 10);
				n1 = Random.Range (0, 10) + n2;
			} else if (level == 2) {
				n2 = Random.Range (0, 100);
				n1 = Random.Range (0, 100) + n2;
			}
			answer = n1 - n2;
			if (n2 < 0) {
				question.text = "" + n1 + "-(" + n2 + ")";
			} else {
				question.text = "" + n1 + "-" + n2;
			}
		} else if (levelMode.text == "Multiplication-Hard") {
			level = Random.Range (1, 3);
			if (level == 1) {
				n1 = Random.Range (-10, 10);
				n2 = Random.Range (-10, 10);
			} else if (level == 2) {
				n1 = Random.Range (-100, 100);
				n2 = Random.Range (-100, 100);
			}
			answer = n1 * n2;
			if (n2 < 0) {
				question.text = "" + n1 + "*(" + n2 + ")";
			} else {
				question.text = "" + n1 + "*" + n2;
			}
		} else if (levelMode.text == "Multiplication-Medium") {
			n1 = Random.Range (-10, 10);
			n2 = Random.Range (-10, 10);
			answer = n1 * n2;
			if (n2 < 0) {
				question.text = "" + n1 + "*(" + n2 + ")";
			} else {
				question.text = "" + n1 + "*" + n2;
			}
		} else if (levelMode.text == "Multiplication-Easy") {
			n1 = Random.Range (0, 10);
			n2 = Random.Range (0, 10);
			answer = n1 * n2;
			if (n2 < 0) {
				question.text = "" + n1 + "*(" + n2 + ")";
			} else {
				question.text = "" + n1 + "*" + n2;
			}
		} else if (levelMode.text == "Division-Hard") {
			level = Random.Range (1, 3);
			if (level == 1) {
				int n = Random.Range (0, 2);
				if (n == 0) {
					n2 = Random.Range (-10, -1);
				} else {
					n2 = Random.Range (1, 10);
				}
				n1 = (Random.Range (-10, 10)) * n2;
			} else if (level == 2) {
				int n = Random.Range (0, 2);
				if (n == 0) {
					n2 = Random.Range (-100, -1);
				} else {
					n2 = Random.Range (1, 100);
				}
				n1 = (Random.Range (-100, 100)) * n2;
			}
			answer = n1 / n2;
			if (n2 < 0) {
				question.text = "" + n1 + "/(" + n2 + ")";
			} else {
				question.text = "" + n1 + "/" + n2;
			}
		} else if (levelMode.text == "Division-Medium") {
			int n = Random.Range (0, 2);
			if (n == 0) {
				n2 = Random.Range (-10, -1);
			} else {
				n2 = Random.Range (1, 10);
			}
			n1 = (Random.Range (-10, 10)) * n2;
			answer = n1 / n2;
			if (n2 < 0) {
				question.text = "" + n1 + "/(" + n2 + ")";
			} else {
				question.text = "" + n1 + "/" + n2;
			}
		} else if (levelMode.text == "Division-Easy") {
			n2 = Random.Range (1, 10);
			n1 = (Random.Range (0, 10)) * n2;
			answer = n1 / n2;
			if (n2 < 0) {
				question.text = "" + n1 + "/(" + n2 + ")";
			} else {
				question.text = "" + n1 + "/" + n2;
			}
		} else if (levelMode.text == "Inequality") {
			n1 = Random.Range (-100, 101);
			n2 = Random.Range (-100, 101);
			if (n2 > n1) {
				answer = -1;
			} else if (n1 > n2) {
				answer = 1;
			} else {
				answer = 0;
			}
			if (n2 < 0) {
				question.text = "" + n1 + "[ ](" + n2 + ")";
			} else {
				question.text = "" + n1 + "[ ]" + n2;
			}
		} else if (levelMode.text == "Fibonacci") {
			question.text = "1, 1";
			n1 = 1;
			n2 = 1;
			answer = 2;
		}
		if (levelMode.text == "Inequality") {
			if (answer == -1) {
				ans = "<";
			} else if (answer == 0) {
				ans = "=";
			} else {
				ans = ">";
			}
		} else {
			ans = "" + answer;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (levelMode.text == "Inequality") {
			GetComponent<Rigidbody2D> ().AddForce (3.0f * (target - transform.position) / (target - transform.position).magnitude);
		} else {
			if(PlayerPrefs.GetInt("Time") == 0){
				GetComponent<Rigidbody2D> ().AddForce((target - transform.position) / (target - transform.position).magnitude);
			}
			else{
				GetComponent<Rigidbody2D> ().AddForce ((0.5f + (cannon.GetComponent<CannonController>().getScore() * 0.1f)) * (target - transform.position) / (target - transform.position).magnitude);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Cannonball")) {
			if (number.text == ans) {
				transform.position = initial;
				gameObject.SetActive (false);
			}
		} else if (other.gameObject.CompareTag ("Cannon")) {
			if(levelMode.text == "Mixed-Hard"){
				if(PlayerPrefs.GetInt("MixedHardScore", 0) < cannon.GetComponent<CannonController>().getScore()){
					PlayerPrefs.SetInt("MixedHardScore", cannon.GetComponent<CannonController>().getScore());
				}
			}
			else if(levelMode.text == "Mixed-Medium"){
				if(PlayerPrefs.GetInt("MixedMediumScore", 0) < cannon.GetComponent<CannonController>().getScore()){
					PlayerPrefs.SetInt("MixedMediumScore", cannon.GetComponent<CannonController>().getScore());
				}
			}
			else if(levelMode.text == "Mixed-Easy"){
				if(PlayerPrefs.GetInt("MixedEasyScore", 0) < cannon.GetComponent<CannonController>().getScore()){
					PlayerPrefs.SetInt("MixedEasyScore", cannon.GetComponent<CannonController>().getScore());
				}
			}
			else if(levelMode.text == "Addition-Hard"){
				if(PlayerPrefs.GetInt("AdditionHardScore", 0) < cannon.GetComponent<CannonController>().getScore()){
					PlayerPrefs.SetInt("AdditionHardScore", cannon.GetComponent<CannonController>().getScore());
				}
			}
			else if(levelMode.text == "Addition-Medium"){
				if(PlayerPrefs.GetInt("AdditionMediumScore", 0) < cannon.GetComponent<CannonController>().getScore()){
					PlayerPrefs.SetInt("AdditionMediumScore", cannon.GetComponent<CannonController>().getScore());
				}
			}
			else if(levelMode.text == "Addition-Easy"){
				if(PlayerPrefs.GetInt("AdditionEasyScore", 0) < cannon.GetComponent<CannonController>().getScore()){
					PlayerPrefs.SetInt("AdditionEasyScore", cannon.GetComponent<CannonController>().getScore());
				}
			}
			else if(levelMode.text == "Subtraction-Hard"){
				if(PlayerPrefs.GetInt("SubtractionHardScore", 0) < cannon.GetComponent<CannonController>().getScore()){
					PlayerPrefs.SetInt("SubtractionHardScore", cannon.GetComponent<CannonController>().getScore());
				}
			}
			else if(levelMode.text == "Subtraction-Medium"){
				if(PlayerPrefs.GetInt("SubtractionMediumScore", 0) < cannon.GetComponent<CannonController>().getScore()){
					PlayerPrefs.SetInt("SubtractionMediumScore", cannon.GetComponent<CannonController>().getScore());
				}
			}
			else if(levelMode.text == "Subtraction-Easy"){
				if(PlayerPrefs.GetInt("SubtractionEasyScore", 0) < cannon.GetComponent<CannonController>().getScore()){
					PlayerPrefs.SetInt("SubtractionEasyScore", cannon.GetComponent<CannonController>().getScore());
				}
			}
			else if(levelMode.text == "Multiplication-Hard"){
				if(PlayerPrefs.GetInt("MultiplicationHardScore", 0) < cannon.GetComponent<CannonController>().getScore()){
					PlayerPrefs.SetInt("MultiplicationHardScore", cannon.GetComponent<CannonController>().getScore());
				}
			}
			else if(levelMode.text == "Multiplication-Medium"){
				if(PlayerPrefs.GetInt("MultiplicationMediumScore", 0) < cannon.GetComponent<CannonController>().getScore()){
					PlayerPrefs.SetInt("MultiplicationMediumScore", cannon.GetComponent<CannonController>().getScore());
				}
			}
			else if(levelMode.text == "Multiplication-Easy"){
				if(PlayerPrefs.GetInt("MultiplicationEasyScore", 0) < cannon.GetComponent<CannonController>().getScore()){
					PlayerPrefs.SetInt("MultiplicationEasyScore", cannon.GetComponent<CannonController>().getScore());
				}
			}
			else if(levelMode.text == "Division-Hard"){
				if(PlayerPrefs.GetInt("DivisionHardScore", 0) < cannon.GetComponent<CannonController>().getScore()){
					PlayerPrefs.SetInt("DivisionHardScore", cannon.GetComponent<CannonController>().getScore());
				}
			}
			else if(levelMode.text == "Division-Medium"){
				if(PlayerPrefs.GetInt("DivisionMediumScore", 0) < cannon.GetComponent<CannonController>().getScore()){
					PlayerPrefs.SetInt("DivisionMediumScore", cannon.GetComponent<CannonController>().getScore());
				}
			}
			else if(levelMode.text == "Division-Easy"){
				if(PlayerPrefs.GetInt("DivisionEasyScore", 0) < cannon.GetComponent<CannonController>().getScore()){
					PlayerPrefs.SetInt("DivisionEasyScore", cannon.GetComponent<CannonController>().getScore());
				}
			}
			else if(levelMode.text == "Inequality"){
				if(PlayerPrefs.GetInt("InequalityScore", 0) < cannon.GetComponent<CannonController>().getScore()){
					PlayerPrefs.SetInt("InequalityScore", cannon.GetComponent<CannonController>().getScore());
				}
			}
			else if(levelMode.text == "Fibonacci"){
				if(PlayerPrefs.GetInt("FibonacciScore", 0) < cannon.GetComponent<CannonController>().getScore()){
					PlayerPrefs.SetInt("FibonacciScore", cannon.GetComponent<CannonController>().getScore());
				}
			}
			PlayerPrefs.Save();
			Lose.text = "You Lose!";
			panel.SetActive(true);
			other.gameObject.SetActive (false);
			gameObject.SetActive (false);
		}
	}

	public void reset(){
		Lose.text = "";
		initial = transform.position;
		if (levelMode.text == "Mixed-Hard") {
			f = Random.Range (0, 4);
			//0 = addition, 1 = subtraction, 2 = multiplication, 3 = division;
			if (f < 2) {
				level = Random.Range (1, 5);
				if (level == 1) {
					n1 = Random.Range (-10, 10);
					n2 = Random.Range (-10, 10);
				} else if (level == 2) {
					n1 = Random.Range (-100, 100);
					n2 = Random.Range (-100, 100);
				} else if (level == 3) {
					n1 = Random.Range (-1000, 1000);
					n2 = Random.Range (-1000, 1000);
				} else if (level == 4) {
					n1 = Random.Range (-10000, 10000);
					n2 = Random.Range (-10000, 10000);
				}
			} else if (f == 2) {
				level = Random.Range (1, 3);
				if (level == 1) {
					n1 = Random.Range (-10, 10);
					n2 = Random.Range (-10, 10);
				} else if (level == 2) {
					n1 = Random.Range (-100, 100);
					n2 = Random.Range (-100, 100);
				}
			} else {
				level = Random.Range (1, 3);
				if (level == 1) {
					int n = Random.Range (0, 2);
					if (n == 0) {
						n2 = Random.Range (-10, -1);
					} else {
						n2 = Random.Range (1, 10);
					}
					n1 = (Random.Range (-10, 10)) * n2;
				} else if (level == 2) {
					int n = Random.Range (0, 2);
					if (n == 0) {
						n2 = Random.Range (-100, -1);
					} else {
						n2 = Random.Range (1, 100);
					}
					n1 = (Random.Range (-100, 100)) * n2;
				}
			}
			if (f == 0) {
				answer = n1 + n2;
				if (n2 < 0) {
					question.text = "" + n1 + "+(" + n2 + ")";
				} else {
					question.text = "" + n1 + "+" + n2;
				}
			} else if (f == 1) {
				answer = n1 - n2;
				if (n2 < 0) {
					question.text = "" + n1 + "-(" + n2 + ")";
				} else {
					question.text = "" + n1 + "-" + n2;
				}
			} else if (f == 2) {
				answer = n1 * n2;
				if (n2 < 0) {
					question.text = "" + n1 + "*(" + n2 + ")";
				} else {
					question.text = "" + n1 + "*" + n2;
				}
			} else {
				answer = n1 / n2;
				if (n2 < 0) {
					question.text = "" + n1 + "/(" + n2 + ")";
				} else {
					question.text = "" + n1 + "/" + n2;
				}
			}
		} else if (levelMode.text == "Mixed-Medium") {
			f = Random.Range (0, 4);
			//0 = addition, 1 = subtraction, 2 = multiplication, 3 = division;
			if (f < 2) {
				level = Random.Range (1, 3);
				if (level == 1) {
					n1 = Random.Range (-10, 10);
					n2 = Random.Range (-10, 10);
				} else if (level == 2) {
					n1 = Random.Range (-100, 100);
					n2 = Random.Range (-100, 100);
				}
			} else if (f == 2) {
				n1 = Random.Range (-10, 10);
				n2 = Random.Range (-10, 10);
			} else {
				int n = Random.Range (0, 2);
				if (n == 0) {
					n2 = Random.Range (-10, -1);
				} else {
					n2 = Random.Range (1, 10);
				}
				n1 = (Random.Range (-10, 10)) * n2;
			}
			if (f == 0) {
				answer = n1 + n2;
				if (n2 < 0) {
					question.text = "" + n1 + "+(" + n2 + ")";
				} else {
					question.text = "" + n1 + "+" + n2;
				}
			} else if (f == 1) {
				answer = n1 - n2;
				if (n2 < 0) {
					question.text = "" + n1 + "-(" + n2 + ")";
				} else {
					question.text = "" + n1 + "-" + n2;
				}
			} else if (f == 2) {
				answer = n1 * n2;
				if (n2 < 0) {
					question.text = "" + n1 + "*(" + n2 + ")";
				} else {
					question.text = "" + n1 + "*" + n2;
				}
			} else {
				answer = n1 / n2;
				if (n2 < 0) {
					question.text = "" + n1 + "/(" + n2 + ")";
				} else {
					question.text = "" + n1 + "/" + n2;
				}
			}
		} else if (levelMode.text == "Mixed-Easy") {
			f = Random.Range (0, 4);
			//0 = addition, 1 = subtraction, 2 = multiplication, 3 = division;
			if (f == 0) {
				n1 = Random.Range (0, 10);
				n2 = Random.Range (0, 10);
			} else if (f == 1) {
				n2 = Random.Range (0, 10);
				n1 = Random.Range (0, 10) + n2;
			} else if (f == 2) {
				n1 = Random.Range (0, 10);
				n2 = Random.Range (0, 10);
			} else {
				n2 = Random.Range (1, 10);
				n1 = (Random.Range (0, 10)) * n2;
			}
			if (f == 0) {
				answer = n1 + n2;
				if (n2 < 0) {
					question.text = "" + n1 + "+(" + n2 + ")";
				} else {
					question.text = "" + n1 + "+" + n2;
				}
			} else if (f == 1) {
				answer = n1 - n2;
				if (n2 < 0) {
					question.text = "" + n1 + "-(" + n2 + ")";
				} else {
					question.text = "" + n1 + "-" + n2;
				}
			} else if (f == 2) {
				answer = n1 * n2;
				if (n2 < 0) {
					question.text = "" + n1 + "*(" + n2 + ")";
				} else {
					question.text = "" + n1 + "*" + n2;
				}
			} else {
				answer = n1 / n2;
				if (n2 < 0) {
					question.text = "" + n1 + "/(" + n2 + ")";
				} else {
					question.text = "" + n1 + "/" + n2;
				}
			}
		} else if (levelMode.text == "Addition-Hard") {
			level = Random.Range (1, 5);
			if (level == 1) {
				n1 = Random.Range (0, 10);
				n2 = Random.Range (0, 10);
			} else if (level == 2) {
				n1 = Random.Range (0, 100);
				n2 = Random.Range (0, 100);
			} else if (level == 3) {
				n1 = Random.Range (0, 1000);
				n2 = Random.Range (0, 1000);
			} else if (level == 4) {
				n1 = Random.Range (0, 10000);
				n2 = Random.Range (0, 10000);
			}
			answer = n1 + n2;
			if (n2 < 0) {
				question.text = "" + n1 + "+(" + n2 + ")";
			} else {
				question.text = "" + n1 + "+" + n2;
			}
		} else if (levelMode.text == "Addition-Medium") {
			level = Random.Range (1, 3);
			if (level == 1) {
				n1 = Random.Range (0, 10);
				n2 = Random.Range (0, 10);
			} else if (level == 2) {
				n1 = Random.Range (0, 100);
				n2 = Random.Range (0, 100);
			}
			answer = n1 + n2;
			if (n2 < 0) {
				question.text = "" + n1 + "+(" + n2 + ")";
			} else {
				question.text = "" + n1 + "+" + n2;
			}
		} else if (levelMode.text == "Addition-Easy") {
			n1 = Random.Range (0, 10);
			n2 = Random.Range (0, 10);
			answer = n1 + n2;
			if (n2 < 0) {
				question.text = "" + n1 + "+(" + n2 + ")";
			} else {
				question.text = "" + n1 + "+" + n2;
			}
		} else if (levelMode.text == "Subtraction-Hard") {
			level = Random.Range (1, 5);
			if (level == 1) {
				n1 = Random.Range (-10, 10);
				n2 = Random.Range (-10, 10);
			} else if (level == 2) {
				n1 = Random.Range (-100, 100);
				n2 = Random.Range (-100, 100);
			} else if (level == 3) {
				n1 = Random.Range (-1000, 1000);
				n2 = Random.Range (-1000, 1000);
			} else if (level == 4) {
				n1 = Random.Range (-10000, 10000);
				n2 = Random.Range (-10000, 10000);
			}
			answer = n1 - n2;
			if (n2 < 0) {
				question.text = "" + n1 + "-(" + n2 + ")";
			} else {
				question.text = "" + n1 + "-" + n2;
			}
		} else if (levelMode.text == "Subtraction-Medium") {
			level = Random.Range (1, 3);
			if (level == 1) {
				n1 = Random.Range (-10, 10);
				n2 = Random.Range (-10, 10);
			} else if (level == 2) {
				n1 = Random.Range (-100, 100);
				n2 = Random.Range (-100, 100);
			}
			answer = n1 - n2;
			if (n2 < 0) {
				question.text = "" + n1 + "-(" + n2 + ")";
			} else {
				question.text = "" + n1 + "-" + n2;
			}
		} else if (levelMode.text == "Subtraction-Easy") {
			n2 = Random.Range (0, 10);
			n1 = Random.Range (0, 10) + n2;
			answer = n1 - n2;
			if (n2 < 0) {
				question.text = "" + n1 + "-(" + n2 + ")";
			} else {
				question.text = "" + n1 + "-" + n2;
			}
		} else if (levelMode.text == "Multiplication-Hard") {
			level = Random.Range (1, 3);
			if (level == 1) {
				n1 = Random.Range (-10, 10);
				n2 = Random.Range (-10, 10);
			} else if (level == 2) {
				n1 = Random.Range (-100, 100);
				n2 = Random.Range (-100, 100);
			}
			answer = n1 * n2;
			if (n2 < 0) {
				question.text = "" + n1 + "*(" + n2 + ")";
			} else {
				question.text = "" + n1 + "*" + n2;
			}
		} else if (levelMode.text == "Multiplication-Medium") {
			n1 = Random.Range (-10, 10);
			n2 = Random.Range (-10, 10);
			answer = n1 * n2;
			if (n2 < 0) {
				question.text = "" + n1 + "*(" + n2 + ")";
			} else {
				question.text = "" + n1 + "*" + n2;
			}
		} else if (levelMode.text == "Multiplication-Easy") {
			n1 = Random.Range (0, 10);
			n2 = Random.Range (0, 10);
			answer = n1 * n2;
			if (n2 < 0) {
				question.text = "" + n1 + "*(" + n2 + ")";
			} else {
				question.text = "" + n1 + "*" + n2;
			}
		} else if (levelMode.text == "Division-Hard") {
			level = Random.Range (1, 3);
			if (level == 1) {
				int n = Random.Range (0, 2);
				if (n == 0) {
					n2 = Random.Range (-10, -1);
				} else {
					n2 = Random.Range (1, 10);
				}
				n1 = (Random.Range (-10, 10)) * n2;
			} else if (level == 2) {
				int n = Random.Range (0, 2);
				if (n == 0) {
					n2 = Random.Range (-100, -1);
				} else {
					n2 = Random.Range (1, 100);
				}
				n1 = (Random.Range (-100, 100)) * n2;
			}
			answer = n1 / n2;
			if (n2 < 0) {
				question.text = "" + n1 + "/(" + n2 + ")";
			} else {
				question.text = "" + n1 + "/" + n2;
			}
		} else if (levelMode.text == "Division-Medium") {
			int n = Random.Range (0, 2);
			if (n == 0) {
				n2 = Random.Range (-10, -1);
			} else {
				n2 = Random.Range (1, 10);
			}
			n1 = (Random.Range (-10, 10)) * n2;
			answer = n1 / n2;
			if (n2 < 0) {
				question.text = "" + n1 + "/(" + n2 + ")";
			} else {
				question.text = "" + n1 + "/" + n2;
			}
		} else if (levelMode.text == "Division-Easy") {
			n2 = Random.Range (1, 10);
			n1 = (Random.Range (0, 10)) * n2;
			answer = n1 / n2;
			if (n2 < 0) {
				question.text = "" + n1 + "/(" + n2 + ")";
			} else {
				question.text = "" + n1 + "/" + n2;
			}
		} else if (levelMode.text == "Inequality") {
			n1 = Random.Range (-100, 101);
			n2 = Random.Range (-100, 101);
			if(n2>n1){
				answer = -1;
			} else if(n1>n2){
				answer = 1;
			} else{
				answer = 0;
			}
			if (n2 < 0) {
				question.text = "" + n1 + "[ ](" + n2 + ")";
			} else {
				question.text = "" + n1 + "[ ]" + n2;
			}
		} else if (levelMode.text == "Fibonacci") {
			n1 = n2;
			n2 = answer;
			answer = n1 + n2;
			question.text = "" + n1 + ", " + n2;
		}
		if (levelMode.text == "Inequality") {
			if (answer == -1) {
				ans = "<";
			} else if (answer == 0) {
				ans = "=";
			} else {
				ans = ">";
			}
		} else {
			ans = "" + answer;
		}
	}

}
