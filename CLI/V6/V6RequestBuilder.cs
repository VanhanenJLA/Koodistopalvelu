// <auto-generated/>
#pragma warning disable CS0618
using ApiSdk.V6.Classifications;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace ApiSdk.V6
{
    /// <summary>
    /// Builds and executes requests for operations under \v6
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class V6RequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// The classifications property
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildClassificationsNavCommand()
        {
            var command = new Command("classifications");
            command.Description = "The classifications property";
            var builder = new global::ApiSdk.V6.Classifications.ClassificationsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.V6.V6RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public V6RequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/v6", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.V6.V6RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public V6RequestBuilder(string rawUrl) : base("{+baseurl}/v6", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
