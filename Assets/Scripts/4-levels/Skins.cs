using UnityEngine;
using UnityEngine.InputSystem;

/**
 * Logs to the console whenever one of the bound keys is pressed.
 */
public class ButtonLogger : MonoBehaviour
{
    [SerializeField] private InputAction keyAction = new InputAction(type: InputActionType.Button);

    [SerializeField] public SpriteRenderer spriteRenderer;
    [SerializeField] public Sprite[] skin;

    private void OnEnable()
    {
        keyAction.Enable();
        keyAction.performed += OnKey;
    }

    private void OnDisable()
    {
        keyAction.performed -= OnKey;
        keyAction.Disable();
    }

    private void OnKey(InputAction.CallbackContext ctx){
        string key = ctx.control.displayName;
        Debug.Log("Pressed key: " + key);
        if (key == "1"){
            spriteRenderer.sprite = skin[0];
        }
        else if (key == "2"){
            spriteRenderer.sprite = skin[1];
        }
        else if (key == "3"){
            spriteRenderer.sprite = skin[2];
        }
        else if (key == "4"){
            spriteRenderer.sprite = skin[3];
        }
        else if (key == "5"){
            spriteRenderer.sprite = skin[4];
        }
        else if (key == "6"){
            spriteRenderer.sprite = skin[5];
        }
        else if (key == "7"){
            spriteRenderer.sprite = skin[6];
        }

    }
}
