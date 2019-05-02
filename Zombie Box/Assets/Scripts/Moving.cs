
using UnityEngine;

public class Moving : MonoBehaviour
{
    public Joystick joystick;
    
    
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
                
    }

    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();
        var characterController = GetComponent<CharacterController>();

        transform.SetPositionAndRotation(new Vector3(transform.position.x + joystick.Horizontal * 100f * Time.deltaTime,
            transform.position.y, transform.position.z + joystick.Vertical * 100f * Time.deltaTime),new Quaternion());


        /*rigidbody.velocity = new Vector3(joystick.Horizontal * 100f*Time.deltaTime,
                                         rigidbody.velocity.y,
                                         joystick.Vertical * 100f*Time.deltaTime);*/
    }
}
