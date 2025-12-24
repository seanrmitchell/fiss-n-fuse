using Unity.VisualScripting;
using UnityEngine;

public class InCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Debug.Log(collision.gameObject.name);
    }
}
