using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPlay: MonoBehaviour
{
    public SceneManager changeScreen;

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(2);
        Debug.Log("SHOOT ME");
    }
}
