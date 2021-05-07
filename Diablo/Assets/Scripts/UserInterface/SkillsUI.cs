using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillsUI : MonoBehaviour
{
    public GameObject skillsUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Skills"))
        {
            skillsUI.SetActive(!skillsUI.activeSelf);
        }
    }
}
