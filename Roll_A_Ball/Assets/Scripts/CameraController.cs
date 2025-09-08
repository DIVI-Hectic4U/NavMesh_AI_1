using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player; // Reference to the Player GameObject
    private Vector3 Offset; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Offset = transform.position - player.transform.position;   
        // Calculate the initial offset between the camera and the Player.
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Maintains the same offset throughout the game 
        transform.position = player.transform.position + Offset;
    }
}
