using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class RayShooter : MonoBehaviour
{
    public float rayDistance = 10f;
    public InputActionReference shootAction; // Vedä tähän XRInputActions → "Shoot"

    private void OnEnable()
    {
        shootAction.action.performed += ShootRay;
        shootAction.action.Enable();
    }

    private void OnDisable()
    {
        shootAction.action.Disable();
        shootAction.action.performed -= ShootRay;
    }

    void ShootRay(InputAction.CallbackContext context)
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            Target target = hit.collider.GetComponent<Target>();
            if (target != null)
            {
                target.Hit();
            }
        }
    }
}
