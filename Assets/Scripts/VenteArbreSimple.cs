using UnityEngine;

public class VentArbreSimple : MonoBehaviour
{
    [SerializeField] private Transform couronne;
    [SerializeField] private float force = 2f;
    [SerializeField] private float vitesse = 1.5f;
    [SerializeField] private float decalageAleatoire = 2f;

    private Quaternion rotationInitiale;
    private float phase;

    private void Start()
    {
        rotationInitiale = couronne.localRotation;
        phase = Random.Range(0f, decalageAleatoire);
    }

    private void Update()
    {
        float oscillation = Mathf.Sin((Time.time + phase) * vitesse);
        float angleZ = oscillation * force;
        Quaternion mouvement = Quaternion.Euler(0f, 0f, angleZ);
        couronne.localRotation = rotationInitiale * mouvement;
    }
}