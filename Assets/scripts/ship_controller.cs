using UnityEngine;

public class ship_controller : MonoBehaviour {

    private Rigidbody rb;
    private int position = 2;
    public Vector2 aPosition0;
    public Vector2 aPosition1;
    public Vector2 aPosition2;
    public Vector2 aPosition3;
    public Vector2 aPosition4;
    public GameObject explosion_anim;
    public AudioClip explosion_sound;
	public AudioClip coin_sound;
    public new AudioSource audio;
    public Canvas canvas;
    public GameObject restart;

    // Use this for initialization
    void OnEnable () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Application.platform == RuntimePlatform.Android)
        { 
            Debug.Log("Do something special here!");
            rail_controller_android();
        }
        else
        {
            rail_controller();
        }
        rail_mover();
        wobble();
        make_explosion();
	}
    
    void rail_controller_android()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.position.x < Screen.width / 2 && position > 0 && touch.phase == TouchPhase.Began)
            {
                position -= 1;
            }
            else if (touch.position.x > Screen.width / 2 && position < 4 && touch.phase == TouchPhase.Began)
            {
                position += 1;
            }
        }
    }

    void rail_controller()
    {
        if (Input.GetKeyDown("left") && position > 0)
        {
            position -= 1;
        }
        if (Input.GetKeyDown("right") && position < 4)
        {
            position += 1;
        }
    }
    void rail_mover()
    {
        if (position == 4)
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), aPosition4, 5 * Time.deltaTime);
        }
        if (position == 3)
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), aPosition3, 5 * Time.deltaTime);
        }
        if (position == 2)
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), aPosition2, 5 * Time.deltaTime);
        }
        if (position == 1)
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), aPosition1, 5 * Time.deltaTime);
        }
        if (position == 0)
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), aPosition0, 5 * Time.deltaTime);
        }
    }

    void wobble()
    {
        //transform.rotation = Quaternion.Euler(Random.Range(-2.0f, 2.0f), Random.Range(-5.0f, 5.0f), 0);
    }

    void make_explosion()
    {
        if (Input.GetKeyDown("t"))
        {
            Debug.Log("explosion");
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        //score_manager score = new score_manager();
        if (coll.gameObject.name.Contains("asteroid") == true)
        {
            Debug.Log("Collision");
            Destroy(coll.gameObject);
            GameObject.Instantiate(explosion_anim, transform.position, transform.rotation);
            audio.PlayOneShot(explosion_sound);
            SpriteRenderer renderer = this.GetComponent<SpriteRenderer>();
            BoxCollider2D boxcollider = this.GetComponent<BoxCollider2D>();
            gameObject.SetActive(true);
            renderer.enabled = false;
			boxcollider.enabled = false;
			foreach( Transform child in canvas.transform )
			{
				child.gameObject.SetActive (true);
			}
			Destroy (this.gameObject);
        }
        if (coll.gameObject.name.Contains("scoreup") == true)
        {
			Destroy (coll.gameObject);
            Debug.Log("increase score");
			audio.PlayOneShot(coin_sound);
			score_manager.score += 1;
        }
        
    }
}