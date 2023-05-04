using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee_Action : MonoBehaviour
{
    public GameObject weapon;
    public KeyCode keyBoardButton;
    public GameObject weaponTrail;
    public float offDelay;

    private bool _isActivated;
    // Start is called before the first frame update
    void Start()
    {
        weaponTrail.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyBoardButton))
        {
            Melee();
            weaponTrail.SetActive(true);
            Invoke("weaponTrailOff", offDelay);
        }
    }
    void Melee()
    {
        weapon.GetComponent<Animator>().SetTrigger("Action");
    }

    void weaponTrailOff()
    {
        weaponTrail.SetActive(false);
    }
}
