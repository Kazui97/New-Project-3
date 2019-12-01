using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviCamara : MonoBehaviour
{

    private bool movi = true;
    public float camspeed = 30f;
    public float bordepan = 10f;

    public float scrollspeed = 5f;
    public float miny = 10f;
    public float maxy = 80f;



    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            movi = !movi;
        if (!movi)
            return;
        if (Input.mousePosition.y >= Screen.height - bordepan)
        {
            transform.Translate(Vector3.forward * camspeed * Time.deltaTime, Space.World);
        }
        if (Input.mousePosition.y <=  bordepan)
        {
            transform.Translate(Vector3.back * camspeed * Time.deltaTime, Space.World);
        }
        if(Input.mousePosition.x >= Screen.width - bordepan)
        {
            transform.Translate(Vector3.right * camspeed * Time.deltaTime, Space.World);
        }
        if (Input.mousePosition.x <= bordepan)
        {
            transform.Translate(Vector3.left * camspeed * Time.deltaTime, Space.World);
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Vector3 pos = transform.position;
        pos.y = scroll * 10 * scrollspeed * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, miny, maxy);
        transform.position = pos;
            
     
        
    }
}
