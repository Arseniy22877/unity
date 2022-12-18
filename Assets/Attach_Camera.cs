using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attach_Camera : MonoBehaviour
{
    public Transform cam;
    public float x;
    public float y;
    public float z;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pp = gameObject.transform.position;
        float dx,dy,dz;
        dx = pp.x - cam.position.x + x;
        dy = pp.y - cam.position.y + y;
        dz = pp.z - cam.position.z + z;
        cam.position = new Vector3((cam.position.x + dx * Time.deltaTime * speed), (cam.position.y + dy * Time.deltaTime * speed), (cam.position.z + dz * Time.deltaTime * speed));
    }

}
