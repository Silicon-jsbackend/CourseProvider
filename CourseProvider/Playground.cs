using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Runtime.InteropServices;

namespace CourseProvider;

public class Playground(ILogger<Playground> logger)
{
    private readonly ILogger<Playground> _logger = logger;

    [Function("Playground")]
    public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = "graphql")] HttpRequestData req)
    {
        var response = req.CreateResponse();
        response.Headers.Add("Content-Type", "text/html; charset=utf-8");
        await response.WriteStringAsync(PlaygroundPage());
        return response;
    }


    private string PlaygroundPage()
    {
        return @"
            <!DOCTYPE html>
            <html>
            <head>
                <title>GraphQL Playground</title>
                <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/graphql-playground-react/build/static/css/index.css"" />
                <link rel=""shortcut icon"" href=""https://www.graphqlbin.com/favicon.png"" />
                <script src=""https://cdn.jsdelivr.net/npm/graphql-playground-react/build/static/js/middleware.js""></script>
            </head>
            <body>
                <div id=""root""></div>
                <script type=""text/javascript"">
                    window.addEventListener('load', function (event) {
                        const root = document.getElementById('root');
                        root.classList.add('playgroundIn');
                        GraphQLPlayground.init(root, {
                            endpoint: '/api/graphql',
                            settings: {
                                'editor.theme': 'dark'
                            }
                        });
                    });
                </script>
            </body>
            </html>
        ";
    }
}
