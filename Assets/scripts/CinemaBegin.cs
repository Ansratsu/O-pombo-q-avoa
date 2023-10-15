using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Add me!!
public class CinemaBegin : MonoBehaviour
{
	public void OnStageBeginButton()
	{
		SceneManager.LoadScene("Stage_Begin");
	}

}