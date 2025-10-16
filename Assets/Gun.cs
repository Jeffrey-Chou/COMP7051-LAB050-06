using UnityEngine;
using UnityEngine.Rendering;

public class Gun : MonoBehaviour
{
    public Transform hitSphere;
    Ray ray;
    RaycastHit hitInfo;
    public LayerMask layerMask;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        ray.origin = Camera.main.transform.position;
        ray.direction = Camera.main.transform.forward;
        float distance = 100f;

        if(Physics.Raycast(ray, out hitInfo, distance, layerMask))
        {
            hitSphere.gameObject.SetActive(true);
            hitSphere.position = hitInfo.point;

            if(hitInfo.collider.gameObject)
            {
                hitInfo.collider.gameObject.GetComponentInParent<IOnHit>()?.OnHit(hitInfo, ray.direction);
            }
        }
        else
        {
            hitSphere.gameObject.SetActive(false);
            hitSphere.position = ray.origin + ray.direction * distance;
        }

        Debug.DrawLine(ray.origin, hitSphere.position, Color.red, 3f);
    }
}
