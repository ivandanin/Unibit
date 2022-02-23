using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_46337_z
{
    class Program
    {
        static void Main(string[] args)
        {

            //Първа задача, тест
            Employee employee = new Employee("Ivan", "Danin", 19, "010923", "client");
            Console.WriteLine(employee.ToString());

            //Втора задача, тест
            Console.WriteLine("Моля, въведете име и фамилия, възраст, ЕГН и дали сте или не сте клиент на банката!");
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string ID = Console.ReadLine();
            string client = Console.ReadLine();
            Employee employee1 = new Employee(firstName, lastName, age, ID, client);

            employee1.statusCheck();
        }

            //Четвърта задача
            public abstract class Ac
        {
            public abstract void Method1();

        }
        public class Bc : Ac
        {
            public override void Method1()
            {
                throw new NotImplementedException();
            }

            public void Method2()
            {
                Console.WriteLine("This is Method-2");
            }
        }
        public class C : Bc
        {
            public override void Method1()
            {
                Console.WriteLine("This is Method-1 - overriden");
            }

            public override string ToString()
            {
                return base.ToString();
            }
        }



        /*    Само за пояснение(за онези които не са наясно с реда в банката): Знаете, че за да сте
клиент на банка трябва да имате открита банкова сметка с номер и регистрация по
име, ЕГН и адрес в банката с минимум 20 лева баланс(т.е.винаги подлежите на проверка) .
Всяка банка отпуска кредити(заем) на кредитоискатели за определен брой месеци и до
определени суми като начислява лихва върху тях.За да стимулират своите клиенти,
банките отпускат кредити с различен процент на лихвата за своите клиенти и за други
лица(т.е.не клиенти на банката – т.е.не са собственици(owner) на банкова сметка).
Начало на заданието:
            Клиенти на банка - кредитиране
Българска банка предлага следните кредити на кредитоискатели(Employee):

Лихвен процент

Размер на кредита за
клиенти на банката

Независимо от размерът на сумата

5 %

За други лица(не
клиенти на банката)

Независимо от размерът на сумата
Формула: кредит = исканКредит * 0.08

8 %

Банката стимулира пенсионерите(клиенти на банката) и дава промоционална лихва.
Другите социални групи потребители(следващата таблица) нямат привилегия:
Клиенти на банката Лихвен процент
Пенсионери(над 65 години) С 2 % по - нисък
Възрастни(25 до 65) години няма
Студенти до 25 години няма
N Задачи Оценка

1.
Да се създаде клас Employee със следните полета(член-променливи) –
име, фамилия, възраст(и ако ви е необходимо за трета задача – ЕГН).
 Създаденият клас Employee да бъде капсулиран – т.е.да се
създадат свойства. Да се създадат всички възможни
конструктори - overloading.
 Част от данните да бъдат валидирани(например – възраст да
не може да се въвеждат отрицателни или нула години) с
хвърляне на изключение.
 Да се подготви метод в клас Employee , който принтира данните
за всеки създаден потребител(обект).
 Създайте обект(инстанция на класа) и тествайте данните!

3(среден)

2.  Да се създаде метод в същия клас, който проверява правилно
ли е зададен статуса на потребителя(да печата в конзолата
статуса – като използвате данните за социалните групи на
клиенти на банката - горе) на база на въведените за него
години.
Тествайте.
 Задаването на данните(стойностите) на обектите да се
извършва с използване на клавиатурата(в диалогов режим с
конзолата).

4(добър)

3.Като ползвате class SavingsAccount (кодът който следва -долу) създайте 5(Мн.добър

клас негов наследник - class CreditAccount.
 В class SavingsAccount (долу) има метод GetCredit(decimal
creditAmount, Employee obj) – методът не отчита никакви
привилегии за отпускане на кредит(отпуска кредит и изчислява
при най-висока лихва = 0.08, т.е.не отчита дали си клиент или
не си на банката).
 Моля пренапишете метода GetCredit(decimal creditAmount,
Employee obj) в класа наследник, така че да отчита
привилегиите – т.е като използвате предлаганите от банката
лихви и стимули(горе) за пенсионери, за клиенти и не клиенти
на банката да отпуснете различни по размер(по формула –
съответен процент) кредити на кредитоискател(Employee).
 Като препоръка – в пренаписания метод трябва да има
проверка, например по собственик(име, ЕГН и др.) на сметката
(дали е собственик или не на сметка в банката – т.е.дали е
клиент или не банката). Може да има и друга проверка по ваше
решение.
 Направете тест: Създайте три обекта Employee - класът от
първа задача - в ролята на кредитоискател.Единият да е
собственик на сметка в банката, вторият да е собственик на
сметка и да е пенсионер, третият да не е собственик на сметка в
банката.Тествайте пренаписания метод GetCredit(decimal
creditAmount, Employee obj) за всеки от обектите от Employee.
class SavingsAccount
        {
            protected string owner;
            protected decimal balance;
            public SavingsAccount(string name, decimal balance)
            {
                this.owner = name;
                this.balance = balance;
            }
            public void GetCredit(decimal creditAmount,
            Employee obj)
            {
                decimal totalCreditAmount;
                totalCreditAmount = creditAmount +
                creditAmount * (decimal)0.08;
                Console.WriteLine( $&quot; The Credit amount is
            ${ totalCreditAmount}
                and the person is { obj.firstName }
& quot;);
            }
        }

)
.

4. Следващият код не работи.Като запазите множественото наследяване,
направете кода работещ.
public abstract class Ac
        {
            public abstract void Method1();
        }
        public class Bc
        {
            public void Method2()
        
6(отличен)

{
Console.WriteLine(&quot;This is Method-2&quot;);
}
    }
    public class C : Ac, Bc
    {
        public override void Method1()
        {
            Console.WriteLine(&quot; This is Method - 1 - overriden & quot;);
        }
    }

    Важно за оценката!!!!!
Оформете тестовете в метод Main() по задачи и ги
коментирайте!
        */
    }
        
    }

        
