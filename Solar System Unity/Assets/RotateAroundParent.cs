using UnityEngine;

public class RotateAroundParent : MonoBehaviour
{
    void Update()
    {
        transform.RotateAround(transform.parent.position, Vector3.up, (Time.deltaTime * 500f) / Vector3.Distance(transform.parent.position, transform.position));
    }
}
