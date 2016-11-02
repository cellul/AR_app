using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class uiManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Triggered when start button is pressed in the menu scene
	public void startButtonPress()
	{
		Application.LoadLevel(1);
		Debug.Log("Opening AR...");
	}

	// Triggered when menu button is pressed in the camera or about scene
	public void menuButtonPress()
	{
		Application.LoadLevel(0);
		Debug.Log("Opening main menu page...");
	}

	// Triggered when about button is pressed in the menu scene
	public void aboutButtonPress()
	{
		Application.LoadLevel(2);
		Debug.Log("Opening about page...");
	}

	// Triggered when exit button is pressed in the menu scene
	public void exitButtonPress()
	{
		Application.Quit();
		Debug.Log("The application is closing...");
	}
}
