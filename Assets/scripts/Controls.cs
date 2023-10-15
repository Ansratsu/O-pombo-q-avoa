using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Add me!!
public class Controls : MonoBehaviour
{
	public void OnBackStartButton()
	{
		SceneManager.LoadScene("Title");
	}

}