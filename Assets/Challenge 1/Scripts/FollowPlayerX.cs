using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 rotateCam = new Vector3(0,270,0);
    private Vector3 offset=new Vector3(30,0,10);

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(rotateCam);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
