using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Camera : MonoBehaviour
{
    public Transform target; 
    public Vector3 offset; 
    
    public Vector2 limitX;
    public Vector2 limitY;
    public float interpolationRatio;

    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        Vector3 cameraPosition = target.position + offset;
        float limitedXposition = Mathf.Clamp(cameraPosition.x, limitX.x, limitX.y);
        float limitedYposition = Mathf.Clamp(cameraPosition.y, limitY.x, limitY.y);
        Vector3 limitedPosition = new Vector3(limitedXposition, limitedYposition, cameraPosition.z);
        Vector3 lerpedPosition = Vector3.Lerp(transform.position, limitedPosition, interpolationRatio);
        transform.position = lerpedPosition;
    }
}