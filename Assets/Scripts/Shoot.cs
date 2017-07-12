using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject sight;
    private Rigidbody rb;
    public GameObject flash;

    /* Independent Vars. */
    private bool _muzzleEnabled = false;
    private float muzzleTimeStart;
    private float muzzleTimeDur = .05f;
    private float range = 10000f;


    private Ray shootRay;                                   // A ray from the gun end forwards.
    private RaycastHit shootHit;                            // A raycast hit to get information about what was hit
    private int shootableMask;


    void Start()
    {
        //flash = GameObject.Find("MuzzleFlash");
        flash.SetActive(false);
        //flash.gameObject.e = !flash.enabled;
        //sight = GameObject.Find("Muzzle");

        shootableMask = LayerMask.GetMask("Shootable");
    }

    // Update is called once per frame
    void Update()
    {

		if (Input.GetMouseButtonDown (0)) {
			shoot ();
		}
		if (_muzzleEnabled) {
			if (Time.time >= muzzleTimeDur + muzzleTimeStart) {
				flash.SetActive (!flash.activeSelf);
				_muzzleEnabled = false;
			}
		}
    }
	public void shoot() {
			if (!_muzzleEnabled) {
				flash.SetActive (!flash.activeSelf);
				_muzzleEnabled = true;
				muzzleTimeStart = Time.time;
			}

			shootRay.origin = sight.transform.position;
			shootRay.direction = sight.transform.forward;

			if (Physics.Raycast (shootRay, out shootHit, range, shootableMask)) {
				Transform enemy = shootHit.collider.GetComponent<Transform> ();

				Destroy (enemy.gameObject);
			}
		


	}
}
