using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string msg) : base(data, true, msg)
        {

        }
        public SuccessDataResult(T data) : base(data, true)
        {

        }
        public SuccessDataResult(string msg) : base(default, true, msg)
        {

        }
        public SuccessDataResult(List<global::Entities.Concrete.Category> categories) : base(default, true)
        {

        }

    }
}