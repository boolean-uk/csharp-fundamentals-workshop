using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.console
{
    public class BooleanFest
    {
        private List<Band> _bands;

        public BooleanFest(List<Band> bands)
        {
            _bands = bands;
        }

        public List<Band> Bands { get { return _bands; } }
        public List<Band> BandsByNetWorth { get { return _bands.OrderByDescending(band => band.BandNetWorth).ToList(); } }
       
    }
}
