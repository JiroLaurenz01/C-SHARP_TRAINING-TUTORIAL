using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Linq;
using System.Diagnostics.Contracts;
using System.Security.AccessControl;
using System.Net.Http.Headers;
using System.Collections;
using System.Text;
using System.Xml.Schema;
using TRAINING;

namespace Training
{
    public class TrainingGround
    {
        private static int numbersLoop;

        static void Main(string[] args)
        {
            #region Ternary
            /* Console.Write("Input your age: ");
            var age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(age < 18 ? "minor" : "adult"); */
            #endregion

            #region Parse, Convert & Try Parse
            /*string textOne = "1";
            var intOne = int.Parse(textOne);
            var result = intOne + 5;

            Console.WriteLine($"(Parse) textOne result: {result}"); */
            #endregion

            #region Expression & Operators
            /* Console.WriteLine("Input a value: ");
            var formulaA = double.Parse(Console.ReadLine());
            Console.WriteLine("“Input b value: ");
            var formulaB = double.Parse(Console.ReadLine());

            var formulaResult = Math.Sqrt(Math.Pow(formulaA, 2)) + Math.Sqrt(Math.Pow(formulaB, 2));
            Console.WriteLine($"Sample C result: {formulaResult}"); */
            #endregion

            #region Do While Loop
            /*int numbersLoop = 1;

            do
            {
               Console.WriteLine(numbersLoop);
               numbersLoop++;
            } while (numbersLoop <= 1000); */
            #endregion

            #region IF, ELSE IF & ELSE Statement
            /*
            const int MAX_MINOR_AGE = 17;
            const int MIN_SENIOR_AGE = 60;

            Console.Write("What is your age? ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Do you have disibility? YES OR NO ONLY: ");
            string PWD = Console.ReadLine();

            if (age <= MAX_MINOR_AGE || age >= MIN_SENIOR_AGE && PWD == "YES")
            {
                Console.WriteLine("APPROVED FOR AGE AND PWD DISCOUNT");
            }           
            else if (age <= MAX_MINOR_AGE || age >= MIN_SENIOR_AGE)
            {
                Console.WriteLine("APPROVED FOR MINOR AND SENIOR DISCOUNT");
            }
            else if (PWD == "YES") 
            {
                Console.WriteLine("APPROVED FOR PWD DISCOUNT");
            }
            else  
            {
                Console.WriteLine("UNAPPROVED FOR DISCOUNT");
            } */
            #endregion

            #region While Loop
            /*
            var count = 1000;

            while (count > 1)
            {
                Console.WriteLine(count);
                count-=2;
            } */
            #endregion

            #region For Loop
            /*
            for (var index = 0; index <= 1000; index+= 2)
            {
                Console.WriteLine($"INDEX VALUE {index}");
            } */
            #endregion

            #region Foreach
            /*
            var nameSegments = new[] { "TIFFANY", "KATE", "DELA CRUZ" };
            foreach(var segment in nameSegments)
            {
                Console.WriteLine($"SEGMENT VALUE: {segment}");
            } */
            #endregion

            #region Array
            /*
            // SINGLE-DIMENSIONAL ARRAY
            int[] numbers = { 5, 10, 15, 20, 25 };
            string[] letters = { "aA", "bB", "cC", "dD", "eE" };

            Console.WriteLine(letters[1]);
            Console.WriteLine(numbers[1]);

            // MULTIDIMENSIONAL OR JAGGED ARRAY
            int[][] num = new int[][]
            {
                new int[]{ 2, 4, 6, 8, 10 },
                new int[]{12, 14, 16, 18, 20}
            };
            Console.WriteLine(num[0][0]);
            */

            // SINGLE-DIMENSIONAL ARRAY WITH FOREACH
            /*
            var names = new[] { "TIFFANY", "KATE", "DELACRUZ" };
            Console.WriteLine("BEFORE UPDATE");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            names[2] = "CUTIE";
            Console.WriteLine("AFTER UPDATE");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"name at index 2: {names[2]}");
            */

            // MULTIDIMENSIONAL ARRAY WITH FOR LOOP AND FOREACH
            /*
            var rowsAndCells = new int[3][]
            {
                new[] { 1, 2, 3 },
                new[] { 4, 5, 6 },
                new[] { 7, 8, 9 }
            };
            for (var row = 0; row < rowsAndCells.Length; row++)
            {
                Console.WriteLine($"row: {row}");
                foreach (var cell in rowsAndCells[row])
                {
                    Console.WriteLine($"value: {cell}");
                }
            }
            */

            // MULTIDIMENSIONAL WITH FOREACH BUT WITHOUT FOR LOOP
            /*
            var rowsAndCells = new int[3][]
            {
                new[] { 1, 2, 3 },
                new[] { 4, 5, 6 },
                new[] { 7, 8, 9 }
            };

                foreach (var cell in rowsAndCells[0])
            {
                Console.WriteLine($"value: {cell}");
            }
            */
            #endregion

            #region TESTING ARRAY
            /*
            int[] nombers = { 2, 4, 6, 8, 10 };
            nombers[0] = 5;
            Console.WriteLine(nombers[0]);
            */
            #endregion

            #region Enumerable, Collection & List

            // var countries = new[] { "Philippines", "USA", "Canada", "Pakistan", "Afghanistan" };

            #region ENUMERABLE
            /*
            IEnumerable<string> enumCountries = countries;
            //enumCountries[0] = "PHL";
            Console.WriteLine("Enumerable:");
            foreach (var country in countries)
            {
                Console.WriteLine(country);
            } */
            #endregion

            #region COLLECTION
            /*
            ICollection<string> colCountries = new List<string>(countries);
            colCountries.Add("Australia");
            colCountries.Remove("USA");

            //colCountries[0] = "SampleError";

            Console.WriteLine("Collection:");
            foreach (var country in colCountries)
            {
                Console.WriteLine(country);
            } */
            #endregion

            #region LIST
            /*
            var listCountries = new List<string>(countries); //with initial value from array
            var listInitCountries = new List<string>() //with initial value
            {
                "Philippines",
                "USA"
            };
            var listCountriesNew = new List<string>();
            listCountriesNew.Add("Philippines");
            listCountriesNew.Add("USA");
            listCountriesNew.AddRange(new[] { "Canada", "Australia" });
            listCountriesNew.Remove("Philippines");
            listCountriesNew[0] = "America";
            Console.WriteLine("List of Countries");
            for (var index = 0; index < listCountriesNew.Count; index++)
            {
                Console.WriteLine($"{index}:{listCountriesNew[index]}");
            } */
            #endregion

            #endregion

            #region Even & Odd Numbers (FOR LOOP AND IF STATEMENT)
            /*                
            for (var index = 1000; index >= 0; index--)
            {
                if (index % 2 == 0)
                {
                    Console.WriteLine($"Even Numbers: {index}");
                }
                else if (index % 2 == 1)
                {
                    Console.WriteLine($"Odd Numbers: {index}");
                } 
            } */
            #endregion

            #region TESTING ARRAY WITH FOR LOOP AND FOREACH
            /*
            string[][] names = new string[2][]
            {
                new string[]{ "Rhyle", "Jiro", "Aien", "Emci" },
                new string[]{ "Tiffany", "Lei", "Keisha", "Kim" }
            };
            var index = 0;

            for (index = 0; index < names.Length; index++)
            {   
                if (index == 0)
                {
                    Console.WriteLine("BOYS CUTIE");
                }             
                else
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine("GIRLS CUTIE");
                }
                foreach (var name in names[index])
                {
                    Console.WriteLine($"NAME: {name}");
                }
            } */
            #endregion

            #region Array
            /*
            string[] countries = new[] { "PHILIPPINES", "AMERICA", "INDIA" };
            Console.WriteLine(countries[0]);
            Console.WriteLine(countries[1]);
            Console.WriteLine(countries[2]);
            Console.WriteLine("           "); */
            #endregion

            #region IEnumerable
            /*
            IEnumerable<string> EnumCountries = countries;

            foreach (string country in EnumCountries)
            {
                Console.WriteLine(country);
            } */
            #endregion

            #region ICollection
            /*
            ICollection<string> ColCountries = new List<string>(countries);
            Console.WriteLine(ColCountries.Count);
            Console.WriteLine("      ");
            ColCountries.Add("JAPAN");
            ColCountries.Add("AUSTRALIA");
            ColCountries.Remove("PHILIPPINES");
            Console.WriteLine(ColCountries.Count);

            foreach (string country in ColCountries)
            {
                Console.WriteLine($"ICOLLECTION COUNTRY: {country}");  
            }

            ColCountries.Clear();
            Console.WriteLine(ColCountries.Count); */
            #endregion

            #region IList
            /*
            List<string> listCountries = new List<string>(countries);
            listCountries.AddRange(new[] {"AUSTRALIA","JAPAN","KOREA" });
            foreach (string country in listCountries)
            {
                Console.WriteLine($"FIRST LIST: {country}");
                Console.WriteLine("    ");
            }

            var secondListCountries = new List<string>()
            {
                "PHILIPPINES",
                "CHINA",
                "NORTH KOREA",
                "RUSSIA"
            };
            foreach (string countrees in secondListCountries)
            {
                Console.WriteLine($"SECOND LIST: {countrees}");
            }
            Console.WriteLine("    ");

            var newListCountries = new List<string>();
            newListCountries.Add("NEW JERSEY");
            newListCountries.Add("NEW YORK");
            newListCountries.AddRange(new[] { "LONDON", "UNITED KINGDOM", "PARIS", "DUBAI"});

            foreach (string countrys in newListCountries)
            {
                Console.WriteLine($"WITHOUT REMOVE LIST: {countrys}");
                Console.WriteLine("   ");
            }

            newListCountries.RemoveAt(1);
            newListCountries.RemoveAt(4);
            foreach (string countrys in newListCountries)
            {
                Console.WriteLine($"REMOVE LIST: {countrys}");
            }
            Console.WriteLine("   ");

            newListCountries.AddRange(new[] { "PHILIPPINES", "RUSSIA", "QUWAIT" });
            for (var index = 0; index <= listCountries.Count; index++)
            {
                Console.WriteLine($"PHASE {index}:{newListCountries[index]}");
            } */
            #endregion

            #region Even & Odd Numbers Using LINQ
            /*
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var linqEvenNumbers = from number in numbers where number % 2 == 0 select number;
            foreach (var even in linqEvenNumbers)
                Console.WriteLine($"EVEN NUMBERS: {even}");

            var linqOddNumbers = from number in numbers where number % 2 == 1 select number;
            foreach (var odd in linqOddNumbers)
                Console.WriteLine($"ODD NUMBERS: {odd}"); */
            #endregion

            #region Even & Odd Numbers Using LAMBDA
            /*
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var lambdaEvenNumbers = numbers.Where(number  => number % 2 == 0);
            foreach (var even in lambdaEvenNumbers)
                Console.WriteLine($"EVEN NUMBERS; {even}");

            var lambdaOddNumbers = numbers.Where(number => number % 2 == 1);
            foreach (var odd in lambdaOddNumbers)
                Console.WriteLine($"ODD NUMBERS; {odd}"); */
            #endregion

            #region OrderByDescending Using LINQ & LAMBDA
            //var mixedNumbers = new[] { 3, 5, 6, 9 };

            #region Using LINQ
            /*
            var linqQuery = from number in mixedNumbers
                            where number <= 9
                            orderby number descending
                            select $"NUMERO: {number}";
            foreach (var num in linqQuery)
                Console.WriteLine(num); */
            #endregion

            #region Using LAMBDA
            /*
            var lambdaQuery = mixedNumbers
                                .Where(number => number <= 9)
                                .OrderByDescending(number => number)
                                .Select(number => $"NUMERO: {number}");
            foreach (var num in lambdaQuery)
                Console.WriteLine(num); */
            #endregion
            #endregion

            #region Even & Odd Numbers Using Loop and If
            /*
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = new List<int>();
            var oddNumbers = new List<int>();

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);    
                }
                else if (number % 2 == 1)
                {
                    oddNumbers.Add(number);
                }
            }
            foreach (var even in evenNumbers)
            {
                Console.WriteLine($"EVEN NUMBERS: {even}");
            }
            foreach (var odd in oddNumbers)
            {
                Console.WriteLine($"ODD NUMBERS: {odd}");
            }*/
            #endregion

            #region LINQ USING CLASS
            /*
            var students = new List<Student>()
            {
                new Student() { Name = "JIRO", Age = 32, Grade = 1 },
                new Student() { Name = "LAURENZ", Age = 25, Grade = 3},
                new Student() { Name = "AGAD", Age = 30, Grade = 1}
            };
            var sections = new List<Section>()
            {
                new Section() { Grade = 1, SectionName = "Section Argon" },
                new Section() { Grade = 1, SectionName = "Section Barium" }
            };

            
            var query = from section in sections
                        join student in students on section.Grade equals student.Grade
                        where student.Age > 20
                        orderby student.Age, student.Grade
                        select new
                        {
                            section.SectionName,
                            StudentName = student.Name
                        };
            foreach (var sectionAneStudent in query)
                Console.WriteLine($"STUDENT SECTION: {sectionAneStudent.SectionName}, STUDENT NAME: {sectionAneStudent.StudentName}"); */
            #endregion

            #region LAMBDA USING CLASS
            /*
            var lambdaQuery = sections
                                .Join(
                                    students.Where(student => student.Age > 20),
                                    section => section.Grade,
                                    student => student.Grade,
                                    (section, student) => new
                                    {
                                        section.SectionName,
                                        StudentName = student.Name,
                                        student.Age,
                                        student.Grade
                                    }
                                ).OrderBy(student => student.Age).ThenBy(student => student.Grade);
            foreach (var sectionAndStudent in lambdaQuery)
                Console.WriteLine($"SECTION NAME: {sectionAndStudent.SectionName}, STUDENT NAME: {sectionAndStudent.StudentName}"); */
            #endregion

            #region GROUPING USING LINQ & LAMBDA

            #region Variables
            /*
            var students = new List<Student>()
            {
                new Student() { Name = "JIRO", Age = 32, Grade = 1 },
                new Student() { Name = "LAURENZ", Age = 25, Grade = 3},
                new Student() { Name = "AGAD", Age = 30, Grade = 1}
            }; */

            #endregion

            #region USING LINQ
            /*
            var query = from student in students
                        group student by student.Grade into gradeGroup
                        select new GradeCount 
                        { 
                            Grade = gradeGroup.Key,
                            StudentCount = gradeGroup.Count() 
                        };
            foreach (var gradeCount in query)
                Console.WriteLine($"GRADE: {gradeCount.Grade}, COUNT: {gradeCount.StudentCount}"); */
            #endregion

            #region USING LAMBDA
            /*
            var lambda = students.GroupBy(student => student.Grade, student => student)
                .Select(groupCount =>
                    new GradeCount
                    {
                        Grade = groupCount.Key,
                        StudentCount = groupCount.Count()
                    }
                );
            foreach (var gradeCount in lambda)
                Console.WriteLine($"GRADE: {gradeCount.Grade}, COUNT: {gradeCount.StudentCount}"); */
            #endregion

            #endregion

            #region BABY DAMULAG CLASS USING LINQ & LAMBDA

            #region Variables
            /*
            var babies = new List<Babies>()
            {
                new Babies() { Name = "TIFFANY", Age = 18 },
                new Babies() { Name = "LEI", Age = 2 },
                new Babies() { Name = "RHYLE", Age = 2 },
                new Babies() { Name = "EMCI", Age = 1 },
                new Babies() { Name = "SNOW", Age = 12 }
            };
            var babyOrDamulag = new List<BabyDamulag>()
            {
                new BabyDamulag() { BabyOrDamulag = "DAMULAG", Ages = 1},
                new BabyDamulag() { BabyOrDamulag = "BABY", Ages = 18 },
                new BabyDamulag() { BabyOrDamulag = "DAMULAG", Ages = 2},
                new BabyDamulag() { BabyOrDamulag = "DAMULAG", Ages = 12}
            }; */
            #endregion

            #region USING LINQ
            /*
            var query = from baby in babies
                        join babydamulag in babyOrDamulag on baby.Age equals babydamulag.Ages
                        select new
                        {
                            baby.Name,
                            babydamulag.BabyOrDamulag
                        };
            foreach (var babyq in query)
                Console.WriteLine($"{babyq.BabyOrDamulag}: {babyq.Name}"); */
            #endregion

            #region USING LAMBDA
            /*
            var lambdaQuery = babyOrDamulag
                                 .Join(
                                     babies.Where(baby => baby.Age >= 1),
                                     damulagbaby => damulagbaby.Ages,
                                     baby => baby.Age,
                                     (damulagbaby, baby) => new
                                     {
                                         damulagbaby.BabyOrDamulag,
                                         baby.Name,
                                         baby.Age,
                                     }
                                ).OrderByDescending(baby => baby.Age);
            foreach (var babyq in lambdaQuery)
                Console.WriteLine($"{babyq.BabyOrDamulag}: {babyq.Name}"); */
            #endregion

            #endregion

            #region BAGSAK O PASADO CLASS USING LINQ & LAMBDA

            #region Variables
            /*
            var students = new List<Student>()
            {
                new Student() { Name = "TIFFANY", Age = 18, Grade = 99 },
                new Student() { Name = "LEI", Age = 2, Grade = 100 },
                new Student() { Name = "RHYLE", Age = 2, Grade = 65 },
                new Student() { Name = "EMCI", Age = 1, Grade = 75 },  
                new Student() { Name = "SNOW", Age = 12, Grade = 74 }
            };
            var passing = new List<Passing>()
            {
                new Passing() { PassingGrade = "PASANG AWA", GradeToPass = 75 },
                new Passing() { PassingGrade = "BAGSAK", GradeToPass = 74 },
                new Passing() { PassingGrade = "PASADO PA SA PASADO", GradeToPass = 100},
                new Passing() { PassingGrade = "PASADONG PASADO", GradeToPass = 99},
                new Passing() { PassingGrade = "BAGSAK PA SA BAGSAK", GradeToPass = 65}
            }; */
            #endregion

            #region USING LINQ
            /*
            var query = from student in students
                        join pass in passing on student.Grade equals pass.GradeToPass
                        orderby student.Grade descending
                        select new
                        {
                            student.Name,
                            student.Grade,
                            pass = pass.PassingGrade,
                        };
            int ranking = 1;
            foreach (var passbagsak in query)
                Console.WriteLine($"TOP {ranking++}: {passbagsak.Name}: {passbagsak.Grade} = {passbagsak.pass}"); */
            #endregion

            #region USING LAMBDA
            /*
            var lambdaQuery = passing
                                .Join(
                                    students.Where(student => student.Age >= 1),
                                    pass => pass.GradeToPass,
                                    student => student.Grade,
                                    (pass, student) => new
                                    {
                                        pass.PassingGrade,
                                        student.Name,
                                        student.Grade
                                    }
                                ).OrderByDescending(student => student.Grade);
            int ranking = 1;
            foreach (var passbagsak in lambdaQuery)
                Console.WriteLine($"TOP {ranking++}: {passbagsak.Name}: {passbagsak.Grade} = {passbagsak.PassingGrade}"); */
            #endregion

            #endregion

            #region SECTION GROUPING USING LINQ & LAMBDA

            #region Variables
            /*
            var students = new List<Student>()
            {
                new Student() { Name = "LEI", Age = 2, Section = 1 },
                new Student() { Name = "TIFFANY", Age = 18, Section = 1 },
                new Student() { Name = "EMCI", Age = 1, Section = 2 },
                new Student() { Name = "AIEN", Age = 17, Section = 2 },
                new Student() { Name = "SNOW", Age = 12, Section = 2 },
                new Student() { Name = "RHYLE", Age = 2, Section = 3 }
            }; */
            #endregion

            #region USING LINQ
            /*
            var query = from student in students
                        group student by student.Section into sectionGroup
                        select new SectionCount
                        {
                            SectionChar = sectionGroup.Key,
                            StudentCount = sectionGroup.Count()
                        };
            foreach (var sectionCount in query)
                Console.WriteLine($"SECTION: {sectionCount.SectionChar}, COUNT: {sectionCount.StudentCount}"); */
            #endregion

            #region USING LAMBDA
            /*
            var lambdaQuery = students.GroupBy(student => student.Section, student => student)
                .Select(groupCount =>
                    new SectionCount
                    {
                        SectionChar = groupCount.Key,
                        StudentCount = groupCount.Count()
                    }
                );
            foreach (var sectionCount in lambdaQuery)
                Console.WriteLine($"SECTION: {sectionCount.SectionChar}, COUNT: {sectionCount.StudentCount}"); */
            #endregion

            #endregion

            #region LAMBDA ONLY

            #region RANGE
            /*
            var numbers = Enumerable.Range(1, 10);
            Console.WriteLine(string.Join(", ", numbers)); */
            #endregion

            #region BASIC AGGREGATION OF LAMBDA 
            /*
            //AVERAGE
            var average = numbers.Average();
            var num1To5Average = numbers.Where(n => n <= 5).Average();
            Console.WriteLine($"AVERAGE: {average}, AVERAGE OF 1 TO 5: {num1To5Average}");

            //COUNT OR LONG COUNT, USE LONG COUNT WHEN EXPECTED COUNT IS MORE THAN INT CAPACITY
            var count = numbers.Count();

            //MAX AND MIN
            var maxNumber = numbers.Max();
            var minNumber = numbers.Min();

            //SUM
            var summation = numbers.Sum();

            Console.WriteLine($"COUNT: {count}, MAX: {maxNumber}, MIN: {minNumber}, SUM: {summation}"); */
            #endregion

            #region CONVERSION OF LAMBDA
            /*
            var list = new List<int>(numbers);
            var enumValue = list.AsEnumerable(); //CONVERTED TO ENUMERABLE
            var backToList = enumValue.ToList(); //CONVERTED BACK TO LIST

            list = (from number in numbers where number >= 5 select number).ToList(); */
            #endregion

            #region BASIC ELEMENT ACCESS
            /*
            var firstNumber  = numbers.FirstOrDefault();
            var lastNumber = numbers.LastOrDefault();

            var firstEvenNumber = numbers.FirstOrDefault(n => n % 2 == 0);
            var firstOddNumber = numbers.FirstOrDefault(n => n % 2 == 1);

            var firstWithoutDefault = numbers.First();
            var lastWithoutDefault = numbers.Last();

            Console.WriteLine(firstNumber); */
            #endregion

            #region PRACTITIONING
            /*
            var numberSkip5 = numbers.Skip(5);
            var numbersSkipWhile = numbers.SkipWhile(n => n < 5);

            var numberTake5 = numbers.Take(5);
            var numberTakeWhile = numbers.TakeWhile(n => n < 5);

            Console.WriteLine($"SKIP 5: {string.Join(", ", numberSkip5)}");
            Console.WriteLine($"SKIP WHILE: {string.Join(", ", numbersSkipWhile)}");
            Console.WriteLine($"TAKE 5: {string.Join(", ", numberTake5)}");
            Console.WriteLine($"TAKE WHILE: {string.Join(", ", numberTakeWhile)}"); */
            #endregion

            #region QUANTIFIERS
            /*
            var isAll = numbers.All(n => n <= 10);
            var isAny = numbers.Any(n => n == 5);
            var has5 = numbers.Contains(5); */
            #endregion

            #region SET
            
            /*
            var repeatedNumbers = new[] { 1, 2, 3, 1, 5, 1, 1, 2 };
            var distinctNumbers = repeatedNumbers.Distinct();

            Console.WriteLine($"DISTINCT: {string.Join(", ", distinctNumbers)}"); /*

            var excludeNumbers = new[] { 5, 6, 7 };
            var newNumbers = numbers.Except(excludeNumbers);

            Console.WriteLine($"EXCLUDE: {string.Join(", ", newNumbers)}");

            var checkerNumbers = new int[] { 1, 9, 10, 11, 12 };
            var intersectedNumbers = numbers.Intersect(checkerNumbers);

            Console.WriteLine($"INTERSECT: {string.Join(", ", intersectedNumbers)}");

            var appendNumbers = new[] { 10, 11, 12, 13 };
            var unionNumbers = numbers.Union(appendNumbers);
            Console.WriteLine($"UNION: {string.Join(", ", unionNumbers)}"); */
            #endregion

            #endregion

            #region STRING
            /*
            string sampleString;
            string sampleStringWithNullValue = null;
            String stringUsingClass = "TEST";

            var myName = "JIRO"; // REGULAR STRING LITERAL
            myName += " LAURENZ"; // EQUIVALENT TO: myName = myName + " LAURENZ";
            Console.WriteLine("PRINT BY CHARACTERS USING LOOP");
            foreach (var c in myName)
            {
                Console.Write(c);
            }

            char[] nameCharacters = myName.ToCharArray();
            var stringFromArray = new string(nameCharacters); */

            #region VERBATIM STRING LITERAL
            /*
            var stringWithSpecialCharacter = @"""test\only""";
            var stringMultipleLines = @"J
                                        I
                                        R
                                        O";
            Console.WriteLine(stringWithSpecialCharacter);
            Console.WriteLine(stringMultipleLines); */
            #endregion

            #region STRING ESCAPE SEQUENCE
            /*
            var stringWithTabAndNewLine = "my\tname\tis:\nJIRO";
            Console.WriteLine(stringWithTabAndNewLine); */
            #endregion

            #region IMMUTABLE ISSUE
            /*
            var testString = "number ";
            for (var number = 1; number <= 5; number++)
            {
                testString += number;
                Console.WriteLine(testString);
            }
            Console.WriteLine("\n");
            Console.WriteLine("USING NORMAL CONCATENATION");
            Console.WriteLine(testString);
            Console.WriteLine("\n");

            var sb = new StringBuilder();
            sb.Append("number ");
            for (var number = 1; number <= 5; number++)
            {
                sb.Append(number.ToString());
            }
            Console.WriteLine("USING STRINGBUILDER");
            Console.WriteLine(sb.ToString()); */
            #endregion

            #region NUMERIC STANDARD FORMATTING
            /*
            C = CURRENCY
            N = NUMBER
            P = PERCENT
            D = DECIMAL
            */
            /*
            var myNumeric = 12345.678D;
            Console.WriteLine(myNumeric.ToString("C"));
            Console.WriteLine(myNumeric.ToString("N"));
            Console.WriteLine(myNumeric.ToString("P"));

            var myNumber = 123;
            Console.WriteLine(myNumber.ToString("D10"));

            Console.WriteLine("NUMBER WITH 2 DECIMAL PLACES ONLY");
            Console.WriteLine(myNumeric.ToString("N2"));

            Console.WriteLine("CUSTOM");
            Console.WriteLine(myNumeric.ToString("PHP#,##0.00")); */
            #endregion

            #region FORMAT AND INTERPOLATION
            /*
            var name = "JIRO";
            var age = 18;
            var sampleMoney = 54321.12345D; */

            #region USING STRING FORMAT
            /*
            Console.WriteLine("USING STRING FORMAT");
            var stringOutput = string.Format("MY NAME: {0}, AGE: {1}, SAMPLE COMPUTATION: {2}", name, age, 1 + 1);
            Console.WriteLine(stringOutput);
            Console.WriteLine(string.Format("{0:C}", sampleMoney)); */
            #endregion

            #region USING INTERPOLATION
            /*
            Console.WriteLine("USING INTERPOLATION");
            var stringOutputv2 = $"MY NAME: {name}, AGE: {age}, SAMPLE COMPUTATION: {1 + 1}";
            Console.WriteLine(stringOutputv2);
            Console.WriteLine($"{sampleMoney:C}"); */
            #endregion

            #endregion

            #region CHECKER
            /*
            string firstString = null;
            var secondString = string.Empty; // EQUIVALENT TO STRING secondString = "";
            var thirdString = " ";
            if (firstString == null)
                Console.WriteLine("firstString IS NULL");

            // VERSION 1
            if (secondString != null && secondString != string.Empty)
                Console.WriteLine("secondString IS NOT NULL");
            else
                Console.WriteLine("secondString IS EMPTY");

            // VERSION 2
            if (!string.IsNullOrEmpty(secondString))
                Console.WriteLine("V2: secondString IS NOT NULL");
            else
                Console.WriteLine("V2: secondString IS EMPTY");

            // CHECK STRING THAT IS NULL, EMPTY OR BLANK (WHITE SPACES ONLY)
            if (string.IsNullOrWhiteSpace(thirdString))
                Console.WriteLine("thirdString IS: NULL, EMPTY OR BLANK"); */
            #endregion

            #region COMMON CHECKER FUNCTIONS
            /*
            var myNameForChecker = "JIRO";
            if (myNameForChecker.StartsWith("JI"))
                Console.WriteLine("JIRO STARTS WITH JI");
            if (myNameForChecker.EndsWith("O"))
                Console.WriteLine("JIRO ENDS WITH 0");
            if (myNameForChecker.Contains("IR"))
                Console.WriteLine("JIRO CONTAINS WITH IR");

            if (myNameForChecker == "jIRO")
                Console.WriteLine("JIRO IS EQUAL TO JIRO");
            else
                Console.WriteLine("JIRO IS \"NOT\" EQUAL TO JIRO");

            // IGONA CASE
            if (myNameForChecker.Equals("jIRO", StringComparison.InvariantCultureIgnoreCase))
                Console.WriteLine("(IGNORED CASE) JIRO IS EQUAL TO JIRO");
            else
                Console.WriteLine("(IGNORED CASE) JIRO IS \"NOT\" EQUAL TO JIRO"); */
            #endregion

            #region MANIPULATION IN STRING
            /*
            var myString = "programmerTV";
            Console.WriteLine(myString);
            Console.WriteLine($"REVERSE: {new string(myString.Reverse().ToArray())}");
            Console.WriteLine($"REPLACE: {myString.Replace("TV", "TUTORIAL VIDEO")}");
            Console.WriteLine($"SUBSTRING: {myString.Substring(3, 7)}");
            Console.WriteLine($"LOWER CASE: {myString.ToLower()}");
            Console.WriteLine($"UPPER CASE: {myString.ToUpper()}");

            var anotherString = "  fra ce  ";
            Console.WriteLine($"TRIM START: '{anotherString.TrimStart(' ')}'");
            Console.WriteLine($"TRIM END: '{anotherString.TrimEnd(' ')}'");
            Console.WriteLine($"TRIM START AND END: '{anotherString.Trim(' ')}'");
            Console.WriteLine($"TRIM START AND END AND REPLACE: '{anotherString.Trim(' ').Replace(" ", string.Empty)}'");
            Console.WriteLine($"REMOVED SPACES: '{anotherString.Replace(" ", string.Empty)}'");

            var lastString = "JIRO-LAURENZ-PROGRAMMER-TV:String";
            var words = lastString.Split('-');
            var wordsWithMultipleSeperator = lastString.Split(new char[] { '-', ':' });
            foreach (var word in words)
                Console.WriteLine(word);

            foreach (var word in wordsWithMultipleSeperator)
                Console.WriteLine(word);

            Console.WriteLine(string.Join("*", wordsWithMultipleSeperator)); */
            #endregion

            #endregion

            #region DATETIME
            /*
            var now = DateTime.Now;
            var today = DateTime.Today;
            var timeNow = now.TimeOfDay;
            var dateNow = now.Date;

            Console.WriteLine($"NOW: {now}");
            Console.WriteLine($"TODAY: {today}");
            Console.WriteLine($"TIME NOW: {timeNow}");
            Console.WriteLine($"DATE NOW: {dateNow}");

            var myDate = new DateTime(2020, 12, 25);
            Console.WriteLine($"MY DATE: {myDate}"); 

            // FORMATTING
            Console.WriteLine($"FORMATTED: {myDate:MMM dd, yyyy}");
            Console.WriteLine($"FORMATTED DATE NOW: {now:MMM dd, yyyy hh:mm:ss t}");
            Console.WriteLine($"FORMATTED TIME NOW: {now:h:mm:ss t}");

            //COMPUTATION
            var yesterday = now.AddDays(-1);
            var tommorow = now.AddDays(1);
            var days = now.Subtract(myDate).Days;

            Console.WriteLine($"YESTERDAY: {yesterday.ToString("MM/dd/yyyy")}");
            Console.WriteLine($"TOMORROW: {tommorow:MM/dd/yyyy}");
            Console.WriteLine($"now - myDate (NUMBER OF DAYS: {days})");

            // FOR UNIVERSAL
            var utcNow = DateTime.UtcNow;
            Console.WriteLine(utcNow); */
            #endregion

            #region NULLABLE
            /* 
            string myString = null;
            Nullable<int> myNumber = null;
            int? secondnullableInt = null;

            // "Nullable" IS EQUIVALENT TO "Optional". MEANING, OUR INT VARIABLES ARE NOT OPTIONALS.
            // VERSION 1
            if (myNumber != null)
            {
                Console.WriteLine("myNumber IS NOT NULL");
            }
            else
            {
                Console.WriteLine("myNumber IS NULL");
            }

            secondnullableInt = 3;
            //VERSION 2
            if (myNumber.HasValue || secondnullableInt.HasValue)
                Console.WriteLine(secondnullableInt.Value); */

            #endregion

            #region ENUMERATION
            /*
            var boyGender = Gender.Male;
            Console.WriteLine($"GENDER: {boyGender}, GENDER VALUE: {(int)boyGender}");
            switch (boyGender)
            {
                case Gender.Male:
                    Console.WriteLine("MALE");
                    break;
                case Gender.Female:
                    Console.WriteLine("FEMALE");
                    break;
                default:
                    Console.WriteLine("UNKNOWN");
                    break;
            }
            var value = 1;
            Gender genderFromValue = (Gender)value;
            var stringValue = "Male";
            Gender genderFromString = (Gender)Enum.Parse(typeof(Gender), stringValue);
            Console.WriteLine($"GENDER FROM INT: {genderFromValue}");
            Console.WriteLine($"GENDER FROM STRING: {genderFromString}"); */
            #endregion

            #region USING (OWN) LAMBDA ONLY
            /*
            var numbers = Enumerable.Range(1, 10);
            Console.WriteLine(string.Join(", ", numbers));

            var reverse = numbers.Reverse();
            Console.WriteLine(string.Join(", ", reverse));

            var average = numbers.Average();
            var num1To7Average = numbers.Where(n => n <= 7).Average();
            Console.WriteLine($"AVERAGE: {average}, AVERAGE OF 1 TO 7: {num1To7Average}");

            var num1to9Sum = numbers.Where(n => n <= 9).Sum();
            var summation = numbers.Sum();
            Console.WriteLine($"SUMMATION: {summation}, SUM OF 1 TO 9: {num1to9Sum}");

            var count = numbers.Count();
            var maxNumber = numbers.Max();
            var minNumber = numbers.Min();
            Console.WriteLine($"COUNT: {count}, MAX: {maxNumber}, MIN: {minNumber}");

            var firstNumber = numbers.FirstOrDefault();
            var lastNumber = numbers.LastOrDefault();
            Console.WriteLine($"FIRST: {firstNumber}, LAST: {lastNumber}");

            var firstEvenNumber = numbers.FirstOrDefault(n => n % 2 == 0);
            var firstOddNumber = numbers.FirstOrDefault(n => n % 2 == 1);
            Console.WriteLine($"FIRST EVEN: {firstEvenNumber}, FIRST ODD: {firstOddNumber}");

            var numberSkip5 = numbers.Skip(5);
            Console.WriteLine($"SKIP 5: {string.Join(", ", numberSkip5)}");

            var numberSkipLast = numbers.SkipLast(5);
            Console.WriteLine($"SKIP LAST: {string.Join(",", numberSkipLast)}");

            var numberSkipWhile = numbers.SkipWhile(n => n <= 5);
            Console.WriteLine($"SKIP WHILE: {string.Join(",", numberSkipWhile)}");

            var numberTake5 = numbers.Take(5);
            Console.WriteLine($"TAKE 5: {string.Join(", ", numberTake5)}");

            var numberTakeLast = numbers.TakeLast(5);
            Console.WriteLine($"TAKE LAST: {string.Join(", ", numberTakeLast)}");

            var numberTakeWhile = numbers.TakeWhile(n => n <= 5);
            Console.WriteLine($"TAKE WHILE: {string.Join(", ", numberTakeWhile)}");

            Console.WriteLine($"TAKE WHILE AND SKIP WHILE: {string.Join(", ", numberTakeWhile)}, {string.Join(", ", numberSkipWhile)}");

            var isAll = numbers.All(n => n <= 10);
            Console.WriteLine($"ALL IS LESS THAN OR EQUAL TO 10: {isAll}");

            var isAny = numbers.Any(n => n < 5);
            Console.WriteLine($"ANY NUMBERS THAT LESS THAN 5: {isAny}");

            var hasNumber = numbers.Contains(7);
            Console.WriteLine($"CONTAINS: {hasNumber}");

            var repeatedNumbers = new[] { 1, 2, 3, 1, 5, 1, 1, 2 };
            var distinctNumbers = repeatedNumbers.Distinct();
            Console.WriteLine($"DISTINCT: {string.Join(", ", distinctNumbers)}");

            var excludeNumbers = new[] { 5, 6, 7 };
            var newNumbers = numbers.Except(excludeNumbers);
            Console.WriteLine($"EXCLUDE: {string.Join(", ", newNumbers)}");

            var checkerNumbers = new int[] { 1, 9, 10, 11, 12 };
            var intersectedNumbers = numbers.Intersect(checkerNumbers);
            Console.WriteLine($"INTERSECT: {string.Join(", ", intersectedNumbers)}");

            var appendNumbers = new[] { 10, 11, 12, 13 };
            var unionNumbers = numbers.Union(appendNumbers);
            Console.WriteLine($"UNION: {string.Join(", ", unionNumbers)}"); */
            #endregion

            #region USING (OWN) STRING
            /*
            string sampleString;
            string sampleStringWithNullValue = null;
            string stringUsingClass = "TEST";

            var myName = "TIFFANY";
            myName += " KATE";
            Console.Write($"FIRST NAME: {myName}");

            foreach (var chr in myName)
                Console.WriteLine(chr);

            Console.WriteLine("----------");

            char[] nameCharacters = myName.ToCharArray();
            var stringFromArray = new string(nameCharacters);

            foreach (var chr in nameCharacters)
                Console.WriteLine(chr);

            Console.WriteLine(stringFromArray);

            string stringWithSpecialCharacter = @"""test\only""";
            Console.WriteLine(stringWithSpecialCharacter);

            var stringMultipleLines = @"T
                                        I
                                        F
                                        F
                                        A
                                        N
                                        Y";
            Console.WriteLine(stringMultipleLines);

            var stringWithTabAndNewLine = "MY\tNAME\tIS:\nTIFFANY";
            Console.WriteLine($"TAB AND NEW LINE: {stringWithTabAndNewLine}"); 

            var testString = "NUMBER ";
            Console.WriteLine("USING NORMAL CANCATENATION");
            for (var number = 1; number <= 5; number++)
            {
                testString += number;
                Console.WriteLine(testString);
            }
            Console.WriteLine("=============");

            Console.WriteLine("USING STRING BUILDER");
            var sb = new StringBuilder();
            sb.Append("NUMBER ");
            for (var number = 1; number <= 5; number++)
            {
                sb.Append(number.ToString());
            }
            Console.WriteLine(sb.ToString());

            
            C = CURRENCY
            P = PERCENT
            N = NUMBER 
            D = DECIMAL
            

            var myNumeric = 12345.678D;
            Console.WriteLine($"CURRENCY: {myNumeric.ToString("C")}");
            Console.WriteLine($"PERCENT: {myNumeric.ToString("P")}");
            Console.WriteLine($"NUMBER: {myNumeric.ToString("N")}");

            var myNumber = 123;
            Console.WriteLine($"DECIMAL: {myNumber.ToString("D10")}");

            Console.WriteLine($"WITH 2 DECIMAL PLACES ONLY: {myNumeric.ToString("N2")}");

            Console.WriteLine($"CUSTOM: {myNumeric.ToString("PHP#,##0.00")}"); 

            var name = "TIFFANY";
            var age = 18;
            var sampleMoney = 54321.12345D;

            Console.WriteLine("USING STRING FORMAT");
            var stringOutput = string.Format("MY NAME: {0}, AGE: {1}, SAMPLE COMPUTATION: {2}", name, age, 2 + 2);
            Console.WriteLine(stringOutput);
            Console.WriteLine(string.Format("{0:PHP#,##0.00}", sampleMoney));

            Console.WriteLine("===========");

            Console.WriteLine("USING INTERPOLATION");
            var stringOutputV2 = $"MY NAME: {name}, AGE: {age}, SAMPLE COMPUTATION: {2 + 2}";
            Console.WriteLine(stringOutputV2);
            Console.WriteLine($"{sampleMoney:PHP#,##0.00}"); 

            string firstString = null;
            var secondString = string.Empty;
            var thirdString = " ";

            if (firstString == null)
                Console.WriteLine("firstString IS NULL");

            // VERSION 1
            if (secondString != null && secondString != string.Empty)
                Console.WriteLine("secondString IS NOT NULL");
            else
                Console.WriteLine("secondString IS EMPTY");

            // VERSION 2
            if (!string.IsNullOrEmpty(secondString))
                Console.WriteLine("V2: secondString IS NOT NULL");
            else
                Console.WriteLine("V2: secondString IS EMPTY");

            if (string.IsNullOrWhiteSpace(thirdString))
                Console.WriteLine("thirdString IS: NULL, EMPTY OR BLANK"); 

            var myNameForChecker = "TIFFANY";

            if (myNameForChecker.StartsWith("T"))
                Console.WriteLine("TIFFANY STARTS WITH T");

            if (myNameForChecker.EndsWith("Y"))
                Console.WriteLine("TIFFANY ENDS WITH Y");

            if (myNameForChecker.Contains("ANY"))
                Console.WriteLine("TIFFANY CONTAINS ANY");

            if (myNameForChecker == "tIFFANY")
                Console.WriteLine("TIFFANY IS EQUAL TO tIFFANY");
            else
                Console.WriteLine("TIFFANY IS \"NOT\" EQUAL TO tIFFANY");

            // IGONA CASE
            if (myNameForChecker.Equals("tIFFANY", StringComparison.InvariantCultureIgnoreCase))
                Console.WriteLine("IGNORED CASE: TIFFANY IS EQUAL TO tIFFANY");
            else
                Console.WriteLine("IGNORED CASE: TIFFANY IS \"NOT\" EQUAL TO tIFFANY"); 

            var myString = "TIFFANY KATE";
            Console.WriteLine(myString);

            Console.WriteLine($"REVERSE: {new string(myString.Reverse().ToArray())}");
            Console.WriteLine($"REPLACE: {new string(myString.Replace("KATE", "DELA CRUZ"))}");
            Console.WriteLine($"SUBSTRING: {myString.Substring(4, 3)}");
            Console.WriteLine($"LOWER CASE: {myString.ToLower()}");

            var anotherString = "  TI FFANY  ";
            Console.WriteLine($"TRIM START: '{anotherString.TrimStart(' ')}'");
            Console.WriteLine($"TRIM END: '{anotherString.TrimEnd(' ')}'");
            Console.WriteLine($"TRIM START, END AND REPLACE: '{anotherString.Trim(' ').Replace(" ", string.Empty)}'");
            Console.WriteLine($"REMOVED PLACES: '{anotherString.Replace(" ", string.Empty)}'");

            var lastString = "TIFFANY-KATE-DELA:CRUZ";
            var words = lastString.Split('-');
            foreach (var word in words)
                Console.WriteLine(word);

            var wordsWithMultipleSeperator = lastString.Split(new char[] { '-', ':' });
            foreach (var word in wordsWithMultipleSeperator)
                Console.WriteLine(word);

            Console.WriteLine(string.Join("*", wordsWithMultipleSeperator)); */
            #endregion

            #region USING (OWN) DATETIME
            /*
            var now = DateTime.Now;
            Console.WriteLine($"CURRENT DATE TIME: {now}");

            var today = DateTime.Today;
            Console.WriteLine($"TODAY DATE TIME: {today}");

            var timeNow = now.TimeOfDay;
            Console.WriteLine($"CURRENT TIME: {timeNow}");

            var dateNow = now.Date;
            Console.WriteLine($"CURRENT DATE: {dateNow}");

            var myDate = new DateTime(2004, 05, 28);
            Console.WriteLine($"BUM'S BIRTH DATE: {myDate}");

            var myBirth = new DateTime(2003, 12, 28);
            Console.WriteLine($"MY BIRTH DATE: {myBirth}");

            Console.WriteLine("=============");
            Console.WriteLine("FORMATTING");

            Console.WriteLine($"FORMATTED BUM'S BIRTH DATE: {myDate:MMMM dd, yyyy}");

            Console.WriteLine($"FORMATTED CURRENT DATE: {now:MMMM dd, yyyy}");

            Console.WriteLine($"FORMATTED CURRENT TIME: {now:h:mm:ss t}");

            Console.WriteLine("=============");
            Console.WriteLine("COMPUTATION");

            var yesterday = now.AddDays(-1);
            Console.WriteLine($"YESTERDAY DATE: {yesterday.ToString("MM/dd/yyyy")}");

            var tomorrow = now.AddDays(1);
            Console.WriteLine($"TOMORROW DATE: {tomorrow.ToString("MM/dd/yyyy")}");

            var days = now.Subtract(myDate).Days;
            Console.WriteLine($"DAYS FROM MY BUM'S BIRTH DATE: {days}");

            var birthDays = now.Subtract(myBirth).Days;
            Console.WriteLine($"DAYS FROM MY BIRTH DATE: {birthDays}");

            Console.WriteLine("=============");
            Console.WriteLine("FOR UNIVERSAL");

            var utcNow = DateTime.UtcNow;
            Console.WriteLine($"CURRENT UTC: {utcNow}"); */

            #endregion

            #region USING (OWN) NULLABLE
            /*
            string myString = null;
            Nullable<int> myNumber = null;
            int? secondNullableInt = null;
            
            // VERSION 1
            if (myNumber != null)
            {
                Console.WriteLine("myNumber IS NOT NULL");
            }
            else
            {
                Console.WriteLine("myNumber IS NULL");
            }

            secondNullableInt = 3;
            // VERSION 2
            if (myNumber.HasValue || secondNullableInt.HasValue)
                Console.WriteLine(secondNullableInt.Value); */

            #endregion

            #region USING (OWN) ENUMERATION
            /*
            var femaleGender = Gender.Female;
            Console.WriteLine($"GENDER: {femaleGender}, GENDER VALUE: {(int)femaleGender}");

            switch (femaleGender)
            {
                case Gender.Female:
                    Console.WriteLine("FEMALE");
                    break;
                case Gender.Male:
                    Console.WriteLine("MALE");
                    break;
                default:
                    Console.WriteLine("UNKNOWN");
                    break;
            }

            var value = 1;
            Gender genderFromValue = (Gender)value;
            Console.WriteLine($"GENDER FROM INT: {genderFromValue}");

            var stringValue = "Male";
            Gender genderFromString = (Gender)Enum.Parse(typeof(Gender), stringValue);
            Console.WriteLine($"GENDER FROM STRING: {genderFromString}"); */

            #endregion

            #region FUNCTION AND PARAMETERS
            /*
            var program = new TrainingGround();
            program.PrintName();
            program.PrintNameWithParam("TIFFANY KATE");
            program.PrintNameWithAge("JIRO LAURENZ", 18);
            */

            #region USING PARAMS KEYWORD
            /*
            var programOne = new TrainingGround();
            programOne.PrintNumbers("1", "4", "3");
            */
            #endregion

            #region OPTIONAL AND WITH DEFAULT VALUE OF PARAMETERS
            /*
            var programTwo = new TrainingGround();

            programTwo.ProcessNumbers(2);
            Console.WriteLine("============");
            programTwo.ProcessNumbers(5, secondNumber: 3);
            Console.WriteLine("============");
            programTwo.ProcessNumbers(10, name: "TIFFANY");
            Console.WriteLine("============");
            programTwo.ProcessNumbers(28, 12, "JIRO");
            */
            #endregion

            #region FUNCTION SHORT CUT
            /*
            var programThree = new TrainingGround();
            programThree.PrintMyName("TIFFANY KATE");

            // STATIC
            TrainingGround.MyStaticPrintName("JIRO LAURENZ");
            */
            #endregion

            #region FUNCTION WITH RETURN VALUE
            /*
            var programFour = new TrainingGround();
            var sumOf2And4 = programFour.AddTwoNumbers(2, 4);
            Console.WriteLine($"SUM OF 2 AND 4: {sumOf2And4}");

            Console.WriteLine($"SAMPLE RESULT: {programFour.AddNumbers(5, Operator.Add, 2, 3, 4)}");
            */
            #endregion

            #region USING REFERENCE KEYWORD IN PARAMETER
            /*
            var string1 = "DEMO";
            var string2 = "DEMO";
            program.ModifyText(ref string2);
            Console.WriteLine($"{string1}{string2}");
            */
            #endregion

            #region OUT PARAMETER
            /*
            string errorMessage;
            var result1 = program.Process(10, 2, out errorMessage);
            if (string.IsNullOrEmpty(errorMessage))
                Console.WriteLine($"RESULT 1: {result1}");
            else
                Console.WriteLine($"RESULT 1 ERROR: {errorMessage}");
            */
            #endregion

            #region RECURSIVE (FACTORIAL)
            /*
            // FACTORIAL OF 3 = 3 * 2 * 1
            Console.WriteLine($"FACTORIAL OF 3: {program.SampleFactorial(3)}");

            // FACTORIAL OF 5 = 5 * 4 * 3 * 2 * 1
            Console.WriteLine($"FACTORIAL OF 5: {program.SampleFactorial(5)}");
            */
            #endregion

            #endregion

            #region MAKING OWN ENUMERATION
            /*
            Console.WriteLine((int)Names.LEI);
            Console.WriteLine((Names)1);
            Console.WriteLine(Names.TIFFANY.ToString());
            Console.WriteLine((Names)18); */

            #endregion

            #region USING (OWN) FUNCTION AND PARAMETERS
            /*
            var program = new TrainingGround();
            program.Names();
            program.NamesWithParams("TIFFANY", 18);
            program.NumbersParams("2", "4", "6", "8", "10");
            program.NamesParams("TIFFANY", "LEI", "RHYLE", "SNOW", "EMCI");
            program.OptionalParams(18);
            program.MyName("TIFFANY");
            TrainingGround.StaticName("TIFFANY", 18);
            Console.WriteLine(program.ReturnNumbers(5, 10));
            Console.WriteLine(program.ReturnAddNumbers(5, "*", 10, 10));
            program.ReturnWithVoid(0);
            var name = "TIFFANY";
            var names = " KATE";
            program.UsingReference(ref names);
            Console.WriteLine(name + names);
            string errorMessages;
            var result1 = program.OutProcess(10, 0, out errorMessages);
            Console.WriteLine(result1);

            if (string.IsNullOrEmpty(errorMessages))
                Console.WriteLine($"RESULT 1: {result1}");
            else
                Console.WriteLine($"RESULT 1 ERROR: {errorMessages}");

            Console.WriteLine($"FACTORIAL OF 5: {program.SamplesFactorial(5)}"); */
            #endregion

            #region CLASS

            #region NOT USING A CLASS
            /*
            string firstNameJuan;
            string lastNameJuan;

            string firstNamePedro;
            string lastNamePedro;
            */
            #endregion

            #region USING A CLASS
            /*
            var juan = new Person();
            juan.FirstName = "JUAN";
            juan.LastName = "BAUTISTA";

            var pedro = new Person()
            {
                FirstName = "PEDRO",
                LastName = "PENDUKO"
            };

            var maria = new Person("MARIA")
            {
                LastName = "CLARA"
            };

            var tiffany = new Person("TIFFANY", "KATE");
            */
            #endregion
            /*
            var person = new Person("TIFFANY", "KATE")
            {
                NickName = "ANNIE",
                BirthDate = new DateTime(2004, 5, 28)
            };
            person.NickNameHandler += NickNameChanging;
            person.Update(10, "LEI");
            Console.WriteLine($@"
                                NAME: {person.FullName}
                                AGE: {person.GetAge()}
                                NICKNAME: {person.NickName}
                                SAMPLE INT: {person.Sample}");
            */
            #endregion

            #region STRUCT
            /*
            var apple = new Fruit() { Name = "APPLE", Color = "RED" };
            var mango = new Fruit("MANGO", "YELLOW");

            Console.WriteLine(mango.Name); */

            #endregion

            #region DELEGATE
            /*
            var kate = new Person("TIFFANY", "KATE")
            {
                NickName = "ANNIE"
            };
            kate.FavoriteFruits.Add(new Fruit("BANANA", "YELLOW"));

            kate.AddFavoriteFruit(new Fruit("MANGO", "YELLOW"), AddedNewFruit);
            kate.DeleteFavoriteFruit(kate.FavoriteFruits[0], (prutas) => {
                Console.WriteLine($"DELETED FRUIT: {prutas.Name}");
                return 1;
            });
            Console.WriteLine($"** ---{kate.FullName}--- Favorite Fruits**");
            foreach (var pagkain in kate.FavoriteFruits)
                Console.WriteLine($"-> {pagkain.Name}"); */

            #endregion

            #region DEBUGGING
            /*
            var binary1 = "00001111"; //15
            var binary2 = "01000001"; //65

            var firstBits = GetBitValues(binary1);
            var secondBits = GetBitValues(binary2);

            Console.WriteLine($"BINARY 1: {binary1}, {string.Join(", ", firstBits)}: {firstBits.Sum()}");
            Console.WriteLine($"BINARY 2: {binary2}, {string.Join(", ", secondBits)}: {secondBits.Sum()}");
            */
            #endregion

            #region EXCEPTION/ ERROR HANDLING
            /*
            var number1 = 100;
            var number2 = 50;
            var number3 = 0;

            try
            {
                Console.WriteLine($"ADDITION RESULT: {number1 + number2}");
                Console.WriteLine($"ADDITION RESULT: {number1 / number3}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("CANNOT DIVIDE BY ZERO");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("FINALLY! TAPOS NA ANG TRY AND CATCH");
            } */

            #region ERROR NOTIFICATION
            /*
            AppDomain.CurrentDomain.FirstChanceException += (sender, args) =>
            {
                if (args.Exception is WalangFirstNameException)
                {
                    Console.WriteLine("(FROM EVENT) WalangFirstNameException ERROR");
                }
            };
            */
            #endregion

            #region CUSTOM EXCEPTION
            /*
            try
            {
                string firstName = null;
                string lastName = "DELA CRUZ";

                if (string.IsNullOrWhiteSpace(firstName))
                    throw new WalangFirstNameException();

                Console.WriteLine(firstName.ToLower());
                Console.WriteLine(lastName.ToLower());
            }
            catch (WalangFirstNameException ex)
            {
                Console.WriteLine("DOES NOT HAVE FIRST NAME");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("CANNOT USE THE FUNCTION IF IT IS NULL");
            }
            catch
            {
                Console.WriteLine("OTHER EXCEPTIONS");
            } */
            #endregion

            #endregion

            #region USING OOP, ABS vs INT & GEN

            #region OOP
            #region OOP - ENCAPSULATION

            var iphone13 = new IPhone();
            iphone13.Color = "SILVER";
            iphone13.Shape = "SQUARE";
            iphone13.PowerOn();
            #endregion

            #region OOP - POLYMORPHISM
            /*
            new SampleOperation()
                .Process(); */
            #endregion
            #endregion

            #region ABSTRACT VS INTERFACE
            /*
            var pdf = new PDF();
            var word = new MSWord();
            Document pdfDoc = new PDF();
            Document WordDoc = new MSWord();

            var excel = new Excel();
            IDokumento dokumentoExcel = new Excel();
            dokumentoExcel.Print();

            MSWord newWord = new NewDocumnet();
            IDoc1 doc1Excel = new NewDocumnet();
            IDoc2 doc2Excel = new NewDocumnet();
            */
            #endregion

            #region GENERIC
            /*
            var processor = new SampleGeneric<TagaMultiply>();
            processor.Process(9, 9);
            var processorDiv = new SampleGeneric<TagaDivide>();
            processorDiv.Process(9, 9);

            var newProcessor = new SampleMultipleType<TagaAdd, SampleGeneric<TagaMinus>>();
            newProcessor.Executed(10, 5);
            */
            #endregion

            #endregion

            #region USING OOP
            /*
            Console.WriteLine("===WITHOUT OOP===");
            new SimpleOperationWithoutOOP().Process();
            Console.WriteLine("===WITH OOP===");
            new SimpleOperationWithOOP().Process();
            */
            #endregion

            #region SOLID PRINCIPLE

            #region S(O)LID PRINCIPLE
            /*
            Console.WriteLine("===(NON)-OpenClosed===");
            new SimpleCalculator()
                .Calculate(new Operation[]
                {
                    new Add() {A = 5, B = 5},
                    new Subtract() {A = 5, B = 5}
                });

            Console.WriteLine("===(USING)-OpenClosed===");
            new SimpleCalculatorV2()
                .Calculate(new IOperation[]
                {
                    new AddV2() {A = 5, B = 5},
                    new SubtractV2() {A = 5, B = 5}
                });
            */
            #endregion

            #endregion
        }

