using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testcameracontrol : MonoBehaviour
{
    private Transform gunp;

    private void Awake()
    {
        gunp = transform.Find("Weaponholder");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = GetMouseWorldPosition();
        Vector3 dir = (mousePosition - transform.position).normalized;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        gunp.eulerAngles = new Vector3(0, 0, angle);
        Vector3 spin = Vector3.one;
        if (angle > 90 || angle < -90)
        {
            spin.y = -1f;
        }
        else
        {
            spin.y = +1f;
        }
        gunp.localScale = spin;
    }

    public static Vector3 GetMouseWorldPosition()
    {
        Vector3 vec = GetMouseWorldPositionZ(Input.mousePosition, Camera.main);
        vec.z = 0f;
        return vec;
    }

    public static Vector3 GetMouseWorldPositionZ(Vector3 screenPosition, Camera worldCamera)
    {
        Vector3 worldPosition = worldCamera.ScreenToWorldPoint(screenPosition);
        return worldPosition;
    }
}
