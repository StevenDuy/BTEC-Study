using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_OCP
{
    public interface IShape
    {
        string ShapeName { get; }
        double Area();
    }
}
