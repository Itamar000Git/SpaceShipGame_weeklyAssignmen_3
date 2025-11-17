using UnityEngine;
using UnityEngine.InputSystem;

public class TiltController : MonoBehaviour
{
    [SerializeField] private InputAction rotateAction = new InputAction(type: InputActionType.Button);
    [SerializeField] private float rotateSpeed = 720f;

    private bool click = false;
    private float rotatedSoFar = 0f;
    private float startZ;

    private void OnEnable()
    {
        rotateAction.Enable();
        rotateAction.performed += OnTilt;
    }

    private void OnDisable()
    {
        rotateAction.performed -= OnTilt;
        rotateAction.Disable();
    }
    private void OnTilt(InputAction.CallbackContext ctx)
    {
        string key = ctx.control.displayName;
        Debug.Log("Pressed: " + key);

        if (!click)   {
            click = true;
            rotatedSoFar = 0f;
            startZ = transform.eulerAngles.z; 
        }
    }

    private void Update()
    {
        if (!click)
            return;

        float delta = rotateSpeed * Time.deltaTime;
        rotatedSoFar += delta;

        float angle = Mathf.Min(rotatedSoFar, 360f); //fix aoverrotate

        float currentZ = startZ + angle;
        transform.rotation = Quaternion.Euler(0, 0, currentZ);

        if (rotatedSoFar >= 360f){
            transform.rotation = Quaternion.Euler(0, 0, startZ);
            click = false;
            rotatedSoFar = 0f;
        }
    }
}
