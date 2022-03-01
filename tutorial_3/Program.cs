using System;
namespace ConsoleApp1;

class Programa
{

    static void Main(String[] args)
    {
        Person p1 = new Person(); // o comando new chama para abrir uma instancia (um objeto) que ficará alocado em p1.
                                    // command call to open a instance (called object) and it will be alocaded at p1.

        p1.Name = "Amada"; //nesse momento está sendo atribuído o valor de "Amada" para a propriedade Nome ao objeto p1.
                            // at this moment "Amada" is a property Name of p1 object
        p1.Age = 38;        //this time 38 is a property Age of p1 object

        p1.IntroduceYourSelf(); // call return at Person class
                
           }
}