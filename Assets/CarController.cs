using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class CarController : MonoBehaviour
{
    [SerializeField] private float movementSize;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (ray.origin.x > transform.position.x)
            {
                transform.position += Vector3.right * movementSize * Time.deltaTime;
            }
            else
            {
                transform.position += Vector3.left * movementSize * Time.deltaTime;
            }
             // 커밋 취소해보기
        }
    }

    
}
