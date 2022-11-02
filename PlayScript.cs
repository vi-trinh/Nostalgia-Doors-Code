using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayScript : MonoBehaviour
{
	void Update()
	{
		if (Input.GetKey("escape"))
		{
			Debug.Log("QUIT");

			Application.Quit();
		}
	}
}
