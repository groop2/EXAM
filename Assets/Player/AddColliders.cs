using UnityEngine;

public class AddColliders : MonoBehaviour
{
    void Start()
    {
        foreach (Transform child in transform)
        { 
            child.gameObject.AddComponent<MeshCollider>();
        }
    }
}
