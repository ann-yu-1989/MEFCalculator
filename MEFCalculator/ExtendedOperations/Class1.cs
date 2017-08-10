using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
namespace ExtendedOperations
{
    public class Class1
    {
    }
    [Export(typeof(MEFCalculator.IOperation))]
    [ExportMetadata("Symbol", '%')]
    public class Mod : MEFCalculator.IOperation
    {
        public int Operate(int left, int right)
        {
            return left % right;
        }
    }
}
