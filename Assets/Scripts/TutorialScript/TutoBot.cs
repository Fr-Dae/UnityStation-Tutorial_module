using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class TutoBot : MonoBehaviour
{
    public Tutorial Tuto;
    private void FixedUpdate()
    {
        ///Repeat message when tutorial bot are clicked
        if(CommonInput.GetMouseButtonDown(0))
        {
            if((MouseUtils.MouseToWorldPos().x > (this.transform.position.x - .5) && MouseUtils.MouseToWorldPos().x < (this.transform.position.x + .5)
            && MouseUtils.MouseToWorldPos().y > (this.transform.position.y - .5) && MouseUtils.MouseToWorldPos().y < (this.transform.position.y + .5))
            )
            {
                Tuto.Message(Tutorial.BotGO);
            }
        }  
    }
}
