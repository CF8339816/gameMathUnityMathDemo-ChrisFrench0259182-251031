using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class mathDemo : MonoBehaviour
{
    [Header("Chest Type")]
    [SerializeField] int Wood_Chest = 0;
    [SerializeField] int Bronze_Chest = 0;
    [SerializeField] int Silver_Chest = 0;
    [SerializeField] int Gold_Chest = 0;
    [SerializeField] int Platinum_Chest = 0;


    [Header("Wooden Chest")]
    [SerializeField] int Wood_Chest_Common = 0;
    [SerializeField] int Wood_Chest_Uncommon = 0;
    [SerializeField] int Wood_Chest_Rare = 0;
    [SerializeField] int Wood_Chest_Epic = 0;
    [SerializeField] int Wood_Chest_Legendary = 0;
    public TextMeshProUGUI LootWood;

    [Header("Bronze Chest")]
    [SerializeField] int Bronze_Chest_Common = 0;
    [SerializeField] int Bronze_Chest_Uncommon = 0;
    [SerializeField] int Bronze_Chest_Rare = 0;
    [SerializeField] int Bronze_Chest_Epic = 0;
    [SerializeField] int Bronze_Chest_Legendary = 0;
    public TextMeshProUGUI LootBronze;

    [Header("Silver Chest")]
    [SerializeField] int Silver_Chest_Common = 0;
    [SerializeField] int Silver_Chest_Uncommon = 0;
    [SerializeField] int Silver_Chest_Rare = 0;
    [SerializeField] int Silver_Chest_Epic = 0;
    [SerializeField] int Silver_Chest_Legendary = 0;
    public TextMeshProUGUI LootSilver;




    [Header("Gold Chest")]
    [SerializeField] int Gold_Chest_Common = 0;
    [SerializeField] int Gold_Chest_Uncommon = 0;
    [SerializeField] int Gold_Chest_Rare = 0;
    [SerializeField] int Gold_Chest_Epic = 0;
    [SerializeField] int Gold_Chest_Legendary = 0;
    public TextMeshProUGUI LootGold;


    [Header("Platinum Chest")]
    [SerializeField] int Platinum_Chest_Common = 0;
    [SerializeField] int Platinum_Chest_Uncommon = 0;
    [SerializeField] int Platinum_Chest_Rare = 0;
    [SerializeField] int Platinum_Chest_Epic = 0;
    [SerializeField] int Platinum_Chest_Legendary = 0;
    public TextMeshProUGUI LootPlatinum;

    //[SerializeField] int Platinum_Chest_Drops = Platinum.Count{0};

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
       
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LootRoll();
        }

    }


    //m0
    void LootRoll()
    {
        int Max = Wood_Chest + Bronze_Chest + Silver_Chest + Gold_Chest + Platinum_Chest;
        int whatChest = Random.Range(1, Max + 1);
        if (whatChest <= Platinum_Chest)
        {
            PlatinumLoot();
        }
        if (whatChest <= Gold_Chest)
        {
            GoldLoot();
        }
        if (whatChest <= Silver_Chest)
        {
           SilverLoot();
        }
        if (whatChest <= Bronze_Chest)
        {
            BronzeLoot();
        }
        if (whatChest <= Wood_Chest)
        {
            WoodenLoot();
        }

    }


    //m1
    void WoodenLoot()
    {

        int Max = Wood_Chest_Common + Wood_Chest_Uncommon + Wood_Chest_Rare + Wood_Chest_Epic + Wood_Chest_Legendary;
        int woodLoot = Random.Range(1, Max + 1);
        if (woodLoot <= Wood_Chest_Legendary)
        {
            LootWood.text = "Wooden Chest, Legendary Loot";
        }
        if (woodLoot <= Wood_Chest_Epic)
        {
            LootWood.text = "Wooden Chest, Epic Loot";
        }
        if (woodLoot <= Wood_Chest_Rare)
        {
            LootWood.text = "Wooden Chest, Rare Loot";
        }
        if (woodLoot <= Wood_Chest_Uncommon)
        {
            LootWood.text = "Wooden Chest, Uncommon Loot";
        }
        if (woodLoot <= Wood_Chest_Common)
        {
            LootWood.text = "Wooden Chest, Common Loot";
        }

    }


    //m2
    void BronzeLoot()
    {
        int Max = Bronze_Chest_Common + Bronze_Chest_Uncommon + Bronze_Chest_Rare + Bronze_Chest_Epic + Bronze_Chest_Legendary;
        int bronzeLoot = Random.Range(1, Max +1);
        if (bronzeLoot <= Bronze_Chest_Legendary)
        {
            LootBronze.text = "Bronze Chest, Legendary Loot";
        }
        if (bronzeLoot <= Bronze_Chest_Epic)
        {
            LootBronze.text = "Bronze Chest, Epic Loot";
        }
        if (bronzeLoot <= Bronze_Chest_Rare)
        {
            LootBronze.text = "Bronze Chest, Rare Loot";
        }
        if (bronzeLoot <= Bronze_Chest_Uncommon)
        {
            LootBronze.text = "Bronze Chest, Uncommon Loot";
        }
        if (bronzeLoot <= Bronze_Chest_Common)
        {
            LootBronze.text = "Bronze Chest, Common Loot";
        }

    }

    //m3
    void SilverLoot()
    {
        int Max = Silver_Chest_Common + Silver_Chest_Uncommon + Silver_Chest_Rare + Silver_Chest_Epic + Silver_Chest_Legendary;
        int silverLoot = Random.Range(1, Max + 1);
        if (silverLoot <= Silver_Chest_Legendary)
        {
            LootSilver.text = "Legendary Loot";
        }
        if (silverLoot <= Silver_Chest_Epic)
        {
            LootSilver.text = "Epic Loot";
        }
        if (silverLoot <= Silver_Chest_Rare)
        {
            LootSilver.text = "Rare Loot";
        }
        if (silverLoot <= Silver_Chest_Uncommon)
        {
            LootSilver.text = "Uncommon Loot";
        }
        if (silverLoot <= Silver_Chest_Common)
        {
            LootSilver.text = "Common Loot";
        }

    }

    //m4
    void GoldLoot()
    {
        int Max = Gold_Chest_Common + Gold_Chest_Uncommon + Gold_Chest_Rare + Gold_Chest_Epic + Gold_Chest_Legendary;
        int goldLoot = Random.Range(1, Max + 1);
        if (goldLoot <= Gold_Chest_Legendary)
        {
            LootGold.text = "Legendary Loot";
        }
        if (goldLoot <= Gold_Chest_Epic)
        {
            LootGold.text = "Epic Loot";
        }
        if (goldLoot <= Gold_Chest_Rare)
        {
            LootGold.text = "Rare Loot";
        }
        if (goldLoot <= Gold_Chest_Uncommon)
        {
            LootGold.text = "Uncommon Loot";
        }
        if (goldLoot <= Gold_Chest_Common)
        {
            LootGold.text = "Common Loot";
        }

    }

    //m5 
    void PlatinumLoot()
    {
        int Max = Platinum_Chest_Common + Platinum_Chest_Uncommon + Platinum_Chest_Rare + Platinum_Chest_Epic + Platinum_Chest_Legendary;
        int platinumLoot = Random.Range(1, Max + 1);
        if (platinumLoot <= Platinum_Chest_Legendary)
        {
            LootPlatinum.text = "Legendary Loot";
        }
        if (platinumLoot <= Platinum_Chest_Epic)
        {
            LootPlatinum.text = "Epic Loot";
        }
        if (platinumLoot <= Platinum_Chest_Rare)
        {
            LootPlatinum.text = "Rare Loot";
        }
        if (platinumLoot <= Platinum_Chest_Uncommon)
        {
            LootPlatinum.text = "Uncommon Loot";
        }
        if (platinumLoot <= Platinum_Chest_Common)
        {
            LootPlatinum.text = "Common Loot";
        }

    }

}
