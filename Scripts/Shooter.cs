using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Camera playerCamera;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Atirar();
        }
    }

    void Atirar()
    {
        Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Target target = hit.collider.GetComponent<Target>();

            if (target != null)
            {
                target.DestroyTarget();
            }
        }
    }
}