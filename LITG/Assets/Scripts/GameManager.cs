using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Button[] Animations;
    public GameObject player;
    public Weapon[] Weapons;
    private Animator playerAnimator;
    private string currentAnimation;

    private bool loadedWeapons = false;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        foreach(Button btn in Animations)
        {
            btn.onClick.AddListener(delegate { SwitchAnimation(btn.gameObject.name); });
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null) player = GameObject.Find("ely_k_atienza");
        playerAnimator = player.GetComponent<Animator>();
        if (currentAnimation != null && !playerAnimator.GetCurrentAnimatorStateInfo(0).IsName(currentAnimation))
        {
            playerAnimator.Play(currentAnimation);
        }

        Scene current = SceneManager.GetActiveScene();
        if(current.name == "Weapons")
        {
            LoadWeapons();
        }
    }
    void LoadWeapons()
    {
        for(int i = 0;i <Weapons.Length && !loadedWeapons; i++)
        {
            Weapon current = Weapons[i];
            if(current != null)
            {
                GameObject pos = GameObject.Find(i.ToString());
                GameObject model = Instantiate(current.WeaponModel, pos.transform.position, Quaternion.identity);
                model.GetComponent<WeaponBehaviour>().ShowName(current.weaponName);
            }
        }
        loadedWeapons = true;
    }

    public void SwitchAnimation(string animName)
    {
        playerAnimator.Play(animName);
        currentAnimation = animName;
    }
     public void LoadScene()
    {
        SceneManager.LoadScene("Weapons");
    }

    public string GetCurrentAnimation()
    {
        return currentAnimation;
    }
}
