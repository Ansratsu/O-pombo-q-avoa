using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageEnding : MonoBehaviour
{
    public Text MiddleText;
	
	//middleText = GetComponent<MiddleText>();
	
	// Start is called before the first frame update
    void Start()
    {
        MiddleText.text = "Score: " + PlayerNumbers.playerScore.ToString();
    }
	
}
