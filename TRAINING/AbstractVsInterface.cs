using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAINING
{
    public abstract class Document
    {
        public string Name { get; set; }
        public void Process()
        {
        }
        public abstract void Print();
    }
    public class PDF: Document
    {
        public override void Print() {}
    }
    public class MSWord: Document
    {
        public override void Print() {}
    }

    public interface IDokumento
    {
        string Name { get; set; }
        void Process();
        void Print();
    }
    
    public class Excel: IDokumento
    {
        public string Name { get; set; }
        public void Print() {}
        public void Process() {}
    }

    public interface IDoc1 { }
    public interface IDoc2 { }

    public class NewDocumnet: MSWord, IDoc1, IDoc2 {
    }
}
