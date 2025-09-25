using UnityEngine;
using System;
using System.Collections.Generic;

[Serializable]
public class Person
{
    public string id;
    public string firstName;
    public string lastName;
    public string birthDate;
    public string gender;

    public List<string> parents = new List<string>();
    public List<string> children = new List<string>();
    public List<string> siblings = new List<string>();
    public List<string> spouse = new List<string>();

    public List<Media> media = new List<Media>();

}
