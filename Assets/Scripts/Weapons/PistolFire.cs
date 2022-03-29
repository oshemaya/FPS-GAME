using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolFire : MonoBehaviour
{
    public GameObject blackPistol;
    public bool isFiring = false;
    public GameObject muzzleFlash;
    public AudioSource pistolShot;
   
    public float toTarget;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (isFiring == false)
            {
                StartCoroutine(FireThePistol());
            }

        } 
    }

    IEnumerator FireThePistol()
    {
        isFiring = true;

        toTarget = PlayerCasting.distanceFromTarget;
        blackPistol.GetComponent<Animator>().Play("Fire_Pistol");
        pistolShot.Play();
        muzzleFlash.SetActive(true);
        yield return new WaitForSeconds(0.03f);
        muzzleFlash.SetActive(false);
        yield return new WaitForSeconds(0.22f);
        blackPistol.GetComponent<Animator>().Play("New State");
        isFiring = false;



    }


}
