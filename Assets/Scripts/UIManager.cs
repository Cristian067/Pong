using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [SerializeField] private GameObject winPanel;

    [SerializeField] private TextMeshProUGUI winnerText;

    [SerializeField] private TextMeshProUGUI player1Points;
    [SerializeField] private TextMeshProUGUI player2Points;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogError("Hay mas de un UIManager");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        VisualPoints((0,0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndGame(string winner)
    {
        winPanel.SetActive(true);
        winnerText.text = $"{winner} Wins";
        Time.timeScale = 0;

    }

    public void VisualPoints((int, int)points)
    {
        player1Points.text = points.Item1.ToString();
        player2Points.text = points.Item2.ToString();
    }



}
