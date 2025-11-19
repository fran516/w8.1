using UnityEngine;

public class PerlinNoise : MonoBehaviour
{
    public float minIntensity = 0.5f;
    public float maxIntensity = 2.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Light>().intensity = Mathf.PerlinNoise(Random.Range(minIntensity, maxIntensity),1f);
    }
}
