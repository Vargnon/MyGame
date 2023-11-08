using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Range(1, 10)]
    [SerializeField] private float _speed = 5f;
    [SerializeField] private Rigidbody _rigidbody;


    private void Update()
    {
        var horizontal  = Input.GetAxis("Horizontal");
        var vertical  = Input.GetAxis("Vetical");
        transform.position += new Vector3(x: horizontal, y: 0f, z: vertical) * Time.deltaTime * _speed;
    }
}
