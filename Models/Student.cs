using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_4.Models
{
    //Classe student com suas propriedades e o metodo Displayinfo();
public class Student
{
    public string Name { get; set; }
    public string University { get; set; }
    public int RollNumber { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"{Name} - {University} - {RollNumber}");
    }
}
}
