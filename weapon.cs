using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal sealed class weapon : MonoBehaviour
{
    public Transform RangeWeaponPosition;
    public Transform TargetPoint;

    private Vector3 _direction;
    private float _rotationZ;

    private void Update()
    {
        Aim();
    }

    private void Aim()
    {
        if (Input.GetButton("Fire1"))
        {
            _direction = TargetPoint.position - RangeWeaponPosition.position;
            _rotationZ = Mathf.Atan2(_direction.y, _direction.x) * Mathf.Rad2Deg;
        }
    }
}
