using UnityEngine;

public class SC_CameraCollision : MonoBehaviour
{
    public Transform referenceTransform;
    public float collisionOffset = 0.3f; //To prevent Camera from clipping through Objects
    public float cameraSpeed = 15f; //How fast the Camera should snap into position if there are no obstacles

    Vector3 defaultPos;
    Vector3 directionNormalized;
    Transform parentTransform;
    float defaultDistance;
    private float XRotation = 14;
    // Start is called before the first frame update
    void Start()
    {
        defaultPos = transform.localPosition;
        directionNormalized = defaultPos.normalized;
        parentTransform = transform.parent;
        defaultDistance = Vector3.Distance(defaultPos, Vector3.zero);

        
    }

    // LateUpdate is called after Update
    void LateUpdate()
    {
        transform.localRotation = Quaternion.Euler(XRotation, 0, 0);
        Vector3 currentPos = defaultPos;
        RaycastHit hit;
        Vector3 dirTmp = parentTransform.TransformPoint(defaultPos) - referenceTransform.position;
        if (Physics.SphereCast(referenceTransform.position, collisionOffset, dirTmp, out hit, defaultDistance))
        {
            currentPos = (directionNormalized * (hit.distance - collisionOffset));

            transform.localPosition = currentPos;
        }
        else
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, currentPos, Time.deltaTime * cameraSpeed);
        }
    }
}