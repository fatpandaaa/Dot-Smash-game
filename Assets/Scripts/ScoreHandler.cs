using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreHandler : MonoBehaviour
{

		public int currentScore;
		public int highScore;
		Text text;

		void Awake ()
		{

				text = GetComponent <Text> ();
				resetScore ();
		}

		public void resetScore ()
		{
				currentScore = 0;
		}
		void Update ()
		{
				text.text = "" + currentScore;
	    
		}

		public void AddScore (int addingscore)
		{
				currentScore = currentScore + addingscore;
		}
}
