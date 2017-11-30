// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Internal.Resources
{
    using Management;
    using Internal;
    using Rest;
    using Rest.Azure;
    using Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// DeploymentsOperations operations.
    /// </summary>
    public partial interface IDeploymentsOperations
    {
        /// <summary>
        /// Deletes a deployment from the deployment history.
        /// </summary>
        /// <remarks>
        /// A template deployment that is currently running cannot be deleted.
        /// Deleting a template deployment removes the associated deployment
        /// operations. Deleting a template deployment does not affect the
        /// state of the resource group. This is an asynchronous operation that
        /// returns a status of 202 until the template deployment is
        /// successfully deleted. The Location response header contains the URI
        /// that is used to obtain the status of the process. While the process
        /// is running, a call to the URI in the Location header returns a
        /// status of 202. When the process finishes, the URI in the Location
        /// header returns a status of 204 on success. If the asynchronous
        /// request failed, the URI in the Location header returns an
        /// error-level status code.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group with the deployment to delete. The
        /// name is case insensitive.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the deployment to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string deploymentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Checks whether the deployment exists.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group with the deployment to check. The
        /// name is case insensitive.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the deployment to check.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<bool>> CheckExistenceWithHttpMessagesAsync(string resourceGroupName, string deploymentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deploys resources to a resource group.
        /// </summary>
        /// <remarks>
        /// You can provide the template and parameters directly in the request
        /// or link to JSON files.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to deploy the resources to. The name
        /// is case insensitive. The resource group must already exist.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the deployment.
        /// </param>
        /// <param name='parameters'>
        /// Additional parameters supplied to the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DeploymentExtended>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string deploymentName, Deployment parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a deployment.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the deployment to get.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DeploymentExtended>> GetWithHttpMessagesAsync(string resourceGroupName, string deploymentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Cancels a currently running template deployment.
        /// </summary>
        /// <remarks>
        /// You can cancel a deployment only if the provisioningState is
        /// Accepted or Running. After the deployment is canceled, the
        /// provisioningState is set to Canceled. Canceling a template
        /// deployment stops the currently running template deployment and
        /// leaves the resource group partially deployed.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the deployment to cancel.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> CancelWithHttpMessagesAsync(string resourceGroupName, string deploymentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Validates whether the specified template is syntactically correct
        /// and will be accepted by Azure Resource Manager..
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group the template will be deployed to.
        /// The name is case insensitive.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the deployment.
        /// </param>
        /// <param name='parameters'>
        /// Parameters to validate.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DeploymentValidateResult>> ValidateWithHttpMessagesAsync(string resourceGroupName, string deploymentName, Deployment parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Exports the template used for specified deployment.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the deployment from which to get the template.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DeploymentExportResult>> ExportTemplateWithHttpMessagesAsync(string resourceGroupName, string deploymentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all the deployments for a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group with the deployments to get. The
        /// name is case insensitive.
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<DeploymentExtended>>> ListWithHttpMessagesAsync(string resourceGroupName, ODataQuery<DeploymentExtendedFilter> odataQuery = default(ODataQuery<DeploymentExtendedFilter>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a deployment from the deployment history.
        /// </summary>
        /// <remarks>
        /// A template deployment that is currently running cannot be deleted.
        /// Deleting a template deployment removes the associated deployment
        /// operations. Deleting a template deployment does not affect the
        /// state of the resource group. This is an asynchronous operation that
        /// returns a status of 202 until the template deployment is
        /// successfully deleted. The Location response header contains the URI
        /// that is used to obtain the status of the process. While the process
        /// is running, a call to the URI in the Location header returns a
        /// status of 202. When the process finishes, the URI in the Location
        /// header returns a status of 204 on success. If the asynchronous
        /// request failed, the URI in the Location header returns an
        /// error-level status code.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group with the deployment to delete. The
        /// name is case insensitive.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the deployment to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string deploymentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deploys resources to a resource group.
        /// </summary>
        /// <remarks>
        /// You can provide the template and parameters directly in the request
        /// or link to JSON files.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to deploy the resources to. The name
        /// is case insensitive. The resource group must already exist.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the deployment.
        /// </param>
        /// <param name='parameters'>
        /// Additional parameters supplied to the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DeploymentExtended>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string deploymentName, Deployment parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all the deployments for a resource group.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<DeploymentExtended>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}

