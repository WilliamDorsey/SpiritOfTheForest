using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeedThrower : MonoBehaviour
{
    public Camera cam;
    public GameObject acornProj;
    public GameObject growProj;
    public GameObject hurtProj;
    public Text ammoText;
    public float projectileSpeed = 30;
    public float fireRate = 4;

    public int ammoAcorn = 10;
    public int ammoGrow = 10;
    public int ammoHurt = 10;

    private int numWeapons = 3;
    private int currentWeapon = 1;
    private GameObject projectile;
    private Vector3 destination;
    public Transform shootOffset;
    private float timeToFire;
    
    private string acornText;
    private string growText;
    private string hurtText;


    private void Start()
    {
        currentWeapon = 1;
        UpdateWeapons();
    }

    void Update()
    {
        //Get input to select weapon
        var scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll > 0f || Input.GetButtonDown("LB"))
        {
            currentWeapon--;
            if (currentWeapon < 1)
                currentWeapon = numWeapons;
            UpdateWeapons();
        }
        if (scroll < 0f || Input.GetButtonDown("RB"))
        {
            currentWeapon++;
            if (currentWeapon > numWeapons)
                currentWeapon = 1;
            UpdateWeapons();
        }

        if (Input.GetKey("1"))
        {
            currentWeapon = 1;
            UpdateWeapons();
        }
        if (Input.GetKey("2"))
        {
            currentWeapon = 2;
            UpdateWeapons();
        }
        if (Input.GetKey("3"))
        {
            currentWeapon = 3;
            UpdateWeapons();
        }

        //Get input to shoot
        if ((Input.GetButton("Fire1") || Mathf.Round(Input.GetAxisRaw("Fire1")) > 0) && Time.time >= timeToFire && CurrentWeaponAmmo() > 0)
        {
            timeToFire = Time.time + 1/fireRate;
            SubtractCurrentAmmo();
            ShootProjectile();
            UpdateWeapons();
        }
    }

    void ShootProjectile()
    {
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
            destination = hit.point;
        else
            destination = ray.GetPoint(1000);

        InstantiateProjectile();
    }

    void InstantiateProjectile()
    {
        var projectileObj = Instantiate(projectile, shootOffset.transform.position, Random.rotation) as GameObject;
        projectileObj.GetComponent<Rigidbody>().velocity = cam.transform.forward * projectileSpeed;
    }

    public void UpdateWeapons() //Set current weapon and update HUD
    {
        acornText = "<color=grey>Acorns: " + ammoAcorn + "</color>";
        growText = "<color=grey>Tree Seeds " + ammoGrow + "</color>";
        hurtText = "<color=grey>Mushroom seeds " + ammoHurt + "</color>";

        if (currentWeapon == 1)
        {
            projectile = acornProj;
            if (ammoAcorn > 0)
                acornText = "<color=cyan><b>Acorns: " + ammoAcorn + "</b></color>";
            else
                acornText = "<color=black><b>Acorns: " + ammoAcorn + "</b></color>";
        }
        else if (currentWeapon == 2)
        {
            projectile = growProj;
            if (ammoGrow > 0)
                growText = "<color=green><b>Tree seeds: " + ammoGrow + "</b></color>";
            else
                growText = "<color=black><b>Tree seeds: " + ammoGrow + "</b></color>";
        }
        else if (currentWeapon == 3)
        {
            projectile = hurtProj;
            if (ammoHurt > 0)
                hurtText = "<color=purple><b>Mushroom seeds: " + ammoHurt + "</b></color>";
            else
                hurtText = "<color=black><b>Mushroom seeds: " + ammoHurt + "</b></color>";
        }

        ammoText.text = acornText + " | " + growText + " | " + hurtText;
    }

    int CurrentWeaponAmmo() //Get ammo value of current weapon
    {
        if (currentWeapon == 1)
        {
            return ammoAcorn;
        }
        else if (currentWeapon == 2)
        {
            return ammoGrow;
        }
        else if (currentWeapon == 3)
        {
            return ammoHurt;
        }
        else return 0;
    }

    void SubtractCurrentAmmo() //Update ammo values after shooting
    {
        if (currentWeapon == 1)
        {
            ammoAcorn--;
        }
        else if (currentWeapon == 2)
        {
            ammoGrow--;
        }
        else if (currentWeapon == 3)
        {
            ammoHurt--;
        }
    }
}
