using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plmmv : MonoBehaviour
{
  public Rigidbody ri;
    public float speed,mos,speed2;
    float rot,rot2;
    public Transform camera;
    public int jins=5;
    public Text tx;
    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;
        ri.velocity = (transform.forward * Input.GetAxisRaw("Vertical") + transform.right * Input.GetAxisRaw("Horizontal")).normalized * (Input.GetKey(KeyCode.LeftShift) == true ? speed2 : speed) + new Vector3(0,ri.velocity.y,0);
        rot += Input.GetAxisRaw("Mouse X")*mos;
        rot2 = Mathf.Clamp(rot2 - Input.GetAxisRaw("Mouse Y")*mos, -80,80);
        transform.localEulerAngles = new Vector3(0, rot, 0);
        camera.localEulerAngles = new Vector3(rot2, 0, 0);
    }
}