        #region BINARY CODES FOR DEBUGGING

        public static IEnumerable<int> GetBitValues(string binaryValue)
        {
            return binaryValue
                .Reverse()
                .Select((value, index) =>
                {
                    return value == '1' ? (int)Math.Pow(2, index) : 0;
                })
                .Reverse();
        }

        #endregion

        #region METHODS

        #region ADDING NEW FRUITS

        private static int AddedNewFruit(Fruit prutas)
        {
            Console.WriteLine($"ADDED FRUIT: {prutas.Name}");
            return 1;
        }
        #endregion

        #region EVENT CLASS (NICKNAME CHANGING)
        private static void NickNameChanging(object sender, NickNameArgs agrs)
        {
            Console.WriteLine($"NICKNAME IS CHANGING TO: {agrs.NickName}");
        }
        #endregion

        #endregion

        #region FUNCTION AND PARAMETERS

        // VOID WITHOUT PARAMETER
        public void PrintName()
        {
            Console.WriteLine("USING PRINTNAME()");
            var name = "ANY NAME";
            Console.WriteLine($"NAME: {name}");
        }

        public void PrintNameWithParam(string name)
        {
            Console.WriteLine("USING PrintNameWithParam(string name)");
            Console.WriteLine($"NAME: {name}");
        }
        public void PrintNameWithAge(string name, int age)
        {
            Console.WriteLine("PrintNameWithAge(string name, int age");
            Console.WriteLine($"NAME: {name}, AGE: {age}");
        }
        public void PrintNumbers(params string[] numbers)
        {
            Console.WriteLine(string.Join(", ", numbers));
        }
        public void ProcessNumbers(long firstNumber, int? secondNumber = null, string name = "TIFFANY KATE")
        {
            Console.WriteLine($"FIRST: {firstNumber}, SECOND: {(secondNumber.HasValue ? secondNumber.Value : string.Empty)}");
            Console.WriteLine($"NAME: {name}");
        }
        public void PrintMyName(string myName) => Console.WriteLine(myName);

