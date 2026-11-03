using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.DualShock.LowLevel;

public class MouseRaycast : MonoBehaviour
{
    public TextMeshProUGUI youHitText;

    public void RayCastFire(InputAction.CallbackContext context)
    {
            Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(cameraRay, out RaycastHit hit))
            {
                youHitText.text = "You Hit:" + " " + hit.collider.gameObject.name.ToString();
                Renderer rend = hit.collider.gameObject.GetComponent<Renderer>();

                rend.material.color = Random.ColorHSV(0f, 1f, 0.5f, 1f);
            }
            else
            {
                youHitText.text = "You Hit: Air";
            }
        
        
    }
}
