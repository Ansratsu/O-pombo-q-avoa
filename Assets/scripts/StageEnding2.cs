using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageEnding2 : MonoBehaviour
{
    public void OnNextButton()
	{
		SceneManager.LoadScene("Cinematic_Ending");
	}
}
