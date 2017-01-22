using UnityEngine;
using System.Collections;

/// <summary>
/// This is made to move a camera around the screen. I basically ignore that physics are a thing
/// </summary>
public class BasicMove : MonoBehaviour
{

    public float moveSpeed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        var heightChange = Input.GetKey(KeyCode.LeftShift) ? Time.deltaTime * -moveSpeed : Input.GetKey(KeyCode.Space) ? Time.deltaTime * moveSpeed : 0;
        transform.Rotate(0, x, 0);
        transform.Translate(0, heightChange, z);
    }
}
