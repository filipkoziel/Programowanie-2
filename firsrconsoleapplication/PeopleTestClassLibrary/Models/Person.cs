using System;
using System.Collections.Generic;

namespace PeopleTestClassLibrary.Models;

public partial class Person
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public int Age { get; set; }
}
