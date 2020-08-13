using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    [SerializeField] TextMeshProUGUI guessText;

    // Start is called before the first frame update
    void Start()
    {        
        guessText.text = ((max + min) / 2).ToString();
        // max += 1: So that 1000 is inclusive of the range 1 - 1000
        max += 1;        
    }

    public void GoHigher()
    {
        min = (max + min) / 2;
        guessText.text = (((max + min) / 2) - 1).ToString();
    }

    public void GoLower()
    {
        max = (max + min) / 2;
        guessText.text = (((max + min) / 2) - 1).ToString();
    }
}
