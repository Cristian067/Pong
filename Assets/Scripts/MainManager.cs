using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{

    public static MainManager Instance { get; private set; }

    private string player1Name;
    private string player2Name;

    private (int, int, int) player1Acs;
    private (int, int, int) player2Acs;

    [SerializeField] private Selection[] selections;


    [SerializeField] private GameObject[] panels;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogError("Hay mas de un main manager");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoTo(GameObject go)
    {
        foreach (GameObject panel in panels)
        {
            panel.SetActive(false);
        }
        go.SetActive(true);
    }
    public void SetPlayer1Acs(TMP_InputField name)
    {
        player1Name = name.text;
        player1Acs = (selections[0].selection, selections[1].selection, selections[2].selection);
        SaveOptions();
        Debug.Log("Player1:"+player1Acs);
    }

    public void SetPlayer2Acs(TMP_InputField name)
    {
        player2Name = name.text;
        player2Acs = (selections[3].selection, selections[4].selection, selections[5].selection);
        SaveOptions();
        Debug.Log("Player2:"+player1Acs);
    }




    public (int,int,int) GetPlayer1Acs()
    {
        return player1Acs;
    }

    public (int,int,int) GetPlayer2Acs()
    {
        return player2Acs;
    }


    public void SaveOptions()
    {
        PlayerPrefs.SetString("Player1_name", player1Name);
        PlayerPrefs.SetInt("Player1_acs1", player1Acs.Item1);
        PlayerPrefs.SetInt("Player1_acs2", player1Acs.Item2);
        PlayerPrefs.SetInt("Player1_color", player1Acs.Item3);

        PlayerPrefs.SetString("Player2_name", player2Name);
        PlayerPrefs.SetInt("Player2_acs1", player2Acs.Item1);
        PlayerPrefs.SetInt("Player2_acs2", player2Acs.Item2);
        PlayerPrefs.SetInt("Player2_color", player2Acs.Item3);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

}
