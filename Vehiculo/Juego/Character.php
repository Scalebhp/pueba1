<?php
include_once 'Inventory.php';

abstract class Character{
    
    private float $hp;
    private float $damage;
    private float $armor;
    private int $speed;
    private Inventory $inventory;


    // SOLO EXISTE UN SOLO CONSTRUCTOR
    function __construct() {
        $this->hp = 100.0;
        $this->damage = 5.0;
        $this->armor = 0.15;
        $this->speed = 1;
    }
    
    function walk(){
        
    }
    
    function fight(){
        
    }
    
    abstract function inventory();
    
}