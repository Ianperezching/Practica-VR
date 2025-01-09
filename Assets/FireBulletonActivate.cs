using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBulletonActivate : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnpoint;
    public float fireSpeed = 20;
    void Start()
    {
        XRGrabInteractable Grabbable = GetComponent<XRGrabInteractable>();
        Grabbable.activated.AddListener(FireBullet);
    }

    public void FireBullet(ActivateEventArgs arg)
    {
        GameObject SpawnedBullet = Instantiate(bullet);
        SpawnedBullet.transform.position = spawnpoint.position;
        SpawnedBullet.GetComponent<Rigidbody>().velocity = spawnpoint.forward * fireSpeed;
        Destroy(SpawnedBullet, 5);
    }
}
