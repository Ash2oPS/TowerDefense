using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private Transform enemyTransform { get; set; } = null;

    public float _speed = 2.0f;
    private float speed { get { return _speed; } set { _speed = value; } }

    private void Start()
    {
        enemyTransform = transform;
    }

    private void Update()
    {
        enemyTransform.position += Vector3.right * Time.deltaTime * speed;
    }
}
