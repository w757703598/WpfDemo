using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Binding的数据转换
{
    public enum Category
    {
        Bomber,
        Fighter
    }

    public enum State
    {
        Avaliable,
        Locked,
        Unknown
    }
    public class Plane
    {
        public Category Category { get; set; }
        public string Name { get; set; }
        public State State { get; set; }
    }
}
