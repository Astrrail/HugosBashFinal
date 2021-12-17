using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMash : MonoBehaviour
{
    public int NumberOfTimesPressed;
    public int countdownTimer;
    public int gameTimer;
    public Text countdownDisplay;
    public Text gameTimerDisplay;


    private void Start()
    {
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        while(countdownTimer > 0)
        {
            countdownDisplay.text = countdownTimer.ToString();

            yield return new WaitForSeconds(1f);

            countdownTimer--;
        }
        countdownDisplay.text = "MASH IT";

        yield return new WaitForSeconds(1f);

        countdownDisplay.gameObject.SetActive(false);

     
    }
 

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Distance();
        }
        

    }
    public void Distance()
    {
        transform.Translate(Vector3.forward);
        NumberOfTimesPressed++;
    }

}
