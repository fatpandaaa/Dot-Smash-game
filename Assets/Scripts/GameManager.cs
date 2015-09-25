using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{

		public GameObject Bubble;

		private GameObject[] locations;
		private bool[] bubbleExists;
		private int totalBubbles;
		private int bubbleCount;
		private ScoreHandler scoreHandler;


		void Start ()
		{
				locations = GameObject.FindGameObjectsWithTag ("Locations");
				
				
				bubbleExists = new bool[locations.Length];
				ResetBubbleExistance ();
				totalBubbles = locations.Length;
				bubbleCount = 0;
				InvokeRepeating ("RandomBubbleGenerator", 0.5f, 1f);
		}
	
		void Update ()
		{
				InputHandler ();
				Debug.Log (bubbleCount + " " + totalBubbles);
		}

		void RandomBubbleGenerator ()
		{
				int pos = RandomNumberGenerator ();

				if (bubbleCount < totalBubbles) {
						if (!bubbleExists [pos]) {
								Instantiate (Bubble, locations [pos].transform.position, locations [pos].transform.rotation);
								bubbleExists [pos] = true;
								bubbleCount++;
						} else {
								while (bubbleExists[pos]) {
										pos = RandomNumberGenerator ();
								}
								bubbleExists [pos] = true;
								Instantiate (Bubble, locations [pos].transform.position, locations [pos].transform.rotation);
								bubbleCount++;
						}
            
				}
				//Debug.Log(pos);
		}

		int RandomNumberGenerator ()
		{
				int rnd = Random.Range (0, locations.Length);
				return rnd;
		}

		void ResetBubbleExistance ()
		{
				for (int i = 0; i < locations.Length; i++)
						bubbleExists [i] = false;
		}

		void InputHandler ()
		{
				if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) {
						Vector3 touchWorldPoint = Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position);

						touchWorldPoint.z = 0f;

						RaycastHit2D hit = Physics2D.Raycast (touchWorldPoint, -Vector2.up);

						for (int i = 0; i < locations.Length; i++) {
								if (hit.transform.position == locations [i].transform.position) {
										Destroy (hit.transform.gameObject);
										bubbleExists [i] = false;
										bubbleCount--;

										break;
								}
						}
				}
		}
}
