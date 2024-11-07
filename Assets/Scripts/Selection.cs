using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Selection : MonoBehaviour
{
    [SerializeField] private bool onlyColor;
    public int selection;

    [SerializeField] private string[] selectionName;
    [SerializeField] private TextMeshProUGUI displaySelectionName;
    [SerializeField] private RawImage displayImage;

    [SerializeField] private Texture[] acs;
    [SerializeField] private Color[] color;




    // Start is called before the first frame update
    void Start()
    {
        displaySelectionName.text = selectionName[selection];
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void NextSelect()
    {
        selection++;
        if (selection == selectionName.Length)
        {
            selection = 0;
        }
        displaySelectionName.text = selectionName[selection];

        if (!onlyColor)
        {
            displayImage.texture = acs[selection];
        }
        
        displayImage.color = color[selection];

        
    }
    public void PrevSelect()
    {
        selection--;
        if (selection < 0)
        {
            selection = selectionName.Length -1;
        }
        displaySelectionName.text = selectionName[selection];

        if (!onlyColor)
        {
            displayImage.texture = acs[selection];
        }
        displayImage.color = color[selection];
    }

}
