using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TRAINING
{
    public class Person
    {
        #region FIELDS

        private string _firstName;

        #endregion

        #region CONSTRUCTOR

        public Person()
        {
        }

        public Person(string first)
        {
            FirstName = first;
        }

        public Person (string first, string last): this(first)
        {
            LastName = last;
        }

        #endregion

        #region PROPERTIES
            
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
         
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public int Sample { get; private set; }

        private string _nickName;

        public string NickName
        {
            get
            {
                if (string.IsNullOrEmpty(_nickName))
                    return "N/A";

                return _nickName;
            }
            set
            {
                if (value == null)
                    _nickName = string.Empty;
                else 
                    _nickName = value;
            }
        }

        public DateTime? BirthDate { get; set; }

        public List<Fruit> FavoriteFruits { get; set; } = new List<Fruit>();

        #endregion

        #region METHODS

        public void Update(int sample)
        {
            Sample = sample;
        }

        public void Update(int sample, string nickName)
        {
            Update(sample);
            NickName = nickName;
            NickNameHandler?.Invoke(this, new NickNameArgs { NickName = nickName });
            /* " ?. " IS EQUIVALENT TO:
            if(NickNameHandler != null)
            {
                NickNameHandler.Invoke()
            } */
        }

        //public DateTime? BirthDate { get; set; } ALLOCATED TO #PROPERTIES

        public int? GetAge()
        {
            if (BirthDate.HasValue)
            {
                return (int?)((DateTime.Now - BirthDate.Value).TotalDays / 365);
            }

            return default;
        }

        public void AddFavoriteFruit (Fruit fruit, ProcessFruitDelegate successCallBack)
        {
            FavoriteFruits.Add(fruit);
            successCallBack(fruit);
        }

        public void DeleteFavoriteFruit(Fruit fruit, ProcessFruitDelegate successCallBack)
        {
            FavoriteFruits.Remove(fruit);
            successCallBack(fruit);
        }
        
        #endregion

        #region EVENTS

        public event EventHandler<NickNameArgs> NickNameHandler;

        #endregion
    }

    public class NickNameArgs: EventArgs
    {
        public string NickName { get; set; }
    }
    
    public struct Fruit
    {
        public Fruit (string name, string color)
        {
            Name = name;
            Color = color;
        }

        public string Name { get; set; }
        public string Color { get; set; }
    }

    public class WalangFirstNameException: Exception
    {
    }

    #region WIHOUT OOP

    public class SimpleOperationWithoutOOP
    {
        public void Process()
        {
            Print(new Ninja() { Weapon = "FIREBALL", SecretWeapon = "SHURIKEN" });
            Print(new Samurai() { Weapon = "SWORD", SecretWeapon = "BLAST" });
        }

        public void Print(Ninja ninja)
        {
            ninja.SecretWeapon = "GUN";
            ninja.Attack();
        }

        public void Print(Samurai samurai)
        {
            samurai.SecretWeapon = "KNIFE";
            samurai.Attack();
        }
    }
    
    public class Ninja
    {
        public string Name { get; } = "NINJA";
        public string SecretWeapon { get; set; }
        public string Weapon { get; set; }
        public void Attack()
        {
            Console.WriteLine($"{Name}: ATTACK BY {Weapon} & {SecretWeapon}");
        }
    }

    public class Samurai
    {
        public string Name { get; } = "SAMURAI";
        public string SecretWeapon { get; set; }
        public string Weapon { get; set; }
        public void Attack()
        {
            Console.WriteLine($"{Name}: ATTACK BY {Weapon} & {SecretWeapon}");
        }
    }

    #endregion

    #region WITH OOP

    public class SimpleOperationWithOOP
    {
        public void Process()
        {
            Print(new Ninjas("SHURIKEN") { Weapon = "FIREBALL" });
            Print(new Samurais("BLAST") { Weapon = "SWORD" });
        }

        public void Print(IMandirigma mandirigma)
        {
            mandirigma.Attack();
        }
    }

    #region ABSTRACT

    public interface IMandirigma
    {
        string Name { get; }
        string Weapon { get; set; }
        public void Attack();
    }

    public abstract class Mandirigma: IMandirigma
    {
        private string _secretWeapon;
        public Mandirigma(string name, string secretWeapon)
        {
            Name = name;
            _secretWeapon = secretWeapon;
        }
        public string Name { get; private set; }
        public string Weapon { get; set; }
        public virtual void Attack()
        {
            Console.WriteLine($"{Name}: ATTACK BY {Weapon} & {_secretWeapon}");
        }
    }

    #endregion

    #region DERIVED CLASS

    public class Ninjas : Mandirigma
    {
        public Ninjas(string secret) : base("NINJA", secret) { }
    }

    public class Samurais : Mandirigma
    {
        public Samurais(string secret) : base("SAMURAI", secret) { }
        public override void Attack()
        {
            Console.WriteLine("OOP APPROACH");
            base.Attack(); 
        }
    }
    #endregion

    #endregion

    #region SOLID PRINCIPLE

    #region (S)OLID PRINCIPLE - SINGLE RESPONSIBILITY

    #region NOT FOLLOWING (S)OLID PRINCIPLE

    public class PDFDocument
    {
        public void PrintPDF()
        {
        }

        public void CalculatorQuaraticEquation()
        {
        }
    }

    #endregion

    #region FOLLOWING (S)OLID PRINCIPLE

    public class Word
    {
        public void Print()
        {
        }
    }

    public class QuadraticEquation
    {
        public void Calculate()
        {
        }
    }

    #endregion
     
    #endregion

    #region S(O)LID PRINCIPLE - OPEN FOR EXTENSION, CLOSED FOR MODIFICATION

    #region NOT FOLLOWING S(O)LID PRINCIPLE

    public class SimpleCalculator
    {
        public void Calculate(Operation[] operations)
        {
            foreach (var operation in operations)
            {
                if (operation is Add)
                {
                    Console.WriteLine($"FOR ADD CLASS: {operation.A + operation.B}");
                }
                else if (operation is Subtract)
                {
                    Console.WriteLine($"FOR SUBTRACTC CLASS: {operation.A - operation.B}");
                }
            }
        }
    }

    public abstract class Operation
    {
        public int A { get; set; }
        public int B { get; set; }
    }

    public class Add: Operation {
    }

    public class Subtract: Operation {
    }

    #endregion

    #region FOLLOWING S(O)LID PRINCIPLE

    public interface IOperation
    {
        int A { get; set; }
        int B { get; set; }
        void Compute();
    }

    public abstract class OperationV2: IOperation
    {
        public int A { get; set; }
        public int B { get; set; }
        public abstract void Compute();
    }

    public class AddV2: OperationV2
    {
        public override void Compute()
        {
            Console.WriteLine($"FOR ADD CLASS: {A + B}");
        }
    }

    public class SubtractV2: OperationV2
    {
        public override void Compute()
        {
            Console.WriteLine($"FOR SUBTRACT CLASS: {A - B}");
        }
    }

    public class SimpleCalculatorV2
    {
        public void Calculate(IOperation[] operations)
        {
            foreach (var operation in operations)
            {
                operation.Compute();
            }
        }
    }

    #endregion

    #endregion

    #region SO(L)ID PRINCIPLE - LISKOV'S SUBSTITUTION

    #region NOT FOLLOWING SO(L)ID PRINCIPLE

    public interface IEmployee
    {
        void DoWork();
        void CheckSubordinates();
    }

    public class Manager : IEmployee
    {
        public void DoWork()
        {
            Console.WriteLine("WORK WORK WORK");
        }
        public void CheckSubordinates()
        {
            Console.WriteLine("SUPERVISE");
        }
    }

    public class Staff : IEmployee
    {
        public void DoWork()
        {
            Console.WriteLine("WORK WORK WORK");
        }
        public void CheckSubordinates()
        {
            throw new NotImplementedException();
        }
    }

    #endregion

    #region FOLLOWING SO(L)ID PRINCIPLE

    public interface IStaff
    {
        void DoWork();
    }

    public interface IManager: IStaff
    {
        void CheckSubordinates();
    }

    public class StaffV2: IStaff
    {
        public void DoWork() {
        }
    }

    public class ManagerV2 : StaffV2, IManager
    {
        public void CheckSubordinates()
        {
            Console.WriteLine("SUPERVISE");
        }
    }
    #endregion

    #endregion

    #region SOL(I)D PRINCIPLE - INTERFACE SEGREGATION

    #region NOT FOLLOWING SOL(I)D PRINCIPLE

    public interface ITrabahador
    {
        string Name { get; set; }
        void GetSalary();
        void MaghugasPlato();
        void MaglinisNgBahay();
        void Maglaba();
        void Magplantsa();
    }

    public class Tagalaba : ITrabahador
    {
        public string Name { get; set; }
        public void GetSalary()
        {
            Console.WriteLine("GET SALARY");
        }
        public void MaghugasPlato()
        {
            Console.WriteLine("PLATO");
        }
        public void Maglaba()
        {
            Console.WriteLine("LABA");
        }
        public void MaglinisNgBahay()
        {
            Console.WriteLine("LINIS");
        }
        public void Magplantsa()
        {
            Console.WriteLine("PLANTSA");
        }
    }

    #endregion

    #region FOLLOWING SOL(I)D PRINCIPLE

    public interface ITrabahador2
    {
        string Name { get; set; }
        void GetSalary();
    }
    public interface ITagahugas : ITrabahador2
    {
        void MaghugasPlato();
    }
    public interface ITagalinis : ITrabahador2
    {
        void MaglinisNgBahay();
    }
    public interface ITagalaba : ITrabahador2
    {
        void Maglaba();
    }
    public interface ITagaplantsa : ITrabahador2
    {
        void Magplantsa();
    }
    public interface TagaLabaNaPlantsadoraPa : ITagalaba, ITagaplantsa {
    }

    public abstract class Trabahador : ITrabahador2
    {
        public string Name { get; set; }
        public void GetSalary()
        {
            Console.WriteLine("GET SALARY");
        }
    }
    #endregion

    #endregion

    #region SOLI(D) PRINCIPLE - DEPENDENCY INVERSION

    #region NOT FOLLOWING SOLI(D) PRINCIPLE

    public class Repository
    {
        public void Add()
        {
            // WITH 1000+ LINES OF CODES HERE
            Console.WriteLine("ADD USING DB");
        }
        
        public void Delete()
        {
            // WITH 1000+ LINES OF CODES HERE
            Console.WriteLine("DELETE USING DB");
        }
    }
    
    #endregion

    #region FOLLOWING SOLI(D) PRINCIPLE

    public interface IRepository
    {
        void Add();
        void Delete();
    }

    public class DatabaseRepository : IRepository
    {
        public void Add()
        {
            Console.WriteLine("ADD USING DB");
        }

        public void Delete()
        {
            Console.WriteLine("DELETE USING DB");
        }
    }

    #endregion

    #endregion

    #endregion 
}
