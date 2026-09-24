using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float sensibilidade = 200f;

    float rotacaoX = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensibilidade * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidade * Time.deltaTime;

        rotacaoX -= mouseY;
        rotacaoX = Mathf.Clamp(rotacaoX, -80f, 80f);

        transform.localRotation = Quaternion.Euler(rotacaoX, 0f, 0f);

        transform.parent.Rotate(Vector3.up * mouseX);
    }
}