using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseRaycast : MonoBehaviour
{
    public TextMeshProUGUI youHitText;

    public void RayCastFire()
    {
        Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(cameraRay, out RaycastHit hit))
        {
            youHitText.text = "You Hit:" + " " + hit.collider.gameObject.name.ToString();
        }
    }
}
