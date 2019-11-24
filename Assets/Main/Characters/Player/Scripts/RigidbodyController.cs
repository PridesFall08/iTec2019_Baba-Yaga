using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyController : MonoBehaviour
{
    private Animator _anim;
    public float speed = 2f;
    public float speedMultiplier = 1f;
    public float jumpHeight = 1f;
    public float groundDistance = 0.2f;
    public LayerMask ground;

    private Rigidbody _body;
    private Vector3 _inputs = Vector3.zero;
    private bool _isGrounded = true;
    [SerializeField] private Transform _groundChecker;

    void Start()
    {
        _anim = GetComponentInChildren<Animator>();
        _body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _isGrounded = Physics.CheckSphere(_groundChecker.position, groundDistance, ground, QueryTriggerInteraction.Ignore);
        _inputs = Vector3.zero;
        _inputs.x = Input.GetAxis("Horizontal");
        _inputs.z = Input.GetAxis("Vertical");
        _anim.SetFloat("Horizontal", _inputs.x);
        _anim.SetFloat("Vertical", _inputs.z);
        _anim.SetFloat("SpeedMultiplier", speedMultiplier);

        if (Input.GetButtonDown("Jump") && _isGrounded)
        {
            _body.AddForce(Vector3.up * Mathf.Sqrt(jumpHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange);
        }
    }
    
    void FixedUpdate()
    {
        Vector3 newPosition = _body.position + transform.TransformDirection (new Vector3(
                                  _inputs.x * speed * speedMultiplier * Time.fixedDeltaTime,
                                  0,
                                  _inputs.z * speed * speedMultiplier * Time.fixedDeltaTime));
        _body.MovePosition (newPosition);

    }

    public void ResetSpeedMultiplier()
    {
        speedMultiplier = 1f;
    }
}
