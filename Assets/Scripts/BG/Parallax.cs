using UnityEngine;

public class Parallax : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float parallaxSpeed = 0.01f;
    private Transform cameraTransform;
    private Vector3 previousCameraPosition;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        cameraTransform = Camera.main.transform;
        previousCameraPosition = cameraTransform.position;
    }

    private void Update()
    {
        Vector3 deltaMovement = cameraTransform.position - previousCameraPosition;
        meshRenderer.material.mainTextureOffset += new Vector2(deltaMovement.x * parallaxSpeed, 0);
        previousCameraPosition = cameraTransform.position;
    }
}
