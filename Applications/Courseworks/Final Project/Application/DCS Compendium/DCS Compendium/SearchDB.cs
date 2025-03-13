using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCS_Compendium
{
    public class SearchDB
    {
        private static string _searchInput;

        public SearchDB()
        {

        }

        public static string SearchInstance
        {
            get
            {
                if (_searchInput == null)
                    _searchInput = string.Empty;
                return _searchInput;
            }
            set
            {
                _searchInput = value; // Allow updating the shared search input
            }
        }
        public string SearchInput
        {
            get; set;
        }
    }
}
