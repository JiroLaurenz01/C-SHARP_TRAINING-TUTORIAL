using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAINING
{
    public abstract class MobilePhone
    {
        private string _microChip;

        public string Shape { get; set; }
        public string Color { get; set; }

        public void PowerOn()
        {
            ConnectMainboardToPowerSupply();
            OpenWfiChip();
        }
        private void ConnectMainboardToPowerSupply() { }
        private void OpenWfiChip() { }
    }
}
