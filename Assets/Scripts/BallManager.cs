using UnityEngine;
using System.Collections;

public class BallManager : MonoBehaviour {

    [SerializeField] private Vector2 HighScale =new Vector2 (1.0f,1.0f);
	[SerializeField] private Vector2 MidScale=new Vector2 (1.0f,1.0f);
	[SerializeField] private Vector2 LowScale =new Vector2(1.0f,1.0f);
	[SerializeField] private Vector2 VeryLowScale=new Vector2 (1.0f,1.0f);

    [SerializeField] private float HighStayTime;
    [SerializeField] private float MidStayTime;
    [SerializeField] private float LowStayTime;
    [SerializeField] private float VeryLowStayTime;

    [SerializeField] private int yellowHighScore;
    [SerializeField] private int yellowMidScore;
    [SerializeField] private int yellowLowScore;
    [SerializeField] private int yellowVeryLowScore;

    [SerializeField] private int greenHighScore;
    [SerializeField] private int greenMidScore;
    [SerializeField] private int greenLowScore;
    [SerializeField] private int greenVeryLowScore;

    [SerializeField] private int blueHighScore;
    [SerializeField] private int blueMidScore;
    [SerializeField] private int blueLowScore;
    [SerializeField] private int blueVeryLowScore;

    [SerializeField] private int redHighScore;
    [SerializeField] private int redMidScore;
    [SerializeField] private int redLowScore;
    [SerializeField] private int redVeryLowScore;

    public Vector2 GetBubbleScale(int value)
    {
        if (value == 1)
            return VeryLowScale;
        else if (value == 2)
            return LowScale;
        else if (value == 3)
            return MidScale;
        else if (value == 4)
            return HighScale;
        else
            return new Vector2(-1f, -1f);
    }

    public float GetStayTime(int value)
    {
        if (value == 1)
            return VeryLowStayTime;
        else if (value == 2)
            return LowStayTime;
        else if (value == 3)
            return MidStayTime;
        else if (value == 4)
            return HighStayTime;
        else
            return -1f;
    }
	
	// Update is called once per frame
    public int GetBubbleScore(int type, int value) {
        if (type == 1) {
            if (value == 1)
                return yellowVeryLowScore;
            else if (value == 2)
                return yellowLowScore;
            else if (value == 3)
                return yellowMidScore;
            else if (value == 4)
                return yellowHighScore;
            else
                return -1;
        }
        else if (type == 2) {
            if (value == 1)
                return greenVeryLowScore;
            else if (value == 2)
                return greenLowScore;
            else if (value == 3)
                return greenMidScore;
            else if (value == 4)
                return greenHighScore;
            else
                return -1;
        }
        else if (type == 3) {
            if (value == 1)
                return blueVeryLowScore;
            else if (value == 2)
                return blueLowScore;
            else if (value == 3)
                return blueMidScore;
            else if (value == 4)
                return blueHighScore;
            else
                return -1;
        }
        else if (type == 4)
        {
            if (value == 1)
                return redVeryLowScore;
            else if (value == 2)
                return redLowScore;
            else if (value == 3)
                return redMidScore;
            else if (value == 4)
                return redHighScore;
            else
                return -1;
        }
        else {
            return -1;
        }
    }
}
