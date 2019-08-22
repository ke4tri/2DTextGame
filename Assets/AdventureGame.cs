using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    // Instance Variable
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    //int[] oddNumbers = { 1, 3, 5, 7, 9 };
    //string[] daysWeek = { "Monday", "Tuesday", "Wed", "Thur", "Friday", "Sat", "Sun"};

    State state;

    // Start is called before the first frame update
    void Start()
    {

        GameText();
        //Debug.Log(oddNumbers[3]);
        //Debug.Log(daysWeek[1]);
    }

    void GameText()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    void GetNextStates()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        //using var instead of State[] becuase it knows the GetNextStates() is of type State
        var nextStates = state.GetNextStates();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
        }

        textComponent.text = state.GetStateStory();


    }
}
