using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] protected float speed;
    [SerializeField] protected Rigidbody player;
    [SerializeField] protected GameObject spawnBrick;
    [SerializeField] protected GameObject spawnPosition;
    [SerializeField] protected LayerMask bridgeLayer;
    [SerializeField] protected GameObject bridgeBrick;

    public int n;
    public List<GameObject> EatBrick = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        n = Random.RandomRange(0, 3);
        Renderer renderer = GetComponent<Renderer>();
        if (n == 0)
        {
            renderer.material.color = Color.green;
        }
        if (n == 1)
        {
            renderer.material.color = Color.blue;
        }
        if (n == 2)
        {
            renderer.material.color = Color.red;
        }
    }

    // Update is called once per frame
    void Update()
    {
        spawnPosition.transform.localPosition = new Vector3(0,
                                                               spawnPosition.transform.localPosition.y, -0.85f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Spawn Brick")
        {
            Material material1 = transform.GetComponent<Renderer>().material;
            Material material2 = other.GetComponent<Renderer>().material;
            Color color1 = material1.color;
            Color color2 = material2.color;
            if (color1.Equals(color2))
            {
                Destroy(other.gameObject);
                Debug.Log("Instantiate");
                GameObject temp = Instantiate(spawnBrick, spawnPosition.transform.position, transform.rotation, transform);
                EatBrick.Add(temp);
                Material material = temp.GetComponent<Renderer>().material;
                material.color = transform.GetComponent<Renderer>().material.color;
                spawnPosition.transform.localPosition = new Vector3(0,
                                                                    spawnPosition.transform.localPosition.y, -0.85f);

                spawnPosition.transform.position += Vector3.up * 0.201f;
                spawnPosition.transform.localPosition = new Vector3(0,
                                                                    spawnPosition.transform.localPosition.y, -0.85f);
            }
        }
    }

    public void RemoveBrick()
    {
        Destroy(EatBrick[EatBrick.Count - 1]);
        EatBrick.Remove(EatBrick[EatBrick.Count - 1]);
        spawnPosition.transform.position += Vector3.down * 0.201f;
    }
}
