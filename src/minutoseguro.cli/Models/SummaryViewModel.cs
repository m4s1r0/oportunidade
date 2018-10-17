using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minutoseguro.cli.Models
{
    public class SummaryViewModel
    {
        public SummaryViewModel()
        {
            Words = new List<WordViewModel>();
        }

        public List<WordViewModel> Words { get; set; }
        public int QtdWords { get; set; }
    }
}
