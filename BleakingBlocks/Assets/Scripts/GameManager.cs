//using UnityEngine;

//public class GameManager : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    public static GameManager Instance { get; private set; }

//    //スコア表示UI
//    [SerializeField] private TextMeshProUGUI scoreText;

//    //現在のスコア
//    private int score = 0;

//    private void Awake()
//    {
//        Instance = this;
//        UpdateScore();
//    }

//    //スコア加算
//    public void AddScore(int value)
//    {
//        score += value;
//        UpdateScore();
//    }

//    //UI更新
//    private void UpdateScore()
//    {
//        scoreText.text = "Score : " + score;
//    }
//}