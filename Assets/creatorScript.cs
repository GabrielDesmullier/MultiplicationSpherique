using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creatorScript : MonoBehaviour
{

    [SerializeField] private GameObject prefab;
    private int numberOfObjects;
    [SerializeField] private int newNumberOfObjects;
    [SerializeField] private int radius;
    private float angle=0;
    [SerializeField] private float pas = 60;
    private float decalage = 0;



    // Start is called before the first frame update
    void Start()
    {
        this.numberOfObjects = this.newNumberOfObjects;
        for(int count = 0; count < this.numberOfObjects-1; count++)
        {
            //int variable = Random.Range(0, 360);
            this.angle = this.angle +this.pas;
            Instantiate(prefab,position: new Vector3(transform.position.x+this.radius*Mathf.Cos(Mathf.Deg2Rad*this.angle), transform.position.y+this.radius*Mathf.Sin(Mathf.Deg2Rad * this.angle), transform.position.z), Quaternion.identity, transform);
            if (this.angle >= 360)
            {
                this.decalage=this.decalage+2;
                this.angle = this.pas / this.decalage ;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.newNumberOfObjects > this.numberOfObjects)
        {
            for (int count=0; count < (this.newNumberOfObjects - this.numberOfObjects); count++)
            {

                //int variable = Random.Range(0, 360);
                this.angle = this.angle + this.pas;
                Instantiate(prefab, position: new Vector3(transform.position.x + this.radius * Mathf.Cos(Mathf.Deg2Rad * this.angle), transform.position.y + this.radius * Mathf.Sin(Mathf.Deg2Rad * this.angle), transform.position.z), Quaternion.identity, transform);
                if (this.angle >= 360)
                {
                    this.decalage = this.decalage + 2;
                    this.angle = this.pas / this.decalage;
                }
            }
            this.numberOfObjects = this.newNumberOfObjects;
        }
    }
}
