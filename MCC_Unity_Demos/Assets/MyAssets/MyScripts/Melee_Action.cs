using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee_Action : MonoBehaviour
{
    public GameObject weapon;
    public KeyCode keyBoardButton;

    private bool _isActivated;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyBoardButton))
        {
            Melee();
        }
    }
    void Melee()
    {
        weapon.GetComponent<Animator>().SetTrigger("Action");
    }
}
