using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NewRelicSharp.Commands
{
    /// <summary>
    /// 
    /// </summary>
    public interface IApiCommand
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string GetQuery();

        /// <summary>
        /// Used for POST requests only
        /// </summary>
        /// <returns>Content of POST request</returns>
        string GetContent();

        /// <summary>
        /// Http Method
        /// </summary>
        HttpMethod Method { get; }
    }
}
