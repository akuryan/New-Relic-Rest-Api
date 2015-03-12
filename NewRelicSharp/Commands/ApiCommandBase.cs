using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NewRelicSharp.Commands
{
    public abstract class ApiCommandBase : IApiCommand
    {
        public abstract string GetQuery();
        public abstract string GetContent();

        public virtual HttpMethod Method
        {
            get { throw new NotImplementedException(); }
        }
    }
}
