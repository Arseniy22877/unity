using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStick : MonoBehaviour
{
    Vector2 point;
    Vector3 pos;
    float x;
    float y;

    float dx;
    float dy;
    public GameObject player;

    float px = -1, py = -1;
    float sin;
    float cos;
    float len;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnMouseDown() {
        px = Input.mousePosition.x;
        py = Input.mousePosition.y;
    }
    void OnMouseDrag()
    {
        x = Input.mousePosition.x;
        y = Input.mousePosition.y;
        if(x < 0 || y < 0){
            return;
        }
        Debug.Log ("px: " + px + "   py: " + py);

        dx = x - px;
        dy = y - py;
        Debug.Log ("dx: " + dx + "   dy: " + dy);
        len = Mathf.Sqrt(dx * dx + dy * dy);
        cos = dx / len;
        sin = dy / len;
        if(dx == 0){
            cos = 0;
            sin = Mathf.Abs(dy) / dy;
        }
        if(dy == 0){
            cos = Mathf.Abs(dx) / dx;
            sin = 0;
        }
        if(dx == 0 && dy == 0){
            cos = 0;
            sin = 0;
        }
        Debug.Log ("cos: " + cos + "   sin: " + sin);

        pos = new Vector3(cos * speed * Time.deltaTime, 0, sin * speed * Time.deltaTime);

        player.transform.position += pos;

        point = new Vector2 (x, y);

        Debug.Log ("x: " + point.x + "   y: " + point.y);
    }
}
