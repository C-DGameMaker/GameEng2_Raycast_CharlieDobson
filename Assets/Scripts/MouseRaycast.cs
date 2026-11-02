using UnityEngine;
using UnityEngine.InputSystem;

public class MouseRaycast : MonoBehaviour
{

    public void RayCastFire()
    {
        Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(cameraRay, out RaycastHit hit))
        {
            Debug.Log(hit.collider.gameObject.name);
        }
    }
}
