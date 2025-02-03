using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasItem : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;
    private void Update()
    {
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("충돌");
            GameManager.Instance.ChangeGas(20);
            Destroy(gameObject);
        }
    }
}
