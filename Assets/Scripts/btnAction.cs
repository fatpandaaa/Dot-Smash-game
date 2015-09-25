using UnityEngine;
using System.Collections;

public class btnAction : MonoBehaviour {

	// Use this for initialization

	public void PlaybtnClicked(string SceneNumber){
		Application.LoadLevel (SceneNumber);
	}

}
