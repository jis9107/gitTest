using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    void Awake()
    {
        instance = this;
    }

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
                return null;
            
            return instance;
        }
    }
    
    // 가스 남은 에너지
    [SerializeField] private Text gasText;
    [SerializeField] private int currentGas = 100;
    
    // 인 게임, 게임 오버, 스타트 게임 판단
    private bool gameStart = false;
    [SerializeField] private GameObject gameStartPanel;
    [SerializeField] private GameObject inGamePanel;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject inGame;
    
    private float timer;

    void Start()
    {
        InitGame();
    }

    void Update()
    {
        Timer();
    }

    void Timer()
    {
        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            ChangeGas(-10);
            if (currentGas <= 0)
            {
                GameOver();
            }
            timer = 0f;
        }
    }

    public void ChangeGas(int amount)
    {
        currentGas += amount;
        gasText.text = currentGas.ToString();
    }
    
    public void GameStart()
    {
        gameStartPanel.SetActive(false);
        gameStart = true;
        inGame.SetActive(true);
        inGamePanel.SetActive(true);
    }

    public void GameOver()
    {
        gameStart = false;
        inGame.SetActive(false);
        gameOverPanel.SetActive(true);
        InitGame();
    }

    public void InitGame()
    {
        gameStart = false;
        gameStartPanel.SetActive(true);
        currentGas = 100;
        gasText.text = currentGas.ToString();
    }
}
