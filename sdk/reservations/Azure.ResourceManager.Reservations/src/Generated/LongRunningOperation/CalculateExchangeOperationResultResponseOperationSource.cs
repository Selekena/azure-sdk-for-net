// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Reservations.Models;

namespace Azure.ResourceManager.Reservations
{
    internal class CalculateExchangeOperationResultResponseOperationSource : IOperationSource<CalculateExchangeOperationResultResponse>
    {
        CalculateExchangeOperationResultResponse IOperationSource<CalculateExchangeOperationResultResponse>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return CalculateExchangeOperationResultResponse.DeserializeCalculateExchangeOperationResultResponse(document.RootElement);
        }

        async ValueTask<CalculateExchangeOperationResultResponse> IOperationSource<CalculateExchangeOperationResultResponse>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return CalculateExchangeOperationResultResponse.DeserializeCalculateExchangeOperationResultResponse(document.RootElement);
        }
    }
}
