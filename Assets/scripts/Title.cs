using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Add me!!
public class Title : MonoBehaviour
{
	public void OnStartButton()
	{
		SceneManager.LoadScene("Cinematic_Beginning");
	}

	public void OnControlsButton()
	{
		SceneManager.LoadScene("Controls");
	}

	public void OnCreditsButton()
	{
		SceneManager.LoadScene("Credits");
	}

	public void OnQuitButton()
	{
		Application.Quit();
	}
}