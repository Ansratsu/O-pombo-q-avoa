using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CinemaEnd : MonoBehaviour
{
    public void OnCreditsButton()
	{
		SceneManager.LoadScene("Credits");
	}
}