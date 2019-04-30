using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CannonController : MonoBehaviour {

	public GameObject spaceship;
	public GameObject spaceship1;
	public GameObject spaceship2;
	public GameObject cannonball;
	public float speed;
	public AudioClip cannon;
	public AudioClip explosion;
	public Text score;
	public Text highScore;
	public Text levelMode;

	private Rigidbody2D rb;
	private Vector3 position;
	private Vector3 target;
	private Vector3 direction;
	private Vector3 temp;
	private bool shot;
	private AudioSource source;
	private int nScore;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
		rb = GetComponent<Rigidbody2D> ();
		position = transform.position;
		shot = false;
		nScore = 0;
		score.text = "Score: 0";
	}
	
	// Update is called once per frame
	void Update () {
		if (spaceship.activeSelf == false && spaceship1.activeSelf == false && spaceship2.activeSelf == false && cannonball.activeSelf == false) {
			nScore = nScore + 1;
			score.text = "Score: " + nScore;
			source.PlayOneShot (explosion, 1);
			if(levelMode.text == "Mixed-Hard"){
				if(PlayerPrefs.GetInt("MixedHardScore", 0) < nScore){
					PlayerPrefs.SetInt("MixedHardScore", nScore);
				}
			}
			else if(levelMode.text == "Mixed-Medium"){
				if(PlayerPrefs.GetInt("MixedMediumScore", 0) < nScore){
					PlayerPrefs.SetInt("MixedMediumScore", nScore);
				}
			}
			else if(levelMode.text == "Mixed-Easy"){
				if(PlayerPrefs.GetInt("MixedEasyScore", 0) < nScore){
					PlayerPrefs.SetInt("MixedEasyScore", nScore);
				}
			}
			else if(levelMode.text == "Addition-Hard"){
				if(PlayerPrefs.GetInt("AdditionHardScore", 0) < nScore){
					PlayerPrefs.SetInt("AdditionHardScore", nScore);
				}
			}
			else if(levelMode.text == "Addition-Medium"){
				if(PlayerPrefs.GetInt("AdditionMediumScore", 0) < nScore){
					PlayerPrefs.SetInt("AdditionMediumScore", nScore);
				}
			}
			else if(levelMode.text == "Addition-Easy"){
				if(PlayerPrefs.GetInt("AdditionEasyScore", 0) < nScore){
					PlayerPrefs.SetInt("AdditionEasyScore", nScore);
				}
			}
			else if(levelMode.text == "Subtraction-Hard"){
				if(PlayerPrefs.GetInt("SubtractionHardScore", 0) < nScore){
					PlayerPrefs.SetInt("SubtractionHardScore", nScore);
				}
			}
			else if(levelMode.text == "Subtraction-Medium"){
				if(PlayerPrefs.GetInt("SubtractionMediumScore", 0) < nScore){
					PlayerPrefs.SetInt("SubtractionMediumScore", nScore);
				}
			}
			else if(levelMode.text == "Subtraction-Easy"){
				if(PlayerPrefs.GetInt("SubtractionEasyScore", 0) < nScore){
					PlayerPrefs.SetInt("SubtractionEasyScore", nScore);
				}
			}
			else if(levelMode.text == "Multiplication-Hard"){
				if(PlayerPrefs.GetInt("MultiplicationHardScore", 0) < nScore){
					PlayerPrefs.SetInt("MultiplicationHardScore", nScore);
				}
			}
			else if(levelMode.text == "Multiplication-Medium"){
				if(PlayerPrefs.GetInt("MultiplicationMediumScore", 0) < nScore){
					PlayerPrefs.SetInt("MultiplicationMediumScore", nScore);
				}
			}
			else if(levelMode.text == "Multiplication-Easy"){
				if(PlayerPrefs.GetInt("MultiplicationEasyScore", 0) < nScore){
					PlayerPrefs.SetInt("MultiplicationEasyScore", nScore);
				}
			}
			else if(levelMode.text == "Division-Hard"){
				if(PlayerPrefs.GetInt("DivisionHardScore", 0) < nScore){
					PlayerPrefs.SetInt("DivisionHardScore", nScore);
				}
			}
			else if(levelMode.text == "Division-Medium"){
				if(PlayerPrefs.GetInt("DivisionMediumScore", 0) < nScore){
					PlayerPrefs.SetInt("DivisionMediumScore", nScore);
				}
			}
			else if(levelMode.text == "Division-Easy"){
				if(PlayerPrefs.GetInt("DivisionEasyScore", 0) < nScore){
					PlayerPrefs.SetInt("DivisionEasyScore", nScore);
				}
			}
			else if(levelMode.text == "Inequality"){
				if(PlayerPrefs.GetInt("InequalityScore", 0) < nScore){
					PlayerPrefs.SetInt("InequalityScore", nScore);
				}
			}
			else if(levelMode.text == "Fibonacci"){
				if(PlayerPrefs.GetInt("FibonacciScore", 0) < nScore){
					PlayerPrefs.SetInt("FibonacciScore", nScore);
				}
			}
			PlayerPrefs.Save();
		}
		temp = transform.eulerAngles;
		position = transform.position;
		target = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		target.z = transform.position.z;
		direction = target - position;
		direction = direction / direction.magnitude;
		if (direction.x == 0) {
			if (direction.y > 0) {
				transform.eulerAngles = new Vector3 (0, 0, 0);
			} else if (direction.y < 0) {
				transform.eulerAngles = new Vector3 (0, 0, 180);
			} else if (direction.y == 0) {
				transform.eulerAngles = temp;
			}
		} else {
			if (direction.x > 0) {
				transform.eulerAngles = new Vector3 (0, 0, (180 * Mathf.Atan (direction.y / direction.x) / Mathf.PI) - 90);
			} else if (direction.x < 0) {
				transform.eulerAngles = new Vector3 (0, 0, (180 * Mathf.Atan (direction.y / direction.x) / Mathf.PI) + 90);
			}
		}
		if (Input.GetMouseButtonDown (0) && shot == false && target.y > -11.0f) {
			source.PlayOneShot (cannon, 1);
			cannonball.SetActive(true);
			if (direction.x == 0) {
				if (direction.y > 0) {
					transform.eulerAngles = new Vector3 (0, 0, 0);
				} else if (direction.y < 0) {
					transform.eulerAngles = new Vector3 (0, 0, 180);
				} else if (direction.y == 0) {
					transform.eulerAngles = temp;
				}
			} else {
				if (direction.x > 0) {
					transform.eulerAngles = new Vector3 (0, 0, (180 * Mathf.Atan (direction.y / direction.x) / Mathf.PI) - 90);
				} else if (direction.x < 0) {
					transform.eulerAngles = new Vector3 (0, 0, (180 * Mathf.Atan (direction.y / direction.x) / Mathf.PI) + 90);
				}
			}
			cannonball.GetComponent<Rigidbody2D>().velocity = speed * direction;
			shot = true;
		}
		if (cannonball.activeSelf == false) {
			shot = false;
		}
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
	}

	public int getScore(){
		return nScore;
	}
	
}
