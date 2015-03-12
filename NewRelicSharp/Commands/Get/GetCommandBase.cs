using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NewRelicSharp.Commands.Get
{
    public abstract class GetCommandBase : IApiCommand
    {
        public abstract string GetQuery();

        /// <summary>
        /// DEPRICATED for Get requests
        /// </summary>
        /// <returns></returns>
        public string GetContent()
        {
            throw new InvalidOperationException("Content is not allowed for GET requests");
        }

        public HttpMethod Method
        {
            get { return HttpMethod.Get; }
        }
    }
}
