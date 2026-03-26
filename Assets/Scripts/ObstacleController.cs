using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public BoxCollider Collider;


    public int ValorNecesarioParaSubir = 5;

    public int CantidadASubir;

    public bool Subio;





    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Player ha entrado en el trigger");

            int ValorRandom = Random.Range(0, 11);

            Debug.Log(ValorRandom);




            if( ValorRandom >= ValorNecesarioParaSubir && Subio == false)
            {
                obstaclePrefab.transform.position = new Vector3(transform.position.x, transform.position.y + CantidadASubir, transform.position.z);

                Subio = true; 

            }

                    




        }

    }
}
