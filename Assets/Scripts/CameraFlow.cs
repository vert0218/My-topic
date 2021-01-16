using UnityEngine;
using System.Collections;
//拍後面
public class CameraFlow : MonoBehaviour
{
    private const float V = 1;
    public Transform target;

    public float distanceUp = 5f;
    public float distanceAway = 10f;
    public float smooth = 2f;
    public float camDepthSmooth = 5f;
    void Start()
    {

    }
    void Update()
    {
        if ((Input.mouseScrollDelta.y < 0 && Camera.main.fieldOfView >= 3) || (Input.mouseScrollDelta.y > 0 && Camera.main.fieldOfView <= 10))
        {
            Camera.main.fieldOfView += Input.mouseScrollDelta.y * camDepthSmooth ;
        }
    }
    void LateUpdate()
    {
        Vector3 disPos = target.position  + (Vector3.up * distanceUp*2) - (target.forward * distanceAway);
        transform.position = Vector3.Lerp(transform.position, disPos, Time.deltaTime * smooth);
        transform.LookAt(target.position);
    }
}