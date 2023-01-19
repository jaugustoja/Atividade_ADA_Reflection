using System;
using System.Reflection;
using Exercicio_4.Models;

class Program
{
    static void Main(string[] args)
    {
        //Chama o método criado na classe program e instancia o objeto de studant por reflection. 
        var Objeto1 = CreateInstance();

        //Chama o método e printa as propriedades do método por reflection baseado no objeto studant instanciado.
        DisplayPublicProperties(Objeto1);

        //Chama o método e printa as propriedades setadas do objeto instanciado da clase student.
        Objeto1.DisplayInfo();
    }

    //Método que por reflection exibe as propriedades da classe student pelo tipo.
    static void DisplayPublicProperties(object obj)
    {
        //Pega o objeto do parametro e retorna o seu tipo por reflection.
        Type tipo = obj.GetType();

        //retorna as propriedades da classe student, através de seu tipo, e salva em array.
        PropertyInfo[] propriedades = tipo.GetProperties();

        //Imprime as propriedades armazenadas no array.
        foreach (var propriedade in propriedades)
        {
            Console.WriteLine(propriedade.Name);
        }
    }

    static Student CreateInstance()
    {
        //Retorna o tipo da classe Studente armazena em t através de reflection.
        Type t = typeof(Student);

        //Instancia objeto da classe Student atraves de metodo do activator. 
        var student1 = (Student)Activator.CreateInstance(t);

        //Busca as propriedades e seta todas as propriedades do objeto student1.
        PropertyInfo namePropriedade = t.GetProperty("Name");
        namePropriedade.SetValue(student1, "José");

        PropertyInfo universityPropriedade = t.GetProperty("University");
        universityPropriedade.SetValue(student1, "Faculdade Impacta");

        PropertyInfo rollNumberPropriedade = t.GetProperty("RollNumber");
        rollNumberPropriedade.SetValue(student1, 01);

        //Busca o método displayInfo() na classe pelo tipo.
        MethodInfo displayMethod = t.GetMethod("DisplayInfo");

        //Seta o objeto student1 passando o parametro (vazio).
        displayMethod.Invoke(student1, null);

        //retorna o objeto da classe student1 setado.
        return student1;
    }
}


