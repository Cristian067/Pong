using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Check : MonoBehaviour
{
    [SerializeField] private Texture[] acs1;
    [SerializeField] private Texture[] acs2;
    [SerializeField] private Color[] color;

    [SerializeField] private TextMeshProUGUI player1Name;
    [SerializeField] private RawImage acs1Player1;
    [SerializeField] private RawImage acs2Player1;
    [SerializeField] private RawImage colorPlayer1;

    [SerializeField] private TextMeshProUGUI player2Name;
    [SerializeField] private RawImage acs1Player2;
    [SerializeField] private RawImage acs2Player2;
    [SerializeField] private RawImage colorPlayer2;

    // Start is called before the first frame update
    void Start()
    {
        SetPlaye1Check();
        SetPlaye2Check();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetPlaye1Check()
    {
        player1Name.text = PlayerPrefs.GetString("Player1_name");
        acs1Player1.texture = acs1[PlayerPrefs.GetInt("Player1_acs1")];
        acs2Player1.texture = acs2[PlayerPrefs.GetInt("Player1_acs2")];
        colorPlayer1.color = color[PlayerPrefs.GetInt("Player1_color")];

        Debug.Log(PlayerPrefs.GetInt("Player1_color"));
    }

    private void SetPlaye2Check()
    {
        player2Name.text = PlayerPrefs.GetString("Player2_name");
        acs1Player2.texture = acs1[PlayerPrefs.GetInt("Player2_acs1")];
        acs2Player2.texture = acs2[PlayerPrefs.GetInt("Player2_acs2")];
        colorPlayer2.color = color[PlayerPrefs.GetInt("Player2_color")];

        Debug.Log(colorPlayer2.color);
    }

}
