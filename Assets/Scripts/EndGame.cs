using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public GameObject player;
    public Transform respawn;

    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = new Vector3(respawn.position.x, respawn.position.y, respawn.position.z);
        Debug.Log("moooooo");
    }
}
