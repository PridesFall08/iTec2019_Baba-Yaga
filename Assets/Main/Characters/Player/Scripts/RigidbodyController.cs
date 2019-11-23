using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyController : MonoBehaviour
{
    private Animator anim;
    public float Speed = 2f;
    //public float JumpHeight = 2f;
    //public float GroundDistance = 0.2f;
    //public LayerMask Ground;

    private Rigidbody _body;
    private Vector3 _inputs = Vector3.zero;
    //private bool _isGrounded = true;
    //private Transform _groundChecker;

    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        _body = GetComponent<Rigidbody>();
        //_groundChecker = transform.GetChild(0);
    }

    void Update()
    {
        //_isGrounded = Physics.CheckSphere(_groundChecker.position, GroundDistance, Ground, QueryTriggerInteraction.Ignore);
        //print(_isGrounded);
        _inputs = Vector3.zero;
        _inputs.x = Input.GetAxis("Horizontal");
        _inputs.z = Input.GetAxis("Vertical");
        anim.SetFloat("Horizontal", _inputs.x);
        anim.SetFloat("Vertical", _inputs.z);

        /*if (Input.GetButtonDown("Jump") && _isGrounded)
        {
            _body.AddForce(Vector3.up * Mathf.Sqrt(JumpHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange);
        }*/
    }
    
    void FixedUpdate()
    {
        Vector3 newPosition = _body.position + transform.TransformDirection (new Vector3(
                                  _inputs.x * Speed * Time.fixedDeltaTime,
                                  0,
                                  _inputs.z * Speed * Time.fixedDeltaTime));
        _body.MovePosition (newPosition);

    }
}
