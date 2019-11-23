using System;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public float speed;
    public readonly float smallBambooMultiplier = 0.5f, bigBambooMultiplierSolo = 0.25f, bigBambooMultiplierHelped = 1f, normalMultiplier = 1f;
    public float speedMultiplier = 1f;

    private float horizontal = 0, vertical = 0;

    private void Start()
    {
        speedMultiplier = 1f;
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        animator.SetFloat("SpeedMultiplier", speedMultiplier);
    }

    void FixedUpdate()
    {
        transform.Translate(new Vector3(horizontal * speed * speedMultiplier * Time.deltaTime, 0,  vertical * speed * speedMultiplier * Time.deltaTime));
        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);
    }
}
