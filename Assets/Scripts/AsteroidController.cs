using System;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{

    Rigidbody2D _rb;
    Animator _animator;
    Collider2D _collider2D;

    [SerializeField] float speedY;
    [SerializeField] AudioClip clip;
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        
        _rb.AddForceY(-speedY, ForceMode2D.Impulse);

        _animator = GetComponent<Animator>();

        _collider2D = GetComponentInChildren<Collider2D>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        _animator.enabled = true;
        _collider2D.enabled = false;
        AudioSource.PlayClipAtPoint(clip,transform.position);
        Destroy(gameObject,0.5f);
    }
}