using UnityEngine;

public class W4Pigeon : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;
    [SerializeField] private Animator _animator;

    // REMOVE these references to other objects!
    // we're going to alert them via EVENT instead!!


    // HERE, add an event to tell other objects that the pigeon coo'd!
    public delegate void Delegate();
    public event Delegate Cooed;

    // don't change the code in this method!
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Coo();
        }
    }

    private void Coo()
    {

        Debug.Log("squack!");
        Cooed?.Invoke();

        // do pigeon stuff
        _audio.Play();
        _animator.SetTrigger("wiggle");

        // HERE, you'll want to REMOVE the code to "tell seagulls", "tell UI", and "tell VFX"
        // instead, fire your coo event!

    }
}
