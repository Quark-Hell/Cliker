using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam1 : MonoBehaviour
{
    public GameObject cooooooooooolmoney;
    public float speeeeed;
    public void Update()
    {
        var ihgghjnnnvcffgf = transform.position.z;
        transform.position = Vector3.Lerp(transform.position,cooooooooooolmoney.transform.position,speeeeed);
        transform.position = new Vector3(transform.position.x,transform.position.y,ihgghjnnnvcffgf);
    }
}
