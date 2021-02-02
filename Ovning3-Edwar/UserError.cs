using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3_Edwar
{
    abstract class UserError
    {
        public abstract string UEMessage();
    }
    class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return ("You tried to use a numberic input in a text only field. This fired an error!");
        }
    }
    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return ("You tried to use a numberic input in a text only field. This fired an error!");
        }
    }
}
