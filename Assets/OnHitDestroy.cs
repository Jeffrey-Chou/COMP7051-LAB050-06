using UnityEngine;

public class OnHitDestroy : IOnHit
{
    public override void OnHit(RaycastHit hitInfo, Vector3 hitDirection)
    {
        Destroy(this.gameObject);
    }
}
