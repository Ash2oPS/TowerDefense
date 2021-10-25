using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float _cameraSpeed = 2.0f;
    private float cameraSpeed { get { return _cameraSpeed; } set { _cameraSpeed = value; } }

    private Transform cameraTransform { get; set; } = null;

    public float _borderSize = 10.0f;
    private float borderSize { get { return _borderSize; } }
    

    private void Start()
    {
        cameraTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 direction = Vector3.zero;

        if (mousePos.x <= borderSize || Input.GetAxis("Horizontal") <= -0.5f )
        {
            direction -= Vector3.right;
        } else if (mousePos.x >= Screen.width - borderSize || Input.GetAxis("Horizontal") >= 0.5f)
        {
            direction += Vector3.right;
        }

        if (mousePos.y <= borderSize || Input.GetAxis("Vertical") <= -0.5f)
        {
            direction -= Vector3.forward;
        }
        else if (mousePos.y >= Screen.height - borderSize || Input.GetAxis("Vertical") >= 0.5f)
        {
            direction += Vector3.forward;
        }

        direction.Normalize();
        cameraTransform.position += direction * Time.deltaTime * cameraSpeed;
    }
}
