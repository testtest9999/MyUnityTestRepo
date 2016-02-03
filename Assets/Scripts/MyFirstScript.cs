using UnityEngine;
using System.Collections;

public class MyFirstScript : MonoBehaviour
{

    private new Transform transform;

    void Awake()
    {
        transform = GetComponent<Transform>();
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward;
    }
}
