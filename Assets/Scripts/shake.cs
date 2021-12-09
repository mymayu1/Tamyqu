using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shake : MonoBehaviour
{   public Animator camAnimation;
     public void CamShake(){
        camAnimation.SetTrigger("shake");
    }
}
