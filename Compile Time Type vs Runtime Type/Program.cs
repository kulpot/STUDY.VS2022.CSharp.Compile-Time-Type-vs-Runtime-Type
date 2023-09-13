using System;

//ref link:https://www.youtube.com/watch?v=QmvmZqpthbc&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=54
//

class Animal { }
class Dog : Animal { }
class Cat : Animal { }

class MainClass
{
    static void Main()
    {
        var randy = new Random();
        bool randomBool = randy.Next() % 2 == 0;
        Animal a = randomBool ? (Animal)new Dog() : (Animal)new Cat();
        //Animal a = new Dog();
        //Animal a = new Cat();
        Dog d = (Dog)a; // cast for a for runtime of reference Dog // error for runtime reference cat because it is cast as Dog
        while (true) ; // compile time loading slow
    }
}