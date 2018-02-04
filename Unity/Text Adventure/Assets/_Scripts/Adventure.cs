using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Adventure : MonoBehaviour
{

    public enum Location { weaponshop, inn, church, castle, magicshop, commons, fountain, generalgoods, townentrance, guild, arena, residentdistrict, farmer, farmeryes, farmerno,
        blacksmith, boughtss, boughtsms, boughtbs, boughtls, error1, error2, error3, error4, vendor, townsman, merchant, shp, lhp, wizard, apprentice, robes, guard, guildmaster, trader,
        sell, sellsms, sellss, sellboots, sellshp, selllhp, receptionist, receptionist2, knight, attendee, mercenary, woman, buisnessman, arenastart, arenadecline, arenaint, arenafight1,
        win1, win2, win3, win4, status1, status2, status3, status4, statusupdate1, statusupdate2, useitem, arenafight2, arenafight3, arenafight4, farmhand, lose}
    public Location myLocation;
    public int boots = 0;
    public int shortsword = 0;
    public int smallshield = 0;
    public int robes = 0;
    public int smallhealthpotion = 0;
    public int largehealthpotion = 0;
    public int g = 300;
    public int hp = 10;
    public int ht = 3;
    public int hw = 7;
    public int hm = 10;
    public int hk = 15;
    public int a = 0;
    public int b = 0;
    public int c = 0;
    public int d = 0;
    public Text textObject;
    public Text titleObject;
    public Text text2Object;

	// Use this for initialization
	void Start ()
    {
        myLocation = Location.townentrance;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (myLocation == Location.townentrance)
        {
            Townentrance();
        }
        else if (myLocation == Location.fountain)
        {
            Fountain();
        }
        else if (myLocation == Location.commons)
        {
            Commons();
        }
        else if (myLocation == Location.inn)
        {
            Inn();
        }
        else if (myLocation == Location.weaponshop)
        {
            Weaponshop();
        }
        else if (myLocation == Location.generalgoods)
        {
            Generalgoods();
        }
        else if (myLocation == Location.farmer)
        {
            Farmer();
        }
        else if (myLocation == Location.farmeryes)
        {
            Farmeryes();
        }
        else if (myLocation == Location.farmerno)
        {
            Farmerno();
        }
        else if (myLocation == Location.blacksmith)
        {
            Blacksmith();
        }
        else if (myLocation == Location.boughtss)
        {
            Boughtss();
        }
        else if (myLocation == Location.boughtsms)
        {
            Boughtsms();
        }
        else if (myLocation == Location.boughtbs)
        {
            Boughtbs();
        }
        else if (myLocation == Location.boughtls)
        {
            Boughtls();
        }
        else if (myLocation == Location.error1)
        {
            Error1();
        }
        else if (myLocation == Location.vendor)
        {
            Vendor();
        }
        else if (myLocation == Location.townsman)
        {
            Townsman();
        }
        else if (myLocation == Location.merchant)
        {
            Merchant();
        }
        else if (myLocation == Location.shp)
        {
            Shp();
        }
        else if (myLocation == Location.lhp)
        {
            Lhp();
        }
        else if (myLocation == Location.error2)
        {
            Error2();
        }
        else if (myLocation == Location.magicshop)
        {
            Magicshop();
        }
        else if (myLocation == Location.wizard)
        {
            Wizard();
        }
        else if (myLocation == Location.apprentice)
        {
            Apprentice();
        }
        else if (myLocation == Location.robes)
        {
            Robes();
        }
        else if (myLocation == Location.error3)
        {
            Error3();
        }
        else if (myLocation == Location.guard)
        {
            Guard();
        }
        else if (myLocation == Location.guild)
        {
            Guild();
        }
        else if (myLocation == Location.guildmaster)
        {
            Guildmaster();
        }
        else if (myLocation == Location.trader)
        {
            Trader();
        }
        else if (myLocation == Location.sell)
        {
            Sell();
        }
        else if (myLocation == Location.sellsms)
        {
            Sellsms();
        }
        else if (myLocation == Location.sellss)
        {
            Sellss();
        }
        else if (myLocation == Location.sellboots)
        {
            Sellboots();
        }
        else if (myLocation == Location.sellshp)
        {
            Sellshp();
        }
        else if (myLocation == Location.selllhp)
        {
            Selllhp();
        }
        else if (myLocation == Location.error4)
        {
            Error4();
        }
        else if (myLocation == Location.mercenary)
        {
            Mercenary();
        }
        else if (myLocation == Location.receptionist)
        {
            Receptionist();
        }
        else if (myLocation == Location.residentdistrict)
        {
            Residentdistrict();
        }
        else if (myLocation == Location.woman)
        {
            Woman();
        }
        else if (myLocation == Location.buisnessman)
        {
            Buisnessman();
        }
        else if (myLocation == Location.arena)
        {
            Arena();
        }
        else if (myLocation == Location.receptionist2)
        {
            Receptionist2();
        }
        else if (myLocation == Location.knight)
        {
            Knight();
        }
        else if (myLocation == Location.attendee)
        {
            Attendee();
        }
        else if (myLocation == Location.arenastart)
        {
            Arenastart();
        }
        else if (myLocation == Location.arenadecline)
        {
            Arenadecline();
        }
        else if (myLocation == Location.arenaint)
        {
            Arenaint();
        }
        else if (myLocation == Location.arenafight1)
        {
            Arenafight1();
        }
        else if (myLocation == Location.arenafight2)
        {
            Arenafight2();
        }
        else if (myLocation == Location.win1)
        {
            Win1();
        }
        else if (myLocation == Location.win2)
        {
            Win2();
        }
        else if (myLocation == Location.win3)
        {
            Win3();
        }
        else if (myLocation == Location.status1)
        {
            Status1();
        }
        else if (myLocation == Location.useitem)
        {
            Useitem();
        }
        else if (myLocation == Location.status2)
        {
            Status2();
        }
        else if (myLocation == Location.statusupdate1)
        {
            Statusupdate1();
        }
        else if (myLocation == Location.statusupdate2)
        {
            Statusupdate2();
        }
        else if (myLocation == Location.status3)
        {
            Status3();
        }
        else if (myLocation == Location.arenafight3)
        {
            Arenafight3();
        }
        else if (myLocation == Location.arenafight4)
        {
            Arenafight4();
        }
        else if (myLocation == Location.status4)
        {
            Status4();
        }
        else if (myLocation == Location.farmhand)
        {
            Farmhand();
        }
        else if (myLocation == Location.lose)
        {
            Lose();
        }
        else if (myLocation == Location.win4)
        {
            Win4();
        }
        else
        {
            print("Error");
        }
	}

    private void Townentrance()
    {
        print("Arrived at the Town Entrance. \n" +
            "Talk to the Guard? (T)" +
            "Move to the Fountain? (F)" +
            "Move to the Commons? (C)" +
            "Move to the Inn? (I)" );
        textObject.text = "Arrived at the Town Entrance. \n"  +
            "Talk to the Guard? (T) \n" +
            "Move to the Fountain? (F) \n" +
            "Move to the Commons? (C) \n" +
            "Move to the Inn? (I) \n" +
            "Quit (Q)";
        if (Input.GetKeyDown(KeyCode.F))
        {
            myLocation = Location.fountain;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            myLocation = Location.commons;
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            myLocation = Location.inn;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            myLocation = Location.guard;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }

    private void Guard()
    {
        print("Welcome to our humble town. \n" +
                "Try to stay out of trouble.");
        textObject.text = "Welcome to our humble town. \n" +
            "Try to stay out of trouble. \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.townentrance;
        }
    }

    private void Fountain()
    {
        print("Arrived at the Fountain. " +
            "Talk to Stall Vendor? (T) " +
            "Talk to Townsman? (Y)" +
            "Move to the Weapons Shop? (W)" +
            "Move to the General Goods Store? (S)" +
            "Move to the Magic Shop? (M)" +
            "Move to the Guild? (G)" +
            "Move to the Residential District? (R)" +
            "Move to the Town Entrance? (E)");
        textObject.text = "Arrived at the Fountain. \n" +
            "Talk to Stall Vendor? (T) \n" +
            "Talk to Townsman? (Y) \n" +
            "Move to the Weapons Shop? (W) \n" +
            "Move to the General Goods Store? (S) \n" +
            "Move to the Magic Shop? (M) \n" +
            "Move to the Guild? (G) \n" +
            "Move to the Residential District? (D) \n" +
            "Move to the Town Entrance? (E)";
        if (Input.GetKeyDown(KeyCode.T))
        {
            myLocation = Location.vendor;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {            
            myLocation = Location.townsman;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            myLocation = Location.weaponshop;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            myLocation = Location.generalgoods;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            myLocation = Location.magicshop;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            myLocation = Location.guild;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            myLocation = Location.residentdistrict;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            myLocation = Location.townentrance;
        }
    }

    private void Residentdistrict()
    {
        textObject.text = "Arrived at the Residential Discrict. \n" +
            "Talk to the Elegant Woman? (T) \n" +
            "Talk to the Buisnessman? (Y) \n" +
            "Move to the Fountain? (F) \n" +
            "Move to the Commons? (C) \n" +
            "Move to the Arena? (A)";
        if (Input.GetKeyDown(KeyCode.T))
        {
            myLocation = Location.woman;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            myLocation = Location.buisnessman;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            myLocation = Location.fountain;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            myLocation = Location.commons;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            myLocation = Location.arena;
        }
    }

    private void Woman()
    {
        textObject.text = "Excuse me but I don't socialize with commoners. \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.residentdistrict;
        }
    }

    private void Buisnessman()
    {
        textObject.text = "I haven't had a day off in weeks, so if you don't mind I would prefer to be left alone. \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.residentdistrict;
        }
    }

    private void Arena()
    {
        textObject.text = "Arrived at the Arena. \n" +
            "Talk to the Receptionist? (T) \n" +
            "Talk to the Knight? (Y) \n" +
            "Talk to the Attendee? (U) \n" +
            "Move to the Residential District? (D)";
        if (Input.GetKeyDown(KeyCode.T))
        {
            myLocation = Location.receptionist2;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            myLocation = Location.knight;
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            myLocation = Location.attendee;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            myLocation = Location.residentdistrict;
        }
    }

    private void Receptionist2()
    {
        textObject.text = "Welcome! Would you like to participate in the tournament? (Y)/(N)";
        if (Input.GetKeyDown(KeyCode.Y))
        {
            myLocation = Location.arenastart;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            myLocation = Location.arenadecline;
        }
    }

    private void Knight()
    {
        textObject.text = "I swear on my honor I will win this tournament. \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.arena;
        }
    }

    private void Attendee()
    {
        textObject.text = "I'm so excited! I've never been to a tournament before. \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.arena;
        }
    }

    private void Arenastart()
    {
        textObject.text = "Excellent! When you're ready right this way, please.  \n" +
            "Enter the Arena (E)";
        if (Input.GetKeyDown(KeyCode.E))
        {
            myLocation = Location.arenaint;
        }
    }

    private void Arenaint()
    {
        textObject.text = "Ladies & Gentlemen! Welcome to the 22nd Anneversery of the King's Tournament! \n" +
            "Contestents, are you ready? \n" +
            "Ready (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.arenafight1;
        }
    }

    private void Arenadecline()
    {
        textObject.text = "Have a nice evening. \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.arena;
        }
    }

    private void Vendor()
    {
        print("Hello! Would you like to buy some cabbages?");
        textObject.text = "Hello! Would you like to buy some cabbages? \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.fountain;
        }
    }

    private void Townsman()
    {
        print("Just got into town? The inn's the other way.");
        textObject.text = "Just got into town? The inn's the other way. \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.fountain;
        }
    }

    private void Commons()
    {
        print("Arrived at the Commons. " +
            "Talk to the Farmer? (T)" +
            "Talk to the Farmhand? (Y)" +
            "Move to the Town Entrance? (E) " +
            "Move to the Residential District? (R)");
        textObject.text = "Arrived at the Commons. \n" +
            "Talk to the Farmer? (T) \n" +
            "Talk to the Farmhand? (Y) \n" +
            "Move to the Town Entrance? (E) \n" +
            "Move to the Residential District? (R)";
        if (Input.GetKeyDown(KeyCode.T))
        {            
            myLocation = Location.farmer;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            //print("Got time to talk ya got time to work.");
            //textObject.text = "Got time to talk ya got time to work.";
            myLocation = Location.farmhand;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            myLocation = Location.townentrance;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.residentdistrict;
        }
    }

    private void Inn()
    {
        textObject.text = "Arrived at the Inn. \n" +
            "Talk to the Receptionist? (T) \n" +
            "Talk to the Mercenary? (Y) \n" +
            "Move to the Town Entrance? (E)";
        if (Input.GetKeyDown(KeyCode.T))
        {
            myLocation = Location.receptionist;
            //textObject.text = "Sorry but all rooms are booked for the evening.";
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            myLocation = Location.mercenary;
            /*textObject.text = "Here to participate in the tournament today? \n" +
                "You might want to visit the shops before heading to the arena.";*/
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            myLocation = Location.townentrance;
        }
    }

    private void Receptionist()
    {
        textObject.text = "Sorry but all rooms are booked for the evening. \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.inn;
        }
    }

    private void Mercenary()
    {
        textObject.text = textObject.text = "Here to participate in the tournament today? \n" +
            "You might want to visit the shops before heading to the arena. \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.inn;
        }
    }

    private void Weaponshop()
    {
        textObject.text = "Arrived at the Weapons Shop. \n" +
            "Talk to the Blacksmith? (T) \n" +
            "Move to the Fountain? (F)";
        if (Input.GetKeyDown(KeyCode.T))
        {
            myLocation = Location.blacksmith;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            myLocation = Location.fountain;
        }
    }

    private void Blacksmith()
    {
        textObject.text = "Welcome! Please take a look. \n" +
                "Gold = " + g + "\n" +
                "Short Sword - 100g (Z) \n" +
                "Small Shield - 100g (X) \n" +
                "Broad Sword - 400g (C) \n" +
                "Large Shield - 350g (V) \n" +
                "Return (R)";
        if (Input.GetKeyDown(KeyCode.Z))
        {
            myLocation = Location.boughtss;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            myLocation = Location.boughtsms;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            myLocation = Location.boughtbs;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            myLocation = Location.boughtls;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.weaponshop;
        }
    }

    private void Boughtss()
    {        
        if (g >= 100)
        {
            print("Gained 'Short Sword' \n" +
            "Return (R)");
            textObject.text = "Gained 'Short Sword' \n" +
            "Return (R)";            
            if (Input.GetKeyDown(KeyCode.R))
            {
                shortsword++;
                g = g - 100;
                myLocation = Location.blacksmith;
            }
        }
        else if(g < 100)
        {
            myLocation = Location.error1;
        }
    }

    private void Boughtsms()
    {        
        if (g >= 100)
        {
            textObject.text = "Gained 'Small Shield' \n" +
            "Return (R)";
            if (Input.GetKeyDown(KeyCode.R))
            {
                smallshield++;
                g = g - 100;
                myLocation = Location.blacksmith;
            }
        }
        else if(g < 100)
        {
            myLocation = Location.error1;
        }
    }

    private void Boughtbs()
    {
        myLocation = Location.error1;
    }

    private void Boughtls()
    {
        myLocation = Location.error1;
    }

    private void Generalgoods()
    {
        textObject.text = "Arrived at the General Goods Shop. \n" +
            "Talk to the Merchant? (T) \n" +
            "Move to the Fountain? (F)";
        if (Input.GetKeyDown(KeyCode.T))
        {
            myLocation = Location.merchant;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            myLocation = Location.fountain;
        }
    }

    private void Merchant()
    {
        textObject.text = "Welcome! Please take your time. \n" +
                "Gold = " + g + "\n" +
                "Small Health Potion - 10g (Z) \n" +
                "Large Health Potion - 50g (X) \n" +
                "Return (R)";
        if (Input.GetKeyDown(KeyCode.Z))
        {
            myLocation = Location.shp;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            myLocation = Location.lhp;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.generalgoods;
        }
    }

    private void Shp()
    {
        if (g >= 10)
        {
            textObject.text = "Gained 'Small Health Potion' \n" +
                "Return (R)";
            if (Input.GetKeyDown(KeyCode.R))
            {
                smallhealthpotion++;
                g = g - 10;
                myLocation = Location.merchant;
            }
        }
        else if (g < 10)
        {
            myLocation = Location.error2;
        }
    }

    private void Lhp()
    {
        if (g >= 50)
        {
            textObject.text = "Gained 'Large Health Potion' \n" +
                "Return (R)";
            if (Input.GetKeyDown(KeyCode.R))
            {
                largehealthpotion++;
                g = g - 50;
                myLocation = Location.merchant;
            }
        }
        else if (g < 50)
        {
            myLocation = Location.error2;
        }
    }

    private void Magicshop()
    {
        textObject.text = "Arrived at the Magic Shop. \n" +
            "Talk to the Wizard? (T) \n" +
            "Talk to the Apprentice? (Y) \n" +
            "Move to the Fountain? (F)";
        if (Input.GetKeyDown(KeyCode.T))
        {
            myLocation = Location.wizard;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            myLocation = Location.apprentice;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            myLocation = Location.fountain;
        }
    }

    private void Wizard()
    {
        textObject.text = "If you don't mind I'm quite busy. \n" +
                "Gold = " + g + "\n" +
                "Robes - 50g (Z) \n" +
                "Return (R)";
        if (Input.GetKeyDown(KeyCode.Z))
        {
            myLocation = Location.robes;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.magicshop;
        }
    }

    private void Robes()
    {
        if (g >= 50)
        {
            textObject.text = "Gained 'Robes' \n" +
                "Return (R)";
            if (Input.GetKeyDown(KeyCode.R))
            {
                robes++;
                g = g - 50;
                myLocation = Location.wizard;
            }
        }
        else if (g < 50)
        {
            myLocation = Location.error3;
        }
    }

    private void Apprentice()
    {
        textObject.text = "... \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.magicshop;
        }
    }

    private void Guild()
    {
        textObject.text = "Arrived at the Guild. \n" +
            "Talk to the Guild Master? (T) \n" +
            "Talk to the Trader? (Y) \n" +
            "Move to the Fountain? (F)";
        if (Input.GetKeyDown(KeyCode.T))
        {
            myLocation = Location.guildmaster;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            myLocation = Location.trader;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            myLocation = Location.fountain;
        }
    }

    private void Guildmaster()
    {
        textObject.text = "If you got anything to sell I may be able to take if off your hands. \n" +
            "Sell? (S) \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myLocation = Location.sell;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.guild;
        }
    }

    private void Sell()
    {
        textObject.text = "What would you like to sell? \n" +
            "Small Shield " + smallshield + " (Z)\n" + "Short Sword " + shortsword + " (X)\n" + "Work Boots " + boots + " (C) \n" + 
            "Small Health Potion " + smallhealthpotion + " (V)\n" + "Large Health Potion " + largehealthpotion + " (B) \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.Z))
        {
            myLocation = Location.sellsms;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            myLocation = Location.sellss;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            myLocation = Location.sellboots;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            myLocation = Location.sellshp;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            myLocation = Location.selllhp;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.guildmaster;
        }
    }

    private void Sellsms()
    {
        if (smallshield >= 1)
        {
            textObject.text = "Gained 50g. \n" +
                "Return (R)";
            if (Input.GetKeyDown(KeyCode.R))
            {
                smallshield--;
                g = g + 50;
                myLocation = Location.sell;
            }
        }
        else if (smallshield < 1)
        {
            myLocation = Location.error4;
        }
    }

    private void Sellss()
    {
        if (shortsword >= 1)
        {
            textObject.text = "Gained 50g. \n" +
                "Return (R)";
            if (Input.GetKeyDown(KeyCode.R))
            {
                shortsword--;
                g = g + 50;
                myLocation = Location.sell;
            }
        }
        else if (shortsword < 1)
        {
            myLocation = Location.error4;
        }
    }

    private void Sellboots()
    {
        if (boots >= 1)
        {
            textObject.text = "Gained 10g. \n" +
                "Return (R)";
            if (Input.GetKeyDown(KeyCode.R))
            {
                boots--;
                g = g + 10;
                myLocation = Location.sell;
            }
        }
        else if (boots < 1)
        {
            myLocation = Location.error4;
        }
    }
    private void Sellshp()
    {
        if (smallhealthpotion >= 1)
        {
            textObject.text = "Gained 5g. \n" +
                "Return (R)";
            if (Input.GetKeyDown(KeyCode.R))
            {
                smallhealthpotion--;
                g = g + 5;
                myLocation = Location.sell;
            }
        }
        else if (smallhealthpotion < 1)
        {
            myLocation = Location.error4;
        }
    }
    private void Selllhp()
    {
        if (largehealthpotion >= 1)
        {
            textObject.text = "Gained 20g. \n" +
                "Return (R)";
            if (Input.GetKeyDown(KeyCode.R))
            {
                largehealthpotion--;
                g = g + 20;
                myLocation = Location.sell;
            }
        }
        else if (largehealthpotion < 1)
        {
            myLocation = Location.error4;
        }
    }

    private void Trader()
    {
        textObject.text = "Sorry, can't talk. I've got a meeting to get to. \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.guild;
        }
    }

    private void Farmer()
    {
        print("Here to help out? (Y)/(N) ");
        textObject.text = "Here to help out? (Y)/(N)";
        if (Input.GetKeyDown(KeyCode.Y))
        {
            myLocation = Location.farmeryes;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            myLocation = Location.farmerno;
        }
    }

    private void Farmhand()
    {
        textObject.text = "Got time to talk ya got time to work. \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.commons;
        }
    }

    private void Farmeryes()
    {
        print("Thanks for your help.");
        print("Gained 'Work Boots'");
        textObject.text = "Thanks for your help. \n" +
            "Gained 'Work Boots' \n" +
            "Return (R)";
        //textObject.text = "Return (R) ";
        if (Input.GetKeyDown(KeyCode.R))
        {
            boots++;
            myLocation = Location.commons;
        }        
    }

    private void Farmerno()
    {
        print("Well get loss!");
        textObject.text = "Well get lost! \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.commons;
        }
    }

    private void Arenafight1()
    {
        a = a + 1;
        textObject.text = "First oppenent is 'Townsman' \n" +
            "Attack (A) \n" +
            "Defend (D) \n" +
            "Use Item (I)";
        if (ht <= 0)
        {
            myLocation = Location.win1;
        }
        else if (hp <= 0)
        {
            myLocation = Location.lose;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if(shortsword >= 1)
            {
                ht = ht - 3;
                if (boots >= 1 && smallshield >= 1)
                {
                    hp = hp - 0;
                }
                else if ((boots >= 1 && smallshield == 0) || (boots == 0 && smallshield >= 0))
                {
                    hp = hp - 1;
                }
                else
                {
                    hp = hp - 2;
                }                
                myLocation = Location.status1;
            }
            else
            {
                ht = ht - 1;
                if (boots >= 1 && smallshield >= 1)
                {
                    hp = hp - 0;
                }
                else if ((boots >= 1 && smallshield == 0) || (boots == 0 && smallshield >= 0))
                {
                    hp = hp - 1;
                }
                else
                {
                    hp = hp - 2;
                }
                myLocation = Location.status1;
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (boots >= 0 || smallshield >= 0)
            {
                hp = hp - 0;
            }
            else
            {
                hp = hp - 1;
            }            
            myLocation = Location.status1;
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            myLocation = Location.useitem;
        }
    }

    private void Arenafight2()
    {
        b = b + 1;
        textObject.text = "Second oppenent is 'Wizard' \n" +
            "Attack (A) \n" +
            "Defend (D) \n" +
            "Use Item (I)";
        if (hw <= 0)
        {
            myLocation = Location.win2;
        }
        else if (hp <= 0)
        {
            myLocation = Location.lose;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (shortsword >= 1)
            {
                hw = hw - 3;
                if (robes >= 1)
                {
                    hp = hp - 3;
                }
                else
                {
                    hp = hp - 7;
                }
                myLocation = Location.status2;
            }
            else
            {
                hw = hw - 1;
                if (robes >= 1)
                {
                    hp = hp - 3;
                }
                else
                {
                    hp = hp - 7;
                }
                myLocation = Location.status2;
            }
        }
        if (Input.GetKeyDown(KeyCode.D) && robes < 1)
        {
            hp = hp - 7;
            myLocation = Location.status2;
        }
        if (Input.GetKeyDown(KeyCode.D) && robes >= 1)
        {
            hp = hp - 3;
            myLocation = Location.status2;
        }
        if (Input.GetKeyDown(KeyCode.I))
        {            
            myLocation = Location.useitem;
        }
    }

    private void Arenafight3()
    {
        c = c + 1;
        textObject.text = "Third oppenent is 'Mercenary' \n" +
            "Attack (A) \n" +
            "Defend (D) \n" +
            "Use Item (I)";
        if (hm <= 0)
        {
            myLocation = Location.win3;
        }
        else if (hp <= 0)
        {
            myLocation = Location.lose;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (shortsword >= 1)
            {
                hm = hm - 3;
                if (boots >= 1 && smallshield >= 1)
                {
                    hp = hp - 1;
                }
                else if ((boots >= 1 && smallshield == 0) || (boots == 0 && smallshield >= 0))
                {
                    hp = hp - 2;
                }
                else
                {
                    hp = hp - 3;
                }
                myLocation = Location.status3;
            }
            else
            {
                hm = hm - 1;
                if (boots >= 1 && smallshield >= 1)
                {
                    hp = hp - 1;
                }
                else if ((boots >= 1 && smallshield == 0) || (boots == 0 && smallshield >= 0))
                {
                    hp = hp - 2;
                }
                else
                {
                    hp = hp - 3;
                }
                myLocation = Location.status3;
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (boots >= 0 && smallshield >= 0)
            {
                hp = hp - 0;
            }
            else if ((boots >= 1 && smallshield == 0) || (boots == 0 && smallshield >= 0))
            {
                hp = hp - 1;
            }
            else
            {
                hp = hp - 2;
            }
            myLocation = Location.status3;
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            myLocation = Location.useitem;
        }
    }

    private void Arenafight4()
    {
        d = d + 1;
        textObject.text = "Final oppenent is 'Knight' \n" +
            "Attack (A) \n" +
            "Defend (D) \n" +
            "Use Item (I)";
        if (hk <= 0)
        {
            myLocation = Location.win4;
        }
        else if (hp <= 0)
        {
            myLocation = Location.lose;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (shortsword >= 1)
            {
                hk = hk - 2;
                if (boots >= 1 && smallshield >= 1)
                {
                    hp = hp - 2;
                }
                else if ((boots >= 1 && smallshield == 0) || (boots == 0 && smallshield >= 0))
                {
                    hp = hp - 3;
                }
                else
                {
                    hp = hp - 4;
                }
                myLocation = Location.status4;
            }
            else
            {
                hk = hk - 0;
                if (boots >= 1 && smallshield >= 1)
                {
                    hp = hp - 2;
                }
                else if ((boots >= 1 && smallshield == 0) || (boots == 0 && smallshield >= 0))
                {
                    hp = hp - 3;
                }
                else
                {
                    hp = hp - 4;
                }
                myLocation = Location.status4;
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (boots >= 0 && smallshield >= 0)
            {
                hp = hp - 1;
            }
            else if ((boots >= 1 && smallshield == 0) || (boots == 0 && smallshield >= 0))
            {
                hp = hp - 2;
            }
            else
            {
                hp = hp - 3;
            }
            myLocation = Location.status4;
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            myLocation = Location.useitem;
        }
    }

    private void Win1()
    {
        hp = 10;        
        textObject.text = "Congratulations! Received small health potion. \n" +
            "Ready for the second round? \n" +
            "Ready (R)";
        if(Input.GetKeyDown(KeyCode.R))
        {
            smallhealthpotion = smallhealthpotion + 1;
            myLocation = Location.arenafight2;
        }
    }

    private void Win2()
    {        
        hp = 10;
        textObject.text = "Congratulations! Received 2 small health potions. \n" + 
            "Ready for the third round? \n" +
            "Ready (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            smallhealthpotion = smallhealthpotion + 2;
            myLocation = Location.arenafight3;
        }
    }

    private void Win3()
    {
        hp = 10;        
        textObject.text = "Congratulations! Received large health potion. \n" +
            "Ready for the final round? \n" +
            "Ready (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            largehealthpotion = largehealthpotion + 1;
            myLocation = Location.arenafight4;
        }
    }

    private void Win4()
    {
        textObject.text = "Congratulations! You beat the game! \n" +
            "Quit (Q)";
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }

    private void Lose()
    {
        textObject.text = "You died. \n" +
            "Quit (Q)";
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }

    private void Status1()
    {
        if (hp >= 10)
        {
            hp = 10;
        }
        textObject.text = "Townsman Attacks \n" +
            "Hp = " + hp + " \n" +
            "Opponent Hp = " + ht + " \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.arenafight1;
        }
    }

    private void Status2()
    {
        if (hp >= 10)
        {
            hp = 10;
        }
        textObject.text = "Wizard Attacks \n" +
            "Hp = " + hp + " \n" +
            "Opponent Hp = " + hw + " \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.arenafight2;
        }
    }

    private void Status3()
    {
        if (hp >= 10)
        {
            hp = 10;
        }
        textObject.text = "Mercenary Attacks \n" +
            "Hp = " + hp + " \n" +
            "Opponent Hp = " + hm + " \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.arenafight3;
        }
    }

    private void Status4()
    {
        if (hp >= 10)
        {
            hp = 10;
        }
        textObject.text = "Knight Attacks \n" +
            "Hp = " + hp + " \n" +
            "Opponent Hp = " + hk + " \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.arenafight4;
        }
    }

    private void Useitem()
    {
        textObject.text = "What would you like to use? \n" +
            "Small Health Potion: " + smallhealthpotion + " (T) \n" +
            "Large Health Potion: " + largehealthpotion + " (Y) \n" + 
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.T) && smallhealthpotion >= 1)
        {
            smallhealthpotion = smallhealthpotion - 1;
            myLocation = Location.statusupdate1;
        }
        if (Input.GetKeyDown(KeyCode.Y) && largehealthpotion >= 1)
        {
            largehealthpotion = largehealthpotion - 1;
            myLocation = Location.statusupdate2;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (a >= 1 && b == 0 && c == 0 && d == 0)
            {
                myLocation = Location.status1;
            }
            else if (b >= 1 && c == 0 && d == 0)
            {
                myLocation = Location.status2;
            }
            else if (c >= 1 && d == 0)
            {
                myLocation = Location.status3;
            }
            else if (d >= 1)
            {
                myLocation = Location.status4;
            }
        }
    }

    private void Statusupdate1()
    {
        textObject.text = "Used a small health potion. \n" +
            "Small Health Potion: " + smallhealthpotion + " \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            hp = hp + 3;
            if (a >= 1 && b == 0 && c == 0 && d == 0)
            {
                if (boots >= 1 && smallshield >= 1)
                {
                    hp = hp - 0;
                }
                else if ((boots >= 1 && smallshield == 0) || (boots == 0 && smallshield >= 0))
                {
                    hp = hp - 1;
                }
                else
                {
                    hp = hp - 2;
                }
                myLocation = Location.status1;
            }
            else if (b >= 1 && c == 0 && d == 0)
            {
                if (robes >= 1)
                {
                    hp = hp - 3;
                }
                else
                {
                    hp = hp - 7;
                }
                myLocation = Location.status2;
            }
            else if (c >= 1 && d == 0)
            {
                if(boots >= 1 && smallshield >= 1)
                {
                    hp = hp - 1;
                }
                else if ((boots >= 1 && smallshield == 0) || (boots == 0 && smallshield >= 0))
                {
                    hp = hp - 2;
                }
                else
                {
                    hp = hp - 3;
                }
                myLocation = Location.status3;
            }
            else if (d >= 1)
            {
                if (boots >= 1 && smallshield >= 1)
                {
                    hp = hp - 2;
                }
                else if ((boots >= 1 && smallshield == 0) || (boots == 0 && smallshield >= 0))
                {
                    hp = hp - 3;
                }
                else
                {
                    hp = hp - 4;
                }
                myLocation = Location.status4;
            }
        }
    }

    private void Statusupdate2()
    {
        textObject.text = "Used a large health potion. \n" +
            "Large Health Potion: " + largehealthpotion + " \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            hp = hp + 10;
            if (a >= 1 && b == 0 && c == 0 && d == 0)
            {
                if (boots >= 1 && smallshield >= 1)
                {
                    hp = hp - 0;
                }
                else if ((boots >= 1 && smallshield == 0) || (boots == 0 && smallshield >= 0))
                {
                    hp = hp - 1;
                }
                else
                {
                    hp = hp - 2;
                }
                myLocation = Location.status1;
            }
            else if (b >= 1 && c == 0 && d == 0)
            {
                if (robes >= 1)
                {
                    hp = hp - 3;
                }
                else
                {
                    hp = hp - 7;
                }
                myLocation = Location.status1;
            }
            else if (c >= 1 && d == 0)
            {
                if (boots >= 1 && smallshield >= 1)
                {
                    hp = hp - 1;
                }
                else if ((boots >= 1 && smallshield == 0) || (boots == 0 && smallshield >= 0))
                {
                    hp = hp - 2;
                }
                else
                {
                    hp = hp - 3;
                }
                myLocation = Location.status3;
            }
            else if (d >= 1)
            {
                if (boots >= 1 && smallshield >= 1)
                {
                    hp = hp - 2;
                }
                else if ((boots >= 1 && smallshield == 0) || (boots == 0 && smallshield >= 0))
                {
                    hp = hp - 3;
                }
                else
                {
                    hp = hp - 4;
                }
                myLocation = Location.status4;
            }
        }
    }

    private void Error1()
    {
        textObject.text = "Insufficient Funds. \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.blacksmith;
        }
    }

    private void Error2()
    {
        textObject.text = "Insufficient Funds. \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.merchant;
        }
    }

    private void Error3()
    {
        textObject.text = "Insufficient Funds. \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.wizard;
        }
    }

    private void Error4()
    {
        textObject.text = "Cannot Sell. \n" +
            "Return (R)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myLocation = Location.sell;
        }
    }
}
