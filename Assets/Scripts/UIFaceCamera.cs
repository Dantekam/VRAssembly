using UnityEngine;

public class UIFaceCamera : MonoBehaviour
{
    void Update()
    {
        Transform cam = Camera.main.transform;
        transform.LookAt(cam);
        transform.Rotate(0, 180, 0); // Flip to face forward
    }
}
