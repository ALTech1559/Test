using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class CameraController : MonoBehaviour
{
    [SerializeField] private Transform Car;

    [Header("Camera distance from car")]
    [SerializeField] private Vector3 vec;

    private void Update()
    {
        transform.position = Car.position - vec;
    }
}
