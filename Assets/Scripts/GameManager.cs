using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private Sprite[] acs1;
    [SerializeField] private Sprite[] acs2;
    [SerializeField] private Color[] color;

    private string player1Name;
    [SerializeField] private SpriteRenderer acs1Player1;
    [SerializeField] private SpriteRenderer acs2Player1;
    [SerializeField] private SpriteRenderer colorPlayer1;

    private string player2Name;
    [SerializeField] private SpriteRenderer acs1Player2;
    [SerializeField] private SpriteRenderer acs2Player2;
    [SerializeField] private SpriteRenderer colorPlayer2;

    private (int, int) points;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogError("Hay mas de un gamemanager");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        SetPlayer1();
        SetPlayer2();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetPlayer1()
    {
        player1Name = PlayerPrefs.GetString("Player1_name");
        acs1Player1.sprite = acs1[PlayerPrefs.GetInt("Player1_acs1")];
        acs2Player1.sprite = acs2[PlayerPrefs.GetInt("Player1_acs2")];
        colorPlayer1.color = color[PlayerPrefs.GetInt("Player1_color")];
    }

    private void SetPlayer2()
    {
        player2Name = PlayerPrefs.GetString("Player2_name");
        acs1Player2.sprite = acs1[PlayerPrefs.GetInt("Player2_acs1")];
        acs2Player2.sprite = acs2[PlayerPrefs.GetInt("Player2_acs2")];
        colorPlayer2.color = color[PlayerPrefs.GetInt("Player2_color")];
    }

    public void Score(string goal)
    {
        if (goal == "Player1")
        {
            points.Item2++;
        }
        else if (goal == "Player2")
        {
            points.Item1++;
        }
        if (points.Item1 >= 10 | points.Item2 >= 10)
        {
            if (points.Item1 > points.Item2)
            {
                Debug.Log($"Gana {player1Name}");
            }
            else if (points.Item1 < points.Item2)
            {
                Debug.Log($"Gana {player2Name}");
            }
            Debug.Log("Fin del juego");
        }
    }
    
}
