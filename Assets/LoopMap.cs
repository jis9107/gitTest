using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopMap : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float scrollAmount;
    [SerializeField] private float moveSpeed;
    private Vector3 moveDirection;
    private void Start()
    {
        moveDirection = -Vector3.up;
    }

    private void Update()
    {
        // 배경이 moveDirection 방향으로 moveSpeed의 속도로 이동
        transform.position += moveDirection * Time.deltaTime * moveSpeed;
        
        // 배경이 설정된 범위를 벗어나면 위치 재설정
        if (transform.position.y <= -scrollAmount)
        {
            transform.position = target.position - moveDirection * scrollAmount;
        }

    }
}
