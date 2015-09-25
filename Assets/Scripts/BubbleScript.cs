using UnityEngine;
using System.Collections;

public class BubbleScript : MonoBehaviour
{

		// Use this for initialization

		public Sprite spriteRed;
		public Sprite spriteBlue;
		public Sprite spriteGreen;
		public Sprite spriteYellow;
		public Sprite spriteDiamond;
		public Sprite spriteBlack;
		public Sprite spriteSkull;

		private Vector2 targetScale;
		private SpriteRenderer spriteRenderer;
		private int ArrayNumber;

		//private ScoreHandler scoreHandler;
		private BallManager ballmanager;
	
		void Start ()
		{
				spriteRenderer = GetComponent<SpriteRenderer> ();
				//scoreHandler = GameObject.Find("ScoreHandler").GetComponent<ScoreHandler>();
				ballmanager = GameObject.Find ("BallManager").GetComponent<BallManager> ();


				ArrayNumber = 4;
				RandomSpriteGeneration ();
				targetScale = new Vector2 (0.4f, 0.4f);
				Invoke ("DestroyBubbule", 2.5f);
		}
	
		// Update is called once per frame
		void Update ()
		{
				transform.localScale = Vector2.Lerp (transform.localScale, ballmanager.GetBubbleScale (0), 20f * Time.deltaTime);
		}

		void RandomSpriteGeneration ()
		{
				int rnd = Random.Range (0, 4);

				if (rnd == 0)
						spriteRenderer.sprite = spriteRed;
				else if (rnd == 1)
						spriteRenderer.sprite = spriteGreen;
				else if (rnd == 2)
						spriteRenderer.sprite = spriteBlue;
				else if (rnd == 3)
						spriteRenderer.sprite = spriteYellow;
		}

		void DestroyBubbule ()
		{
				Destroy (this.gameObject);
		}
}
