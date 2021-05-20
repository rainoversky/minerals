using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public Vector3 direction;
    public float speed;
    public float damage;
    public float radius;
    public float distanceTraveled;
    public float maxRange;
    public float explosionArea;
    public Vector3 endPos;
    public string bulletID;

    MeshRenderer render;
    Vector3 lastPos;

    void Start() {
        render = GetComponent<MeshRenderer>();
    }

    public virtual void Update() {
        float moveDistance = Time.deltaTime * speed;
        Move(moveDistance);
        if (distanceTraveled >= maxRange) GameObject.Destroy(this.gameObject);
        lastPos = transform.position;
    }

    public virtual void Move(float moveDistance) {
        transform.Translate(direction * moveDistance);
        distanceTraveled += moveDistance;
    }

    public float GetDamage() {
        return damage;
    }

    internal void Init(Vector3 dir, float speed, float damage, float range) {
        direction = dir.normalized;
        this.speed = speed;
        this.damage = damage;
        maxRange = range;
    }

}

