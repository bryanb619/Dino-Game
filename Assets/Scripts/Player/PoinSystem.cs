using UnityEngine;
using UnityEngine.UI;

public class PoinSystem : MonoBehaviour
{
    
    private static PoinSystem instance;

    [HideInInspector]
    public static PoinSystem Instance => instance;


     [SerializeField]
    private Text _scoreText, _highScoreText;

    private int _score;
    private int _highScore;


    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        _score = 0;

        _scoreText.text = _scoreText.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.P))
        {
            AddPoint();
        }
    }

    public void AddPoint()
    {
        _score += 1;
        _scoreText.text = _score.ToString();
    }

}
