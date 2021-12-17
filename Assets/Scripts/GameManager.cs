using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	public int Switches = 0;
	public GameObject Door;
    public GameManager GM;
	public float RoundTimer { get; internal set; }
    public int PlayerCharacter { get; internal set; }

	private void Start () 
	{
	
	}
	
	private void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {

        }

		if(Switches == 4)
        {
			Destroy(Door);
        }
	}

}