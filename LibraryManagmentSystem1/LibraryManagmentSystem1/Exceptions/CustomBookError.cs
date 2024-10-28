using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem1.Exceptions
{
    public class CustomBookError : Exception
    {
        public CustomBookError(int index): base($"There are no books with this index in the catalog") { }

    }
}
