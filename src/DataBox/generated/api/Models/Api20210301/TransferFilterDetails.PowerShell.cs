// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>Details of the filtering the transfer of data.</summary>
    [System.ComponentModel.TypeConverter(typeof(TransferFilterDetailsTypeConverter))]
    public partial class TransferFilterDetails
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.TransferFilterDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new TransferFilterDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.TransferFilterDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new TransferFilterDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="TransferFilterDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.TransferFilterDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal TransferFilterDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).BlobFilterDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IBlobFilterDetails) content.GetValueForProperty("BlobFilterDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).BlobFilterDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.BlobFilterDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).AzureFileFilterDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IAzureFileFilterDetails) content.GetValueForProperty("AzureFileFilterDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).AzureFileFilterDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.AzureFileFilterDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).DataAccountType = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.DataAccountType) content.GetValueForProperty("DataAccountType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).DataAccountType, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.DataAccountType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).FilterFileDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IFilterFileDetails[]) content.GetValueForProperty("FilterFileDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).FilterFileDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IFilterFileDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.FilterFileDetailsTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).BlobFilterDetailContainerList = (string[]) content.GetValueForProperty("BlobFilterDetailContainerList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).BlobFilterDetailContainerList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).BlobFilterDetailBlobPrefixList = (string[]) content.GetValueForProperty("BlobFilterDetailBlobPrefixList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).BlobFilterDetailBlobPrefixList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).BlobFilterDetailBlobPathList = (string[]) content.GetValueForProperty("BlobFilterDetailBlobPathList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).BlobFilterDetailBlobPathList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).AzureFileFilterDetailFilePrefixList = (string[]) content.GetValueForProperty("AzureFileFilterDetailFilePrefixList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).AzureFileFilterDetailFilePrefixList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).AzureFileFilterDetailFilePathList = (string[]) content.GetValueForProperty("AzureFileFilterDetailFilePathList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).AzureFileFilterDetailFilePathList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).AzureFileFilterDetailFileShareList = (string[]) content.GetValueForProperty("AzureFileFilterDetailFileShareList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).AzureFileFilterDetailFileShareList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.TransferFilterDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal TransferFilterDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).BlobFilterDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IBlobFilterDetails) content.GetValueForProperty("BlobFilterDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).BlobFilterDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.BlobFilterDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).AzureFileFilterDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IAzureFileFilterDetails) content.GetValueForProperty("AzureFileFilterDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).AzureFileFilterDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.AzureFileFilterDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).DataAccountType = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.DataAccountType) content.GetValueForProperty("DataAccountType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).DataAccountType, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.DataAccountType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).FilterFileDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IFilterFileDetails[]) content.GetValueForProperty("FilterFileDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).FilterFileDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IFilterFileDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.FilterFileDetailsTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).BlobFilterDetailContainerList = (string[]) content.GetValueForProperty("BlobFilterDetailContainerList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).BlobFilterDetailContainerList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).BlobFilterDetailBlobPrefixList = (string[]) content.GetValueForProperty("BlobFilterDetailBlobPrefixList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).BlobFilterDetailBlobPrefixList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).BlobFilterDetailBlobPathList = (string[]) content.GetValueForProperty("BlobFilterDetailBlobPathList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).BlobFilterDetailBlobPathList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).AzureFileFilterDetailFilePrefixList = (string[]) content.GetValueForProperty("AzureFileFilterDetailFilePrefixList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).AzureFileFilterDetailFilePrefixList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).AzureFileFilterDetailFilePathList = (string[]) content.GetValueForProperty("AzureFileFilterDetailFilePathList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).AzureFileFilterDetailFilePathList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).AzureFileFilterDetailFileShareList = (string[]) content.GetValueForProperty("AzureFileFilterDetailFileShareList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferFilterDetailsInternal)this).AzureFileFilterDetailFileShareList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            AfterDeserializePSObject(content);
        }
    }
    /// Details of the filtering the transfer of data.
    [System.ComponentModel.TypeConverter(typeof(TransferFilterDetailsTypeConverter))]
    public partial interface ITransferFilterDetails

    {

    }
}