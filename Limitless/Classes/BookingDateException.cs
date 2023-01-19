using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limitless.Classes
{
    public class BookingDateException: Exception
    {
        public BookingDateException(string bdeMessage):base(bdeMessage) { }
    }
}
