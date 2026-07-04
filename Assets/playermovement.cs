using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class playermovement : MonoBehaviour
{
    public float force;
    public float velocity;
    public Rigidbody rb;
    public Camera cam;
    public Vector3 movedirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        processinput();
        keeponscreen();
        rotatetoFace();
        
    }
    private void FixedUpdate()
    {
        if (movedirection == Vector3.zero)
        {
            return;
        }
        rb.AddForce(movedirection * force * Time.deltaTime, ForceMode.Force);
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, velocity); 
    }
    public void processinput () {
        if (Touchscreen.current == null) return;
        if (Touchscreen.current.primaryTouch.press.isPressed)
        {
            Vector2 touchposition = Touchscreen.current.primaryTouch.position.ReadValue();
            if (touchposition.x <= 0 && touchposition.y <= 0) return;

            Vector3 worldposition = cam.ScreenToWorldPoint(touchposition);
            movedirection = transform.position - worldposition;
            movedirection.z = 0;
            movedirection.Normalize();
        }
        else
        {
            movedirection = Vector3.zero;
        }
    }
    public void keeponscreen()
    {
        Vector3 newposition = transform.position;
        Vector3 viewportposition = cam.WorldToViewportPoint(newposition);

        if (viewportposition.x > 1)
        {
            viewportposition.x = 0;
        }
        else if (viewportposition.x < 0)
        {
            viewportposition.x = 1;
        }

        if (viewportposition.y > 1)
        {
            viewportposition.y = 0;
        }
        else if (viewportposition.y < 0)
        {
            viewportposition.y = 1;
        }

        transform.position = cam.ViewportToWorldPoint(viewportposition);
    }
    public void rotatetoFace() 
    {
        if (rb.velocity == Vector3.zero) 
        {
            return;
        }
        Quaternion targetrotation = Quaternion.LookRotation(rb.velocity, Vector3.back);
        transform.rotation = targetrotation;
    }
}