        public static void MyStaticPrintName(string name) => Console.WriteLine($"USING STATIC: {name}");

        public int AddTwoNumbers(int number1, int number2)
        {
            Console.WriteLine($"NUMBER ONE: {number1}, NUMBER TWO: {number2}");

            return number1 + number2;
        }

        public int AddNumbers(int num1, Operator op = Operator.Add, params int[] otherNumbers)
        {
            var sumOfOtherNumbers = otherNumbers.Sum();
            switch (op)
            {
                case Operator.Add: return num1 + sumOfOtherNumbers;
                case Operator.Subtract: return num1 - sumOfOtherNumbers;
                case Operator.Multiply: return num1 * sumOfOtherNumbers;
                case Operator.Divide: return num1 / sumOfOtherNumbers;
                default: return 0;
            }
        }

        public void ReturnRightAwaySample(int num)
        {
            Console.WriteLine("START PROCESS");
            if (num == 0)
            {
                Console.WriteLine("TERMINATE PROCESS");
                return;
            }

            Console.WriteLine($"END PROCESS FOR NUM: {num}");
        }

        public void ModifyText(ref string demo)
        {
            demo = " JIRO";
        }

        public int Process(int a, int b, out string messages)
        {
            messages = null;
            if (b == 0)
            {
                messages = "CAN'T DIVIDE BY 0";
                return 0;
            }
            return a / b;
        }

