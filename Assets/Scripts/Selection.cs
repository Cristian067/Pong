using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Selection : MonoBehaviour
{

    [SerializeField] private int selection;

    [SerializeField] private string[] selectionName;

    [SerializeField] private TextMeshProUGUI displaySelectionName;


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
        
    }
    public void PrevSelect()
    {
        selection--;
        if (selection < 0)
        {
            selection = selectionName.Length -1;
        }
        displaySelectionName.text = selectionName[selection];
    }

}
