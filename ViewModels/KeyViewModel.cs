using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewProblem.ViewModels
{
    public class KeyViewModel
    {
        List<string> values = new List<string>();
        public List<KeyViewModel> SubKeys { get; } = new();

        public string name { get; }

        public KeyViewModel(string keyName)
        {
            name = keyName;

            if (!name.Contains("test"))
                SubKeys.Add(new KeyViewModel("test"));
            else if (name == "test")
                SubKeys.Add(new KeyViewModel("test2"));
        }
    }
}
