using UnityEngine;

public class CubePositionController : MonoBehaviour
{
    public enum Mode { Center, BottomLeft }
    public Mode mode = Mode.Center;
    public float distance = 5f;

    void Start()
    {
        Camera cam = Camera.main;

        if (mode == Mode.Center)
        {
            Vector3 pos = new Vector3(Screen.width / 2f, Screen.height / 2f, distance);
            transform.position = cam.ScreenToWorldPoint(pos);
        }
        else if (mode == Mode.BottomLeft)
        {
            Vector3 pos = new Vector3(0f, 0f, distance);
            transform.position = cam.ScreenToWorldPoint(pos);
        }
    }
}
