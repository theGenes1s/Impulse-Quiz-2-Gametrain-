using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public float shootSpeed;
    public float shootTimer;
    private bool isShooting;
    public Transform shootPosition;
    public GameObject arc;

    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        isShooting = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) &&  !isShooting)
        {
            //Attacking
            StartCoroutine(Shoot());

        }
    }

    IEnumerator Shoot()
    {
        isShooting=true;
        GameObject newArc =Instantiate(arc, shootPosition.position ,Quaternion.identity);
        newArc.GetComponent<Rigidbody2D>().velocity = new Vector2 (shootSpeed * Time.fixedDeltaTime , 0f);
        yield return new WaitForSeconds(shootTimer);
        isShooting=false;
    }
}
