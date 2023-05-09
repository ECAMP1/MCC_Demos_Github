using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee_Repeat : MonoBehaviour
{
    public GameObject weapon;
    public KeyCode keyBoardButton;
    public GameObject weaponTrail;
    public float offDelay;

    private bool _isMoving;
    // Start is called before the first frame update
    void Start()
    {
        weaponTrail.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyBoardButton))
            _isMoving = !_isMoving;
        if (_isMoving)
        {
            weapon.GetComponent<Animator>().SetBool("isMirrored", false);
            weaponTrail.SetActive(true);
            Invoke("trailOff", offDelay);
        }
        else
            weapon.GetComponent<Animator>().SetBool("isMirrored", true);
    }

    void trailOff()
    {
        weaponTrail.SetActive(false);
    }
}
