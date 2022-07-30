using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class almalkey : MonoBehaviour
{            string heroname = "almalkey";
             int heroheight = 185;
             int heroage = 17;
             string herosuperpower = "speed";
             int heroheightafter = 185 + 5;


             string villainName = "yousef";
             int vililanHeight = 175;
             int villainAge = 15;
             string villainSuperPower = "boxing";
             string villainSuperPowerafter = "None";

            
             


    // Start is called before the first frame update
    void Start()
    {
    
        print("hero name is" + heroname + "hero height is" + heroheight + "hero age is" + heroage + "hero superpower is" + herosuperpower);
        print("villain Name is" + villainName + " vililan Height is" + vililanHeight + "villain Age is" + villainAge + "villain SuperPower is" + villainSuperPower);
        print("Age differnce" + (heroage - villainAge));
        print("hero height after is" + heroheightafter);
        print("villain SuperPower after is" + villainSuperPowerafter);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
