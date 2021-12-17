using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLocks : MonoBehaviour
{
    public GameObject GM;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        GM.GetComponent<GameManager>().Switches++;
        Destroy(this.gameObject);
    }

    private void Start()
    {
        GM = GameObject.FindGameObjectWithTag("POWERBUTTON");
    }
}
