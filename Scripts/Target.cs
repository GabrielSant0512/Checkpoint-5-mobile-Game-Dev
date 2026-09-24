using UnityEngine;

public class Target : MonoBehaviour
{
    public static event System.Action OnTargetDestroyed;

    public void DestroyTarget()
    {
        OnTargetDestroyed?.Invoke();
        Destroy(gameObject);
    }
}