using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtomPresses : MonoBehaviour
{
    public int numberOfPresses;
    public int numberOfTimesPressed;
    public Text pressText;
    public GameObject counter;

    void Start()

    {
      numberOfTimesPressed = 0;
    }



    void Update()

    {

        pressText.text = numberOfTimesPressed + "";

        if (Input.GetKeyDown(KeyCode.Space))

        {
            Mash();
        }

    }

    public void Mash()

    {
        numberOfTimesPressed++;
    }

} 
    
