using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Zoo : MonoBehaviour
{
    public List<Animal> animals = new List<Animal>() { new Dog(), new Bird(), new Elephant() };
void Start() 
    {
        foreach (Animal a in animals)
        {
            a.Move();
            a.Eat();
        }
    }
}
public abstract class Animal
{
    public abstract void Move();
    public void Eat() { Debug.Log("Njam Njam"); }
}
public class Dog : Animal
{
    public override void Move()
    {
        Debug.Log("Wiggles its tail while walking");
    }
}
public class Bird : Animal
{
    public override void Move()
    {
        Debug.Log("Flaps its wings while flying");
    }
}
public class Elephant : Animal
{
    public override void Move()
    {
        Debug.Log("Stomps around while walking on all fours");
    }
}