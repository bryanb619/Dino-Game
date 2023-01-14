using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PoinSystem : MonoBehaviour
{
    
    private static PoinSystem instance;

    [HideInInspector]
    public static PoinSystem Instance => instance;


    [SerializeField] private Text _scoreText;//, _highScoreText;
    [SerializeField] GameObject FirstChoose; 


    private int _score;
        
    private int NewScore = 10;


    [SerializeField] private GameObject DinoHat1, DinoHat2, DinoHat3, DinoHat4, DinoHat5, DinoHat6, DinoHat7, DinoHat8, DinoHat9, DinoHat10;

    

    [SerializeField] private PauseMenu pause;
    private Player player;



    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        _score = 0;

        player= FindObjectOfType<Player>();
        
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

      


        
       
        

        if(_score == 1)
        {
            DinoHat1.SetActive(true);
        }
        else if (_score == 2)
        {
            DinoHat2.SetActive(true);
        }
        else if (_score == 3)
        {
            DinoHat3.SetActive(true);
        }
        else if (_score == 4)
        {
            DinoHat4.SetActive(true);
        }
        else if (_score == 5)
        {
            DinoHat5.SetActive(true);
        }
        else if (_score == 6)
        {
            DinoHat6.SetActive(true);
        }
        else if (_score == 7)
        {
            DinoHat7.SetActive(true);
        }
        else if (_score == 8)
        {
            DinoHat8.SetActive(true);
        }
        else if (_score == 10)
        {
            DinoHat9.SetActive(true);
            
        }
        else if (_score >= MaxScore)
        {
            EventSystem.current.SetSelectedGameObject(null);

            EventSystem.current.SetSelectedGameObject(FirstChoose);

            pause.DestroyMenu();

            player.Obliterate();
            


            DinoHat10.SetActive(true);
            

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;

            _score = NewScore;
            //_highScore = NewScore;
            _scoreText.text = "Nível Completo!";
            Time.timeScale = 0f; 
            //_highScoreText.text = "HIGHSCORE: " + _highScore.ToString();
        }
        //Debug.Log("Score is: " + _score);
        
    }

}
