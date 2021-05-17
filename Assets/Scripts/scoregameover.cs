using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoregameover : MonoBehaviour
{

    public TMP_Text texts;
    // Start is called before the first frame update
    void Start()
    {
        texts.text = "Score: " + PlayerPrefs.GetInt("Score"); ;
    }

}
