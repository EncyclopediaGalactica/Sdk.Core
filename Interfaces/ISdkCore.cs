namespace EncyclopediaGalactica.Sdk.Core.Interfaces;

using Model.Interfaces;

/// <summary>
/// The Sdk Core Interface
/// </summary>
public interface ISdkCore
{
    /// <summary>
    ///<remarks></remarks>
    /// </summary>
    /// <param name="httpRequestMessage"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TResponseModel"></typeparam>
    /// <typeparam name="TResponseModelPayload"></typeparam>
    /// <returns></returns>
    Task<TResponseModel> SendAsync<TResponseModel, TResponseModelPayload>(
        HttpRequestMessage httpRequestMessage,
        CancellationToken cancellationToken = default)
        where TResponseModel : IHttpResponseModel<TResponseModelPayload>, new();
}