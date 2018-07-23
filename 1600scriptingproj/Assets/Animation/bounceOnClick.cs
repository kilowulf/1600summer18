using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounceOnClick : MonoBehaviour {


    private Animator anims;
    public IntData CoinCollection;

	// Use this for initialization
	private void Start () {
        anims = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	private void OnMouseDown () {
        anims.SetTrigger("canBounce");
	}

    private void OnTriggerEnter(Collider other)
    {
        anims.SetTrigger("canBounce");
    }

    public void EndAnims()
    {
        // turns off mesh to make sphere disappear but still be able to see particle explosion
        GetComponent<MeshRenderer>().enabled = false;
        // turns off collider for no more collisions
        GetComponent<SphereCollider>().enabled = false;
        // will emit particles on collision
        GetComponent<ParticleSystem>().Emit(20);
        // add to a coin collection 
        CoinCollection.Value++;
    }


}
