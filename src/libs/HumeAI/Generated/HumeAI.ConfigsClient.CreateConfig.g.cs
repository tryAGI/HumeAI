
#nullable enable

namespace HumeAI
{
    public partial class ConfigsClient
    {
        partial void PrepareCreateConfigArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::HumeAI.PostedConfig request);
        partial void PrepareCreateConfigRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::HumeAI.PostedConfig request);
        partial void ProcessCreateConfigResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateConfigResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create an EVI config
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HumeAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::HumeAI.ReturnConfig> CreateConfigAsync(

            global::HumeAI.PostedConfig request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateConfigArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::HumeAI.PathBuilder(
                path: "/v0/evi/configs",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateConfigRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateConfigResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateConfigResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::HumeAI.ReturnConfig.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::HumeAI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::HumeAI.ReturnConfig.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::HumeAI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Create an EVI config
        /// </summary>
        /// <param name="name"></param>
        /// <param name="versionDescription"></param>
        /// <param name="eviVersion"></param>
        /// <param name="prompt"></param>
        /// <param name="voice"></param>
        /// <param name="languageModel"></param>
        /// <param name="ellmModel"></param>
        /// <param name="tools"></param>
        /// <param name="builtinTools"></param>
        /// <param name="eventMessages"></param>
        /// <param name="timeouts"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::HumeAI.ReturnConfig> CreateConfigAsync(
            string name,
            string? versionDescription = default,
            string? eviVersion = default,
            global::HumeAI.PostedConfigPromptSpec? prompt = default,
            global::HumeAI.PostedUtteranceVoice? voice = default,
            global::HumeAI.PostedLanguageModel? languageModel = default,
            global::HumeAI.PostedEllmModel? ellmModel = default,
            global::System.Collections.Generic.IList<global::HumeAI.PostedUserDefinedToolSpec>? tools = default,
            global::System.Collections.Generic.IList<global::HumeAI.PostedBuiltinTool>? builtinTools = default,
            global::HumeAI.PostedEventMessageSpecs? eventMessages = default,
            global::HumeAI.PostedTimeoutSpecs? timeouts = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::HumeAI.PostedConfig
            {
                Name = name,
                VersionDescription = versionDescription,
                EviVersion = eviVersion,
                Prompt = prompt,
                Voice = voice,
                LanguageModel = languageModel,
                EllmModel = ellmModel,
                Tools = tools,
                BuiltinTools = builtinTools,
                EventMessages = eventMessages,
                Timeouts = timeouts,
            };

            return await CreateConfigAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}