using UnityEngine;

public class OnHitKnockdown : IOnHit
{
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public override void OnHit(RaycastHit hitInfo, Vector3 hitDirection)
    {
        Vector3 force = hitDirection * 10;
        rb?.AddForceAtPosition(force, hitInfo.point);
    }
}
