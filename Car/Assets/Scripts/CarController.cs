using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CarController : MonoBehaviour
{
    [Range(0,1000)]
    [SerializeField] private float moveSpeed;
    private Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rigidbody.velocity = Vector3.right * moveSpeed * Time.fixedDeltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<BoxController>() != null)
        {
            moveSpeed = 0;
            GameController.FinishGame("YOU LOSE");
        }

        if (collision.gameObject.GetComponent<FinishController>() != null)
        {
            moveSpeed = 0;
            GameController.FinishGame("YOU WIN");
        }
    }
}
