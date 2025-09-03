using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

internal class Film
{
    protected string tytuł {  get; set; }
    protected int liczbaWyporzyczeń { get; set; }

    Film()
    {
        tytuł = string.Empty;
        liczbaWyporzyczeń = 0;
    }

    public void IncrementNumberOfRentals()
    {
        liczbaWyporzyczeń += 1;
    }
}

