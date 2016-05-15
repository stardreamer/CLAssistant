using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursedSpider.Prays;

namespace CursedSpider.Sources
{
    internal abstract class Source
    {
        virtual public IEnumerable<Pray> Prays { get; }
    }
}
