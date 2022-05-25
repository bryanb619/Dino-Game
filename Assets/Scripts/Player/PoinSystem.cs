using UnityEngine;
using UnityEngine.UI;

public class PoinSystem : MonoBehaviour
{
    
    private static PoinSystem instance;

    [HideInInspector]
    public static PoinSystem Instance => instance;


    [SerializeField]
    private Text _scoreText, _highScoreText;

    private int _score, _highScore;


    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        _score = 0;

        _scoreText.text = "POINTS: " + _score.ToString() ;
        _highScoreText.text = "HIGHSCORE: " + _highScore.ToString();

    }

    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.P))
        {
            instance.AddPoint();
        }
    }

    public void AddPoint()
    {
        _score += 1;

        _highScore = _score;
        
        _scoreText.text = "POINTS: " + _score.ToString() ;
        _highScoreText.text = "HIGHSCORE: " + _highScore.ToString();

        Debug.Log("Score is: " + _score);
    }

}
