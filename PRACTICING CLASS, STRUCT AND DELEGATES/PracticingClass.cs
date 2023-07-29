using System.Drawing;

namespace Practicing
{
    public class PracticingClass
    {
        #region PROFILES INFORMATION

        #region PROPERTIES 

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get 
            { 
                return $"{FirstName} {LastName}"; 
            }
        }

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

        #endregion

        #region CONSTRUCTOR

        public PracticingClass()
        {
        }

        public PracticingClass(string first)
        {
            FirstName = first;
        }

        public PracticingClass(string first, string last): this(first)
        {
            LastName = last;
        }

        #endregion

        #region METHODS FOR UPDATE

        public void Update(string nickName)
        {
            NickName = nickName;
            //3
            NickNameHandler?.Invoke(this, new NickNameArgs { NickName = nickName });
        }

        public int? GetAge()
        {
            if (BirthDate.HasValue)
            {
                return (int?)((DateTime.Now - BirthDate.Value).TotalDays / 365);
            }

            return default;
        }

        #endregion

        #region EVENTS FOR NICKNAME CHANGING
        //2
        public event EventHandler<NickNameArgs> NickNameHandler;
        
        #endregion

        #endregion

        #region FRUITS
        //3
        public List<Fruit> FavoriteFruits { get; set; } = new List<Fruit>();
        //4
        public void AddFavoriteFruit (Fruit fruit, ProcessFruitDelegate successCallBack)
        {
            FavoriteFruits.Add(fruit);
            successCallBack(fruit);
        }
        //5
        public void DeleteFavoriteFruit (Fruit fruit, ProcessFruitDelegate successCallBack)
        {
            FavoriteFruits.Remove(fruit);
            successCallBack(fruit);
        }

        #endregion
    }

    public class NickNameArgs: EventArgs
    {
        //1
        public string NickName { get; set; }
    } 

    public struct Fruit //1
    {
        public Fruit (string name, string color)
        {
            Name = name;
            Color = color;
        }
        public string Name { get; set; }
        public string Color { get; set; }
    }
}
