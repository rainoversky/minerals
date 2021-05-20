using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour {

    bool isWalking = false;
    Vector3 aimPoint;
    NavMeshAgent agent;
    PlayerAnimationInfo animInfo;
    Animator anim;
    Plane plane;

    void OnEnable() {
        InputManager.Actions.Walk.performed += StartWalking;
        InputManager.Actions.Walk.canceled += StopWalking;
    }

    void OnDisable() {
        InputManager.Actions.Walk.performed -= StartWalking;
        InputManager.Actions.Walk.canceled -= StopWalking;
    }

    void Awake() {
        animInfo = new PlayerAnimationInfo();
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponentInChildren<Animator>();
        agent.updateRotation = false;
        Player.Init();
    }

    void Start() {
        plane = new Plane(Vector3.up, transform.position);
        if (Camera.main.transform.rotation.eulerAngles.x >= 180) {
            Debug.LogWarning("Make sure the camera is pointing down");
        }
    }

    void Update() {
        CheckMousePosition();
        Move();
        Animate();
    }

    void CheckMousePosition() {
        float distance;
        Ray ray = Camera.main.ScreenPointToRay(InputManager.Actions.MotionTarget.ReadValue<Vector2>());
        if (plane.Raycast(ray, out distance)) {
            aimPoint = ray.GetPoint(distance);
        }
    }

    void Move() {
        if (InputManager.Actions.Walk.triggered && !(EventSystem.current && EventSystem.current.IsPointerOverGameObject())) {
            agent.SetDestination(aimPoint);
        } else if (isWalking && !(EventSystem.current && EventSystem.current.IsPointerOverGameObject())) {
            agent.SetDestination(aimPoint);
        } else if (EventSystem.current && EventSystem.current.IsPointerOverGameObject() && !isWalking) {
            agent.ResetPath();
        }
    }

    void Animate() {
        Vector3 movingDirection = aimPoint - transform.position;
        float rotSpeed = 720 * Time.deltaTime;
        float angle;
        Quaternion rotation = Quaternion.LookRotation(movingDirection);
        if (!animInfo.isRotating) animInfo.animRotation = rotation;
        if (agent.velocity.magnitude > .5f) {
            angle = -Vector3.SignedAngle(anim.transform.right, agent.velocity.normalized, Vector3.up);
            animInfo.lastAngle = Mathf.MoveTowards(Mathf.Abs(animInfo.lastAngle), Mathf.Abs(angle), rotSpeed) * Mathf.Sign(angle);
            anim.transform.rotation = Quaternion.RotateTowards(anim.transform.rotation, animInfo.animRotation, rotSpeed);
            animInfo.isRotating = false;
        } else {
            animInfo.lastAngle = Mathf.MoveTowards(animInfo.lastAngle, -Vector3.SignedAngle(anim.transform.right, movingDirection, Vector3.up), rotSpeed);
            if (animInfo.lastAngle < 25 || animInfo.lastAngle > 155) {
                if (!animInfo.isRotating) {
                    animInfo.isRotating = true;
                    animInfo.rotateTime = 0;
                }
            }
            if (animInfo.isRotating) {
                anim.transform.rotation = Quaternion.Lerp(anim.transform.rotation, animInfo.animRotation, animInfo.rotateTime);
                animInfo.rotateTime += Time.deltaTime * 1.7f;
                animInfo.isRotating = animInfo.rotateTime < 1;
            }
        }
        Vector3 moveDir = anim.transform.InverseTransformVector(agent.velocity.normalized);
        anim.SetFloat("moveAngleX", moveDir.x);
        anim.SetFloat("moveAngleY", moveDir.z);
        anim.SetFloat("moveSpeed", agent.velocity.magnitude);
    }

    public void StartWalking(InputAction.CallbackContext ctx) {
        isWalking = true;
    }

    public void StopWalking(InputAction.CallbackContext ctx) {
        isWalking = false;
    }

    struct PlayerAnimationInfo {

        public float lastAngle;
        public float movingSpeed;
        public float rotateTime;
        public bool isRotating;
        public float timeSinceLastShot;
        public bool grabbingGun;
        public Quaternion animRotation;

    }

}
