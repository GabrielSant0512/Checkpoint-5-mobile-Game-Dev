using UnityEngine;

public class TargetFactory : MonoBehaviour
{
    public GameObject targetPrefab;

    public void CreateTarget(Vector3 position)
    {
        Instantiate(targetPrefab, position, Quaternion.identity);
    }
}