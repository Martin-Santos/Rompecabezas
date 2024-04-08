
using UnityEngine;

public class parte : MonoBehaviour
{
    [SerializeField] float minX = -17;
    [SerializeField] float maxX = 17;
    [SerializeField] float minY = -8.5f;
    [SerializeField] float maxY = 8.5f;
    [SerializeField] float minRotation = 0f;
    [SerializeField] float maxRotation = 360f;
    [SerializeField] float margenError = 0.5f;
    Vector3 posicionCorrecta;

    private void Awake()
    {
        posicionCorrecta = transform.position;
    }
    void Start()
    {
        RandomizePosition();
    }

    void RandomizePosition()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        float randomRotation = Random.Range(minRotation, maxRotation);

        transform.position = new Vector3(randomX, randomY);
        transform.rotation = Quaternion.Euler(0f, 0f, randomRotation);
    }
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(posicionCorrecta, transform.position) < margenError) {
        transform.position = posicionCorrecta;
        }
    }
}
