using System;
using UnityEngine;

public class BigBamboo : Bamboo
{
    public Transform bambooSnapPoint1 = null, bambooSnapPoint2 = null;
    
    public Transform _mouthSnapPoint1 = null, _mouthSnapPoint2 = null;
    private Rigidbody _body;
    
    private void Start()
    {
        _body = GetComponent<Rigidbody>();
    }

    public override void Attach(Transform mouth)
    {
        if (_mouthSnapPoint1 == null)
        {
            _mouthSnapPoint1 = mouth;
            //transform.GetComponent<Collider>().enabled = false;
        }
        else if (_mouthSnapPoint2 == null)
        {
            _mouthSnapPoint2 = mouth;
            //transform.GetComponent<Collider>().enabled = false;
        }
        _body.constraints = RigidbodyConstraints.FreezeRotationZ;
    }

    public override void Detach(Transform mouth)
    {
        if (_mouthSnapPoint1 == mouth)
        {
            _mouthSnapPoint1 = null;
            //transform.GetComponent<Collider>().enabled = true;
        }
        else if (_mouthSnapPoint2 == mouth)
        {
            _mouthSnapPoint2 = null;
            //transform.GetComponent<Collider>().enabled = true;
        }
        if (_mouthSnapPoint1 == null && _mouthSnapPoint2 == null)
            _body.constraints = RigidbodyConstraints.FreezeRotationZ;
    }

    private void MoveBambooSnapPoint(Transform bsp, Transform msp)
    {
        Vector3 offset = new Vector3(
            Math.Abs(transform.position.x - bsp.position.x),
            Math.Abs(transform.position.y - bsp.position.y),
            Math.Abs(transform.position.z - bsp.position.z));
        Vector3 newOrigin = msp.position - offset;
        //print(offset);
        _body.MovePosition(newOrigin);
    }
    
    private void Update()
    {
        if (_mouthSnapPoint1 != null)
        {
            MoveBambooSnapPoint(bambooSnapPoint1, _mouthSnapPoint1);
        }

        if (_mouthSnapPoint2 != null)
        {
            MoveBambooSnapPoint(bambooSnapPoint2, _mouthSnapPoint2);
        }
    }
}
