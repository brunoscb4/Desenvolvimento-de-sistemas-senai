using System;
using System.Collections.Generic;

// Classe base Animal
abstract class Animal
{
    public string Nome { get; set; }
    
    public int Idade
    {
        get { return idade; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Idade não pode ser negativa");
            idade = value;
        }
    }

    protected int idade;

    // Método abstrato que será sobrescrito nas classes derivadas
    public abstract void EmitirSom();

    // Método virtual para apresentação
    public virtual void Apresentar()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {idade} anos");
    }
}

// Classe Cachorro
class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome} está latindo: Au Au!");
    }
}

// Classe Gato
class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome} está miando: Miau!");
    }
}

// Classe Pássaro
class Passaro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome} está cantando: Piu piu!");
    }

    public void Voar()
    {
        Console.WriteLine($"{Nome} está voando!");
    }
}

// Class Veterinario
class Veterinario
{
    private string especialdade;

    public string Especialidade
    {
        get { return especialdade; }
        set
        {
            if (value == "Felinos" && value == "Caninos ")
            {
                throw new ArgumentException("A especialidade deve ser felinos ou Caninos ");
                especialdade = value;
            }

        }
    }

        public void Examinar(Animal animal) {
        Console.WriteLine($" O veterinario esta examinando o {animal.Nome}");
        animal.EmitirSom();
    
    }
}

// Classe Zoo, que contém a lista de animais
class Zoo
{
    private List<Animal> animais = new List<Animal>();

    public void AdicionarAnimal(Animal animal)
    {
        animais.Add(animal);
    }

    public void MostrarAnimais()
    {
        foreach (var animal in animais)
        {
            animal.Apresentar();
            animal.EmitirSom();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando os animais
        var cachorro = new Cachorro { Nome = "Rex", Idade = 5 };
        var gato = new Gato { Nome = "Mimi", Idade = 3 };
        var passaro = new Passaro { Nome = "Loro", Idade = 2 };

        // Criando o zoológico
        var zoo = new Zoo();

        // Criando veterinario
        var VeteCanino = new Veterinario { Especialidade = "Caninos" };
        var VetFelino = new Veterinario { Especialidade = "Felinos" };

        // Adicionando os animais ao zoológico
        zoo.AdicionarAnimal(cachorro);
        zoo.AdicionarAnimal(gato);
        zoo.AdicionarAnimal(passaro);

       
        // Mostrando os animais e seus sons
        zoo.MostrarAnimais();

        // Chamando o método específico do pássaro
        passaro.Voar();
        
        VeteCanino.Examinar(cachorro);
        VeteCanino.Examinar(gato);
    }
}

