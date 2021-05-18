using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FishConsume : MonoBehaviour
{
    public Animator animator;

    [SerializeField] private int TotalFish = 20;
    [SerializeField] public int CollectedF = 1;

    [SerializeField] private TMP_Text totalFtext;
    [SerializeField] private TMP_Text collect_text;

    public AudioSource collect;
    private void Update()
    {
        totalFtext.text = TotalFish.ToString();
        collect_text.text = CollectedF.ToString();

        if (CollectedF >= 20)
        {
            //Winscene.SetActive(true);
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Consumable"))
        {
            animator.SetInteger("AnimState", 3);
            Destroy(other.gameObject);
            CollectedF += 1;
            collect.Play();
        }
    }
}
