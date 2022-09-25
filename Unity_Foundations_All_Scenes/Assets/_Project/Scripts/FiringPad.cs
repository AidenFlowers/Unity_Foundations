using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class FiringPad : MonoBehaviour
    {
        public GameObject projectilePrefab;
        public Transform spawnpoint;
        public float projectileForce;



        private void OnTriggerEnter(Collider other)
        {

            if (other.gameObject.CompareTag("Player"))
            {
                //Debug.Log("Player triggered this firing pad.");
                GameObject spawnedProjectile = Instantiate(projectilePrefab, spawnpoint.position, spawnpoint.rotation);
                spawnedProjectile.GetComponent<Rigidbody>().AddForce(spawnedProjectile.transform.forward * projectileForce, ForceMode.VelocityChange);
            }


        }


    }
