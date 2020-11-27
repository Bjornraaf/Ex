using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCont : MonoBehaviour
{
    private Weapon[] weapons;
    private Weapon currentWeapon;
    // Start is called before the first frame update
    void Start()
    {
        weapons = new Weapon[1];

        weapons[0] = GetComponent<Pistol>();
        currentWeapon = weapons[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentWeapon.TriggerDown();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwapWeapon(0);
        }

    }
    void SwapWeapon(int input)
    {
        Debug.Log("Switch" + input);
        currentWeapon = weapons[input];
    }
}
