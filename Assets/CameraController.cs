using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform keypadTransform; 
    public Transform originalCameraTransform; 
    public float zoomSpeed = 1.0f;

    private Vector3 targetPosition;
    private Quaternion targetRotation;
    private bool isZooming = false;

    void Start()
    {
        originalCameraTransform = transform;
    }

    void Update()
    {
        if (isZooming)
        {
            ZoomToKeypad();
        }
    }

    public void StartZooming()
    {
        targetPosition = keypadTransform.position + keypadTransform.forward * 0.5f; 
        targetRotation = Quaternion.LookRotation(keypadTransform.position - targetPosition);
        isZooming = true;
    }

    void ZoomToKeypad()
    {
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * zoomSpeed);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * zoomSpeed);

        if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
        {
            isZooming = false;
        }
    }

    public void ResetCamera()
    {
        transform.position = originalCameraTransform.position;
        transform.rotation = originalCameraTransform.rotation;
    }
}
