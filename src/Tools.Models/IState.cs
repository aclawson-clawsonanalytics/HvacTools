using System;
using System.Collections.Generic;
using System.Text;

namespace Tools.Models
{
    public interface IState
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}
