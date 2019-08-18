using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    // Instance Variable
    [SerializeField] Text textComponent;
    // Start is called before the first frame update
    void Start()
    {
        GameText();  
    }

    void GameText()
    {
        textComponent.text = ("This is going to be the game text");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
