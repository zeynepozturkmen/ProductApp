using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException():base("Validation error occurred")
        {

        }
        public ValidationException(String Message):base(Message)
        {

        }
        //this(ex.Message) -> ValidationException(String Message) bu ctor'u cagırıyor. 
        //this(ex.Message) tıklayınca ValidationException(String Message) bu ctor'u isaretliyor
        public ValidationException(Exception ex):this(ex.Message)
        {

        }
    }
}