        public int SampleFactorial (int number)
        {
            if (number == 1)
                return number;

            return number * SampleFactorial(number - 1);
        }

        #endregion

        #region OWN FUNCTION AND PARAMETERS

        public void Names()
        {
            var name = "TIFFANY";
            Console.WriteLine($"MY BUM BUM IS {name}");
        }
        public void NamesWithParams(string name, int age)
        {
            Console.WriteLine($"MY BUM BUM IS {name} AND SHE IS {age} YEARS OF AGE");
        }
        public void NumbersParams(params string[] numbers)
        {
            Console.WriteLine(string.Join("-", numbers));
        }
        public void NamesParams(params string[] names)
        {
            Console.WriteLine(string.Join("\n", names));
        }
        public void OptionalParams(int number, int? numbers = null, string name = "TIFFANY")
        {
            Console.WriteLine($"NUMBER: {number}, NUMBERS: {(numbers.HasValue ? numbers.Value : numbers = 0)}, NAME: {name}");  
        }
        public void MyName(string myName) => Console.WriteLine(myName);
        public static void StaticName(string name, int age) => Console.WriteLine($"NAME: {name}, AGE: {age}");
        public int ReturnNumbers(int number1, int number2)
        {
            Console.WriteLine("RETURN NUMBER: ");

            return number1 + number2;
        }
        public int ReturnAddNumbers(int number1, string op = "+", params int[] multipleNumbers)
        {
            var allOfMultipleNumbers = multipleNumbers.Sum();
            switch (op)
            {
                case "+": return number1 + allOfMultipleNumbers;
                case "-": return number1 - allOfMultipleNumbers;
                case "*": return number1 * allOfMultipleNumbers;
                case "/": return number1 / allOfMultipleNumbers;
                default: return 0;
            }

        }
        public void ReturnWithVoid(int number)
        {
            Console.WriteLine("STARTING PROCESS");
            if (number == 0)
            {
                Console.WriteLine("TERMINATING PROCESS");
                return;
            }

            Console.WriteLine("END PROCESS: " + number);
        }
        public void UsingReference(ref string names)
        {
            names = " DELA CRUZ";
        }
        public int OutProcess(int a, int b, out string messages)
        {
            messages = null;
            if (a == 0 || b == 0)
            {
                messages = "CAN'T DIVIDE BY ZERO";
                return 0;
            }
            return a / b;
        }
        public int SamplesFactorial(int number)
        {
            if (number == 1)
                return number;

            return number * SamplesFactorial(number - 1);
        }

