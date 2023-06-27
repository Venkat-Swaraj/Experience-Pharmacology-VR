using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject lash;
    public AudioSource _AudioSource;
    public void When_clicked()
    {
        _AudioSource.Play();
        Destroy(lash);
    }
}
