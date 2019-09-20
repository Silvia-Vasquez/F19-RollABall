using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject sphere;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - sphere.transform.position;
    }
    private void LateUpdate()
    {
        transform.position = sphere.transform.position + offset;
    }
}