        #endregion

    }

    #region FOR UNIT TESTING

    public class SampleComputation
    {
        public int Compute(int num1, int num2, SampleOperator op)
        {
            switch (op)
            {
                case SampleOperator.Add: return num1 + num2;
                case SampleOperator.Divide: return num1 / num2;
            }

            return 0;
        }
    }

    public enum SampleOperator
    {
        Add,
        Subtract,
        Divide,
        Multiply
    }

    #endregion

    #region ANOTHER CLASS  
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        public int Section { get; set; }
    }
    public class Section
    {
        public string SectionName { get; set; }
        public int Grade { get; set; }
    } 
    public class Passing
    {
        public string PassingGrade { get; set; }
        public int GradeToPass { get; set; }
    }
    public class GradeCount
    {
        public int Grade { get; set; }
        public int StudentCount { get; set; }
    }
    public class Babies
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class BabyDamulag
    {
        public string BabyOrDamulag { get; set; }
        public int Ages { get; set; }
    }
    public class SectionCount
    {
        public int SectionChar { get; set; }
        public int StudentCount { get; set; }
    }
    #endregion

    #region ENUM GENDER
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }
    #endregion 

    #region ENUM OPERATOR
    public enum Operator
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
    #endregion
    
    #region ENUM NAMES
    public enum Names
    {
        TIFFANY = 18,
        LEI = 2,
        RHYLE = 2,
        SNOW = 12,
        EMCI = 1,
        JIRO = 181,
        AIEN = 17,
        JULIUS = 13
    }
    #endregion

}
