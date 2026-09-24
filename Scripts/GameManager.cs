using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TargetFactory factory;

    void Start()
    {
        factory.CreateTarget(new Vector3(0, 1, 8));
        factory.CreateTarget(new Vector3(5, 1, 10));
        factory.CreateTarget(new Vector3(-5, 1, 10));
        factory.CreateTarget(new Vector3(5, 1, 15));
        factory.CreateTarget(new Vector3(-5, 1, 15));
    }
}