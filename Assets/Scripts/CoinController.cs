using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(eulers: new Vector3(x: 15f, y: .2f, z: 92f) * Time.deltaTime);
    }
}
