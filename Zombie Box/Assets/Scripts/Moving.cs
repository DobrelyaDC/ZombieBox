
using UnityEngine;

public class Moving : MonoBehaviour
{
    public Joystick joystick;
    
    
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
                
    }

    void FixedUpdate()
    {
        
        var characterController = GetComponent<CharacterController>();

        transform.SetPositionAndRotation(new Vector3(transform.position.x + joystick.Horizontal * 10f * Time.deltaTime,
            transform.position.y, transform.position.z + joystick.Vertical * 10f * Time.deltaTime),new Quaternion());


        
    }
}
