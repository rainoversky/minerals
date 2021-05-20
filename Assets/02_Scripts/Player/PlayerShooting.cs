using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations.Rigging;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour {

    public Transform gunTransform;
    public Transform aimTransform;
    public GameObject bulletPrefab;

    bool isShooting = false;
    bool canShoot = true;
    float shootingTimer;
    NavMeshAgent agent;
    Vector3 aimPoint;
    Vector3 aimPointHeight = new Vector3(0, 1.2f, 0);

    void OnEnable() {
        InputManager.Actions.Fire.performed += StartShooting;
        InputManager.Actions.Fire.canceled += StopShooting;
    }

    void OnDisable() {
        InputManager.Actions.Fire.performed -= StartShooting;
        InputManager.Actions.Fire.canceled -= StopShooting;
    }

    void Awake() {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
    }

    void Start() {

    }

    void Update() {
        CheckMousePosition();
        CheckShooting();
        Animate();
    }

    void CheckMousePosition() {
        float distance;
        Plane plane = new Plane(Vector3.up, transform.position + aimPointHeight);
        Ray ray = Camera.main.ScreenPointToRay(InputManager.Actions.MotionTarget.ReadValue<Vector2>());
        if (plane.Raycast(ray, out distance)) {
            aimPoint = ray.GetPoint(distance);
            aimTransform.position = aimPoint;
        }
    }

    void CheckShooting() {
        if (!canShoot) {
            shootingTimer += Time.deltaTime;
            if (shootingTimer > 1 / Player.shootRate) {
                shootingTimer = 0;
                canShoot = true;
            }
        } else if (isShooting && !(EventSystem.current && EventSystem.current.IsPointerOverGameObject())) {
            agent.ResetPath();
            Shoot(new Vector3(aimPoint.x, 0, aimPoint.z) - new Vector3(transform.position.x, 0, transform.position.z));
        }
    }

    void Shoot(Vector3 dir) {
        Bullet bulletInstance = Instantiate(bulletPrefab, gunTransform.position, Quaternion.identity).GetComponent<Bullet>();
        bulletInstance.Init(dir, Player.bulletSpeed, Player.damage, Player.bulletRange);
        canShoot = false;
    }

    void Animate() {
        // TODO
    }

    public void StartShooting(InputAction.CallbackContext ctx) {
        isShooting = true;
    }

    public void StopShooting(InputAction.CallbackContext ctx) {
        isShooting = false;
    }

}
