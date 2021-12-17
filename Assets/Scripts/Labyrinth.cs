using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labyrinth : MonoBehaviour
{
    public GameObject PlayerSpawn;
    public GameObject Player;
    public GameObject[] LockSpawn;
    public GameObject Door;
    public GameObject Lock;
    public Vector3 cameraOffSet;
    public Transform TargetPlayer;
    private int numberToSpawn;
    private int numberToSpawn1;
    private int numberToSpawn2;
    private int numberToSpawn3;
   
    

    // Start is called before the first frame update
    private void Start()
    {
        LoadObject();
        Instantiate(Player, PlayerSpawn.transform.position, PlayerSpawn.transform.rotation);
        cameraOffSet = transform.position - TargetPlayer.transform.position;
      
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPosition = TargetPlayer.transform.position + cameraOffSet;
    }
    void LoadObject()
    {
        numberToSpawn = Random.Range(0, LockSpawn.Length);
        Instantiate(Lock, LockSpawn[numberToSpawn].transform.position, LockSpawn[numberToSpawn].transform.rotation);
        numberToSpawn1 = Random.Range(0, LockSpawn.Length);
        if(numberToSpawn1 == numberToSpawn)
        {
            numberToSpawn1--;
            if (numberToSpawn1 == -1)
            {
                numberToSpawn1 = 11;
            }
        }
        Instantiate(Lock, LockSpawn[numberToSpawn1].transform.position, LockSpawn[numberToSpawn1].transform.rotation);
        numberToSpawn2 = Random.Range(0, LockSpawn.Length);
        if(numberToSpawn2 == numberToSpawn||numberToSpawn2 == numberToSpawn1)
        {
            numberToSpawn2++;
            if (numberToSpawn2 == 12 || numberToSpawn2 == numberToSpawn || numberToSpawn2 == numberToSpawn1)
            {
                numberToSpawn2 = 0;
            }
        }
        Instantiate(Lock, LockSpawn[numberToSpawn2].transform.position, LockSpawn[numberToSpawn2].transform.rotation);
        numberToSpawn3 = Random.Range(0, LockSpawn.Length);
        if(numberToSpawn3 == numberToSpawn2 || numberToSpawn3 == numberToSpawn1 || numberToSpawn3 == numberToSpawn)
        {
            numberToSpawn3 = 4;
            if(numberToSpawn3 == numberToSpawn2 || numberToSpawn3 == numberToSpawn1 || numberToSpawn3 == numberToSpawn)
            {
                numberToSpawn3 = 6;
            }
        }
        Instantiate(Lock, LockSpawn[numberToSpawn3].transform.position, LockSpawn[numberToSpawn3].transform.rotation);

    }
}
