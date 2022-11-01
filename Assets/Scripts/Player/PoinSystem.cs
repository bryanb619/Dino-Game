using UnityEngine;
using UnityEngine.UI;

public class PoinSystem : MonoBehaviour
{
    
    private static PoinSystem instance;

    [HideInInspector]
    public static PoinSystem Instance => instance;


    [SerializeField] private Text _scoreText;//, _highScoreText;

    private int _score, NewScore = 10;


    [SerializeField] private GameObject DinoHat1, DinoHat2, DinoHat3, DinoHat4, DinoHat5, DinoHat6, DinoHat7, DinoHat8, DinoHat9, DinoHat10;

    [SerializeField] private PauseMenu pause;



    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        _score = 0;
        
        DinoHat1.SetActive(false);
        DinoHat2.SetActive(false);
        DinoHat3.SetActive(false);
        DinoHat4.SetActive(false);
        DinoHat5.SetActive(false);
        DinoHat6.SetActive(false);
        DinoHat7.SetActive(false);
        DinoHat8.SetActive(false);
        DinoHat9.SetActive(false);
        DinoHat10.SetActive(false); 

        

        //_scoreText.text = "POINTS: " + _score.ToString() ;
        //_highScoreText.text = "HIGHSCORE: " + _highScore.ToString();
    }

    
    public void AddPoint()
    {
        int point = 1;
        int MaxScore = 20;

        _score += point;
        //_highScore = _score;
        if(_score == MaxScore)
        {
            pause.DestroyMenu();

            DinoHat10.SetActive(true);
            //Time.timeScale = 0f;

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;

            _score = NewScore;
            //_highScore = NewScore;
            _scoreText.text = "YOUR SCORE IS: " + _score.ToString();
            //_highScoreText.text = "HIGHSCORE: " + _highScore.ToString();
        }
        Debug.Log("Score is: " + _score);
        

        if(_score == 2)
        {
            DinoHat1.SetActive(true);
        }
        else if (_score == 4)
        {
            DinoHat2.SetActive(true);
        }
        else if (_score == 6)
        {
            DinoHat3.SetActive(true);
        }
        else if (_score == 8)
        {
            DinoHat4.SetActive(true);
        }
        else if (_score == 10)
        {
            DinoHat5.SetActive(true);
        }
        else if (_score == 12)
        {
            DinoHat6.SetActive(true);
        }
        else if (_score == 14)
        {
            DinoHat7.SetActive(true);
        }
        else if (_score == 16)
        {
            DinoHat8.SetActive(true);
        }
        else if (_score == 18)
        {
            DinoHat9.SetActive(true);
        }
       
    }

}
