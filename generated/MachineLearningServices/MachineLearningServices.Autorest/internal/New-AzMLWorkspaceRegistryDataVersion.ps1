
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create or update version.
.Description
Create or update version.
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBase
.Link
https://learn.microsoft.com/powershell/module/az.machinelearningservices/new-azmlworkspaceregistrydataversion
#>
function New-AzMLWorkspaceRegistryDataVersion {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBase])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Path')]
    [System.String]
    # Container name.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Path')]
    [System.String]
    # Name of Azure Machine Learning registry.
    # This is case-insensitive
    ${RegistryName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Path')]
    [System.String]
    # Version identifier.
    ${Version},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.DataType])]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.DataType]
    # [Required] Specifies the type of data.
    ${DataType},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # [Required] Uri of the data.
    # Example: https://go.microsoft.com/fwlink/linkid=2202330
    ${DataUri},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # The asset description text.
    ${Description},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # If the name version are system generated (anonymous registration).
    ${IsAnonymou},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Is the asset archived
    ${IsArchived},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseProperties]))]
    [System.Collections.Hashtable]
    # The asset property dictionary.
    ${ResourceBaseProperty},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseTags]))]
    [System.Collections.Hashtable]
    # Tag dictionary.
    # Tags can be added, removed, and updated.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        $mapping = @{
            CreateExpanded = 'Az.MachineLearningServices.private\New-AzMLWorkspaceRegistryDataVersion_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $testPlayback = $false
            $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }
            if ($testPlayback) {
                $PSBoundParameters['SubscriptionId'] = . (Join-Path $PSScriptRoot '..' 'utils' 'Get-SubscriptionIdTestSafe.ps1')
            } else {
                $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
            }
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {

        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {

        throw
    }

}
end {
    try {
        $steppablePipeline.End()

    } catch {

        throw
    }
} 
}
