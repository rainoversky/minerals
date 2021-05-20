using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject target;
    [Range(0, 359)]
    public float angleY = 180;
    [Range(5, 85)]
    public float angleXZ = 45;
    [Range(3, 10)]
    public float distance = 7;

    float posX;
    float posY;
    float posZ;

    void Start() {

    }

    void OnValidate() {
        if (!target) return;
        float angleYRad = angleY * Mathf.Deg2Rad;
        float angleXYRad = angleXZ * Mathf.Deg2Rad;
        Camera.main.transform.position = new Vector3(Mathf.Sin(angleYRad), 1, Mathf.Cos(angleYRad));
        float distXZ = distance * Mathf.Cos(angleXYRad);
        posX = distXZ * Mathf.Sin(angleYRad);
        posY = distance * Mathf.Sin(angleXYRad);
        posZ = distXZ * Mathf.Cos(angleYRad);
        Camera.main.transform.position = new Vector3(posX + target.transform.position.x, posY, posZ + target.transform.position.z);
        transform.LookAt(target.transform.position + Vector3.up);
    }

    void LateUpdate() {
        Camera.main.transform.position = new Vector3(posX + target.transform.position.x, posY, posZ + target.transform.position.z);
        transform.LookAt(target.transform.position + Vector3.up);
    }

    public void SetTarget(GameObject _target) {
        target = _target;
    }

}
