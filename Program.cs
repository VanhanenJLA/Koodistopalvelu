using System.CommandLine.Builder;
using System.CommandLine.Parsing;
using ApiSdk;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Text;

var rootCommand = new ApiClient().BuildRootCommand();
rootCommand.Description = "Koodistopalvelin CLI";

var builder = new CommandLineBuilder(rootCommand)
    .UseDefaults()
    .UseRequestAdapter(context =>
    {
        var authProvider = new AnonymousAuthenticationProvider();
        var adapter = new HttpClientRequestAdapter(authProvider);
        adapter.BaseUrl = "https://koodistopalvelu.kanta.fi/codeserver/csapi";

        // Register default serializers
        ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
        ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
        ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();

        // Register default deserializers
        ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
        ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
        ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();

        return adapter;
    }).RegisterCommonServices();

return await builder.Build().InvokeAsync(args);