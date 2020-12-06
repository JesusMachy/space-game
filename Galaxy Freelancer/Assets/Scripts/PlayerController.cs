using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    SkillSheet skillSheet;

    // Start is called before the first frame update
    void Start()
    {
        skillSheet = GetComponent<SkillSheet>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public SkillSheet GetSkillSheet()
    {
        return this.skillSheet;
    }
}
