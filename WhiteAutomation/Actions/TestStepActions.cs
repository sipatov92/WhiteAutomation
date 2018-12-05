using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteAutomation.Actions
{
    public class TestStepActions<T> where T: class, new()
    {
        private static Lazy<T> instance = new Lazy<T>(()=>new T());

        public static T Instance
        {
            get { return (T) instance.Value; }
        }
    }
}
