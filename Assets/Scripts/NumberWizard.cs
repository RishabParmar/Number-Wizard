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
        guessText.text = (Random.Range(min, max)).ToString();              
    }

    public void GoHigher()
    {
        // + 1 because the Random won't guess that random number again as min and max are inclusive
        min = int.Parse(guessText.text) + 1;
        guessText.text = (Random.Range(min, max)).ToString();
    }

    public void GoLower()
    {
        // - 1 because the Random won't guess that random number again as min and max are inclusive
        max = int.Parse(guessText.text) - 1;
        guessText.text = (Random.Range(min, max)).ToString();
    }
}
