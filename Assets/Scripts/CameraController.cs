using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        player = GameObject.Find("Capsule");
    }

    void LateUpdate()
    {
        transform.position = player.transform.position; //transform.position ist die Position der Kamera ... this. davor denken.
    }
}