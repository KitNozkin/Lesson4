using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoShake : MonoBehaviour
{
	public Animator goshake;

	public void Shake()
    {
        goshake.SetTrigger("Shake");
    }

}
