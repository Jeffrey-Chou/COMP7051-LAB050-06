using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public abstract class IOnHit : MonoBehaviour
{
    public abstract void OnHit(RaycastHit hitInfo, Vector3 hitDirection);
}
