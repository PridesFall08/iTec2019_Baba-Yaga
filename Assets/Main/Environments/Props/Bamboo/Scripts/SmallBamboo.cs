using UnityEngine;

public class SmallBamboo : Bamboo
{
    public Transform bambooSnapPoint = null;
    
    private Transform _mouthSnapPoint = null;
    private Rigidbody _body;

    private void Start()
    {
        _body = GetComponent<Rigidbody>();
    }

    public override void Attach(Transform mouth)
    {
        _mouthSnapPoint = mouth;
        _body.MovePosition(_mouthSnapPoint.position);
        _body.MoveRotation(_mouthSnapPoint.rotation);
        transform.GetComponent<Collider>().enabled = false;
        _body.constraints = RigidbodyConstraints.FreezeRotation;
        _body.useGravity = false;
    }

    public override void Detach(Transform mouth)
    {
        _mouthSnapPoint = null;
        transform.GetComponent<Collider>().enabled = true;
        _body.constraints = RigidbodyConstraints.None;
        _body.useGravity = true;
    }

    private void Update()
    {
        if (_mouthSnapPoint != null)
        {
            _body.MovePosition(_mouthSnapPoint.position);
            _body.MoveRotation(_mouthSnapPoint.rotation);
        }
    }
}
